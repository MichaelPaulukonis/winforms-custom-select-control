using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Rules.AddDoubleClickHandler(DisplayEditor);

            Rules.AvailableItems = GetList().Cast<object>().ToList();

            Rules.AllowMultipleItems = true;
        }

        private readonly List<Thing> _activeEditors = new List<Thing>();

        public void DisplayEditor(object sender, EventArgs e)
        {
            // DAMMIT! we still have implementation details exposed. WTF!!!!
            // TODO: fix this
            var t = (Thing)((ListBox)sender).SelectedItem;

            if (!_activeEditors.Contains(t)) // only allow one editing instance
            {
                _activeEditors.Add(t);

                // okay, the editor needs to know that the control exists, but not about the internal workings
                // HOORAY! ENCAPSULATION MAINTAINED!!!!!
                var ed = new ThingEditor(t, Rules, _activeEditors);

                ed.Show();
            }
        }

        public List<Thing> GetList()
        {
            var tsil = new List<Thing>();

            // no noticeable slowdown on 3000 items
            // but 30,000 is a bit slow
            for (var i = 0; i < 10; ++i)
            {
                var t = new Thing(i, i.ToString());
                tsil.Add(t);
            }

            return tsil;
        }
    }

    // to test adding an object
    // must have an overridden ToString() property in order to appear nicely in a ListBox
    // implementing ICloneable means we can add separately modifieable copies, not multiple references
    public class Thing : ICloneable
    {
        public Thing(int data, string name)
        {
            Data = data;
            Name = name;
        }

        public int Data { get; set; }

        public string Name { get; set; }

        public Thing Modify()
        {
            ++Data;
            Name = Data.ToString(CultureInfo.InvariantCulture);
            return this;
        }

        // required to appear in listBox
        public override string ToString()
        {
            return Name;
        }

        public object Clone()
        {
            var clone = new Thing(this.Data, this.Name);

            return clone;
        }
    }
}