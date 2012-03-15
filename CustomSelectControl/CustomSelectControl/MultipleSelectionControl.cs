using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomSelectControl
{
    // inspired by http://www.codeproject.com/Articles/8219/Enhanced-List-Box-Control
    // and http://www.codeproject.com/Articles/36624/Multiple-Selection-Control
    // with help from the fine folks @ http://stackoverflow.com/questions/9505403/where-can-i-find-this-net-winforms-control-if-it-exists
    public partial class MultipleSelectionControl : UserControl
    {
        public MultipleSelectionControl()
        {
            InitializeComponent();
        }

        private int _filterLength = 0;
        private List<Object> _originalItems;
        private bool _allowMultipleItems = true;

        public List<Object> AvailableItems
        {
            set
            {
                lbAvailable.DataSource = value;
                _originalItems = value;
            }
        }

        public List<object> SelectedItems
        {
            set
            {
                foreach (var item in value)
                {
                    lbSelected.Items.Add(item);
                }
            }
            get
            {
                return lbSelected.Items.Cast<object>().ToList();
            }
        }

        private bool _df = true;

        public bool DisplayFilter
        {
            get { return _df; }
            set
            {
                _df = value;
                //lblFilter.Visible = _df;
                //txtFilter.Visible = _df;
                panelFilter.Visible = _df;
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            AddRemoveAll(lbAvailable, lbSelected);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddRemoveItem(lbAvailable, lbSelected);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            AddRemoveItem(lbSelected, lbAvailable);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lbSelected.Items.Clear();
            lbAvailable.DataSource = _originalItems;
            ApplyFilterToAvailable();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            Move(lbSelected, -1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            Move(lbSelected, 1);
        }

        // we can't automatically add the original items to the selectedItem items
        // becuase some may already have been added and edited
        // so, loop through _what remains_
        private void AddRemoveAll(ListBox source, ListBox target)
        {
            // if we are targetting the Available items, we will be adding in the editing version
            // instead of the original. yoiks
            foreach (var item in source.Items)
            {
                AddItem(target, item);
            }

            // clearing DataSource will only work on lbAvailable
            // Items.Clear() will only work on Selected
            if (source == lbSelected)
            {
                source.Items.Clear();
            }
            else
            {
                if (!AllowMultipleItems)
                {
                    source.DataSource = null;
                }
            }
        }

        private bool ContainsItem(ListBox source, object target)
        {
            return source.Items.Cast<object>().Any(t => t == target);
        }

        /// <summary>
        /// Remove item from Selected items
        /// Add item to Selected items, adding a clone if possible
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="item"></param>
        private void AddRemoveItem(ListBox source, ListBox target, object item)
        {
            AddItem(target, item);

            ItemRemover(source, item);
        }

        // TODO: adding the item from Selected to Available MAY BE INCORRECT
        // as SELECTED ITEM may be a (modified) clone, and not the original object
        // durrr....
        private void AddItem(ListBox target, object item)
        {
            var toBeAdded = item;

            // this may be an awful practice
            // http://stackoverflow.com/questions/699210/why-should-i-implement-icloneable-in-c

            if (AllowMultipleItems) // only clone if we can have multiples
            {
                var cloneable = item as ICloneable;
                if (cloneable != null)
                {
                    toBeAdded = cloneable.Clone();
                }
            }

            if ((target != lbAvailable) && AllowMultipleItems || !(AllowMultipleItems || ContainsItem(target, item)))
            {
                // don't remove from Available, and don't add back. It just... stays.
                target.Items.Add(toBeAdded);
            }
        }

        // we don't want to (and can't) actually remove from the Available listbox
        // (DataSource binding throws and exception)
        // and we want to add multiple times, anyway
        // so explicitly check which is which
        private void AddRemoveItem(ListBox source, ListBox target)
        {
            if (source.SelectedIndex >= 0)
            {
                AddRemoveItem(source, target, source.Items[source.SelectedIndex]);
            }
        }

        private new void Move(ListBox lstBox, int iOffset)
        {
            try
            {
                var sel = lstBox.SelectedItem;
                var originalLoc = lstBox.SelectedIndex;
                // don't move past first index, last index, and ignore if the same (WAT?!?!)
                var newLoc = originalLoc + iOffset;
                if (newLoc >= 0 && newLoc <= lstBox.Items.Count - 1 && newLoc != originalLoc)
                {
                    lstBox.Items.RemoveAt(originalLoc);
                    lstBox.Items.Insert(newLoc, sel);
                    lstBox.SelectedIndex = newLoc;
                }
            }

            catch (Exception ex)
            {
                // TODO: log
            }
        }

        public void UpdateSelected(object selectedItem)
        {
            for (var i = 0; i < lbSelected.Items.Count; ++i)
            {
                if (lbSelected.Items[i] == selectedItem)
                {
                    // this looks counter-intuitive
                    // but the action forces a refresh of the the displayed ToString
                    lbSelected.Items[i] = selectedItem;
                }
            }
        }

        public MultipleSelectionControl SetAvailableLabel(string label)
        {
            lblAvailable.Text = label;
            return this;
        }

        public MultipleSelectionControl SetSelectedLabel(string label)
        {
            lblSelected.Text = label;
            return this;
        }

        public bool AllowMultipleItems
        {
            get { return _allowMultipleItems; }
            set { _allowMultipleItems = value; }
        }

        // double-click on available = move to selectedItem
        private void lbAvailable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbAvailable.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                AddRemoveItem(lbAvailable, lbSelected);
            }
        }

        // need to adapt this for removal events....
        // but they can be considered a filter, I suppose....
        // but a different filter, so the "contains" code will not work for that
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text.Length < _filterLength)
            {
                // reset DataSource if filter has had chars deleted
                // so we can re-filter on the original mainly for deletions)
                lbAvailable.DataSource = _originalItems;
            }

            _filterLength = txtFilter.Text.Length;

            // only filter if... there is a filter
            if (_filterLength > 0)
            {
                ApplyFilterToAvailable();
            }
        }

        private void ApplyFilterToAvailable()
        {
            var myOtherList = lbAvailable.Items.Cast<Object>().ToList();
            lbAvailable.DataSource = null;

            var filtered = myOtherList.Where(x => x.ToString().Contains(txtFilter.Text)).ToList();

            lbAvailable.DataSource = filtered;
        }

        // if Not AllowMultiples, and selectedItem item is modified
        // we can't move it back over toe Available items
        // BECUASE IT HAS BEEN MODIFIED
        // we need the original.
        // DAMMIT
        private void ItemRemover(ListBox target, object item)
        {
            if (target != lbAvailable)
            {
                // Items collection cannot be modified when the DataSource property is set.
                target.Items.Remove(item);
            }
            //target.Items.Remove(item); // can't use this with a DataSource. waaaah!

            //var myOtherList = target.Items.Cast<Object>().ToList();
            //lbAvailable.DataSource = null;

            //var filtered = myOtherList.Where(t => t != item).ToList();

            //target.DataSource = filtered;
        }

        // add a double-click handler from the caller
        // so that an action can be taken on the object
        // ie, configure, etc.
        // without exiting the control
        public void AddDoubleClickHandler(EventHandler e)
        {
            lbSelected.MouseDoubleClick += new MouseEventHandler(e);
        }
    }
}