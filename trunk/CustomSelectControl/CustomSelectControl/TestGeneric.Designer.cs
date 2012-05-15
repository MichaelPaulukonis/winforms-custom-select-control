namespace CustomSelectControl
{
    partial class TestGeneric<T>
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedItems = new System.Windows.Forms.ListBox();
            this.AvailableItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectedItems
            // 
            this.SelectedItems.FormattingEnabled = true;
            this.SelectedItems.Location = new System.Drawing.Point(248, 15);
            this.SelectedItems.Name = "SelectedItems";
            this.SelectedItems.Size = new System.Drawing.Size(120, 160);
            this.SelectedItems.TabIndex = 3;
            // 
            // AvailableItems
            // 
            this.AvailableItems.FormattingEnabled = true;
            this.AvailableItems.Location = new System.Drawing.Point(41, 15);
            this.AvailableItems.Name = "AvailableItems";
            this.AvailableItems.Size = new System.Drawing.Size(120, 160);
            this.AvailableItems.TabIndex = 2;
            // 
            // TestGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedItems);
            this.Controls.Add(this.AvailableItems);
            this.Name = "TestGeneric";
            this.Size = new System.Drawing.Size(479, 187);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SelectedItems;
        private System.Windows.Forms.ListBox AvailableItems;
    }
}
