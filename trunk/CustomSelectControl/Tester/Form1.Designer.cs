﻿namespace Tester
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Rules = new CustomSelectControl.MultipleSelectionControl();
            this.SuspendLayout();
            // 
            // Rules
            // 
            this.Rules.AllowMultipleItems = true;
            this.Rules.DisplayFilter = true;
            this.Rules.Location = new System.Drawing.Point(3, 3);
            this.Rules.Name = "Rules";
            this.Rules.SelectedItems = ((System.Collections.Generic.List<object>)(resources.GetObject("Rules.SelectedItems")));
            this.Rules.Size = new System.Drawing.Size(363, 233);
            this.Rules.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 240);
            this.Controls.Add(this.Rules);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomSelectControl.MultipleSelectionControl Rules;

    }
}

