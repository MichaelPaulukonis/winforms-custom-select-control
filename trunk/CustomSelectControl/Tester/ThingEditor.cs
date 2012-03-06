using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CustomSelectControl;

namespace Tester
{
    public partial class ThingEditor : Form
    {
        private List<Thing> _activeEditors;
        private MultipleSelectionControl _control;

        public ThingEditor()
        {
            InitializeComponent();
        }

        public ThingEditor(Thing thing, MultipleSelectionControl control, List<Thing> activeEditors)
            : this()
        {
            Thing = thing;
            txtData.Text = Thing.Data.ToString();
            txtName.Text = Thing.Name;
            _activeEditors = activeEditors;

            _control = control;
            FormClosing += FormCloser;
        }

        public void FormCloser(object sender, FormClosingEventArgs e)
        {
            _activeEditors.Remove(Thing);
            _control.UpdateSelected(Thing);
        }

        public Thing Thing { get; set; }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Thing.Name = txtName.Text;
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            // hey, you're going to fail on characters!
            // but who cares, this is a simple test of something else...
            Thing.Data = int.Parse(txtData.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            this.Close();
        }

        public void AddFormClosingHandler(FormClosingEventHandler h)
        {
            FormClosing += h;
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Save();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txtData.Focus();
            }
        }
    }
}