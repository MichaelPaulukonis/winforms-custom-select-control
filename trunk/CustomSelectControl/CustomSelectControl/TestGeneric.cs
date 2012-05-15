using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomSelectControl
{
    public partial class TestGeneric<T> : UserControl
    {
        private IEnumerable<T> _selections;

        public TestGeneric()
        {
            InitializeComponent();
            _selections = new List<T>();
            SelectedItems.DataSource = _selections;
        }

        public IEnumerable<T> Selected
        {
            // this returns an object that is bound locally
            // but when the object changes... the ListBox will NOT change.
            // :::sigh:::
            get { return _selections; }

            set
            {
                _selections = value;
                SelectedItems.Items.Clear();
                //    foreach (var item in value)
                //    {
                //        SelectedItems.Items.Add(value);
                //    }
            }
        }
    }
}