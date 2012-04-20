namespace CustomSelectControl
{
    partial class MultipleSelectionControl
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
            this.FilterAndBody = new System.Windows.Forms.TableLayoutPanel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.splitAvailableSelected = new System.Windows.Forms.SplitContainer();
            this.tableLeftSplit = new System.Windows.Forms.TableLayoutPanel();
            this.tableLeftRight = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeftRight = new System.Windows.Forms.Panel();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.tableAvailable = new System.Windows.Forms.TableLayoutPanel();
            this.lbAvailable = new System.Windows.Forms.ListBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.tableRightSplit = new System.Windows.Forms.TableLayoutPanel();
            this.tableUpDown = new System.Windows.Forms.TableLayoutPanel();
            this.panelUpDown = new System.Windows.Forms.Panel();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.tableSelected = new System.Windows.Forms.TableLayoutPanel();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.FilterAndBody.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAvailableSelected)).BeginInit();
            this.splitAvailableSelected.Panel1.SuspendLayout();
            this.splitAvailableSelected.Panel2.SuspendLayout();
            this.splitAvailableSelected.SuspendLayout();
            this.tableLeftSplit.SuspendLayout();
            this.tableLeftRight.SuspendLayout();
            this.panelLeftRight.SuspendLayout();
            this.tableAvailable.SuspendLayout();
            this.tableRightSplit.SuspendLayout();
            this.tableUpDown.SuspendLayout();
            this.panelUpDown.SuspendLayout();
            this.tableSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterAndBody
            // 
            this.FilterAndBody.ColumnCount = 1;
            this.FilterAndBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FilterAndBody.Controls.Add(this.panelFilter, 0, 0);
            this.FilterAndBody.Controls.Add(this.splitAvailableSelected, 0, 1);
            this.FilterAndBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterAndBody.Location = new System.Drawing.Point(0, 0);
            this.FilterAndBody.Margin = new System.Windows.Forms.Padding(0);
            this.FilterAndBody.Name = "FilterAndBody";
            this.FilterAndBody.RowCount = 2;
            this.FilterAndBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10363F));
            this.FilterAndBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.89637F));
            this.FilterAndBody.Size = new System.Drawing.Size(447, 386);
            this.FilterAndBody.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.txtFilter);
            this.panelFilter.Controls.Add(this.lblFilter);
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(173, 33);
            this.panelFilter.TabIndex = 1;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(35, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(118, 20);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(6, 7);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(26, 13);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "filter";
            // 
            // splitAvailableSelected
            // 
            this.splitAvailableSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAvailableSelected.Location = new System.Drawing.Point(0, 39);
            this.splitAvailableSelected.Margin = new System.Windows.Forms.Padding(0);
            this.splitAvailableSelected.Name = "splitAvailableSelected";
            // 
            // splitAvailableSelected.Panel1
            // 
            this.splitAvailableSelected.Panel1.Controls.Add(this.tableLeftSplit);
            // 
            // splitAvailableSelected.Panel2
            // 
            this.splitAvailableSelected.Panel2.Controls.Add(this.tableRightSplit);
            this.splitAvailableSelected.Size = new System.Drawing.Size(447, 347);
            this.splitAvailableSelected.SplitterDistance = 207;
            this.splitAvailableSelected.TabIndex = 0;
            // 
            // tableLeftSplit
            // 
            this.tableLeftSplit.ColumnCount = 2;
            this.tableLeftSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeftSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLeftSplit.Controls.Add(this.tableLeftRight, 1, 0);
            this.tableLeftSplit.Controls.Add(this.tableAvailable, 0, 0);
            this.tableLeftSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLeftSplit.Location = new System.Drawing.Point(0, 0);
            this.tableLeftSplit.Margin = new System.Windows.Forms.Padding(0);
            this.tableLeftSplit.Name = "tableLeftSplit";
            this.tableLeftSplit.RowCount = 1;
            this.tableLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLeftSplit.Size = new System.Drawing.Size(207, 347);
            this.tableLeftSplit.TabIndex = 0;
            // 
            // tableLeftRight
            // 
            this.tableLeftRight.ColumnCount = 1;
            this.tableLeftRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLeftRight.Controls.Add(this.panelLeftRight, 0, 1);
            this.tableLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLeftRight.Location = new System.Drawing.Point(172, 0);
            this.tableLeftRight.Margin = new System.Windows.Forms.Padding(0);
            this.tableLeftRight.Name = "tableLeftRight";
            this.tableLeftRight.RowCount = 3;
            this.tableLeftRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLeftRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLeftRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLeftRight.Size = new System.Drawing.Size(35, 347);
            this.tableLeftRight.TabIndex = 12;
            // 
            // panelLeftRight
            // 
            this.panelLeftRight.Controls.Add(this.btnAddAll);
            this.panelLeftRight.Controls.Add(this.btnAddItem);
            this.panelLeftRight.Controls.Add(this.btnRemoveItem);
            this.panelLeftRight.Controls.Add(this.btnRemoveAll);
            this.panelLeftRight.Location = new System.Drawing.Point(0, 117);
            this.panelLeftRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftRight.MinimumSize = new System.Drawing.Size(35, 113);
            this.panelLeftRight.Name = "panelLeftRight";
            this.panelLeftRight.Size = new System.Drawing.Size(35, 113);
            this.panelLeftRight.TabIndex = 11;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(3, 0);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(29, 23);
            this.btnAddAll.TabIndex = 2;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(3, 29);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(29, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = ">";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(3, 58);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "<";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(3, 87);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // tableAvailable
            // 
            this.tableAvailable.ColumnCount = 1;
            this.tableAvailable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAvailable.Controls.Add(this.lbAvailable, 0, 1);
            this.tableAvailable.Controls.Add(this.lblAvailable, 0, 0);
            this.tableAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAvailable.Location = new System.Drawing.Point(0, 0);
            this.tableAvailable.Margin = new System.Windows.Forms.Padding(0);
            this.tableAvailable.Name = "tableAvailable";
            this.tableAvailable.RowCount = 2;
            this.tableAvailable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableAvailable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAvailable.Size = new System.Drawing.Size(172, 347);
            this.tableAvailable.TabIndex = 13;
            // 
            // lbAvailable
            // 
            this.lbAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAvailable.FormattingEnabled = true;
            this.lbAvailable.Location = new System.Drawing.Point(0, 20);
            this.lbAvailable.Margin = new System.Windows.Forms.Padding(0);
            this.lbAvailable.MinimumSize = new System.Drawing.Size(100, 100);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(172, 327);
            this.lbAvailable.TabIndex = 14;
            this.lbAvailable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAvailable_MouseDoubleClick);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(3, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(50, 13);
            this.lblAvailable.TabIndex = 13;
            this.lblAvailable.Text = "Available";
            // 
            // tableRightSplit
            // 
            this.tableRightSplit.ColumnCount = 2;
            this.tableRightSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRightSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableRightSplit.Controls.Add(this.tableUpDown, 1, 0);
            this.tableRightSplit.Controls.Add(this.tableSelected, 0, 0);
            this.tableRightSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRightSplit.Location = new System.Drawing.Point(0, 0);
            this.tableRightSplit.Margin = new System.Windows.Forms.Padding(0);
            this.tableRightSplit.Name = "tableRightSplit";
            this.tableRightSplit.RowCount = 1;
            this.tableRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRightSplit.Size = new System.Drawing.Size(236, 347);
            this.tableRightSplit.TabIndex = 0;
            // 
            // tableUpDown
            // 
            this.tableUpDown.ColumnCount = 1;
            this.tableUpDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUpDown.Controls.Add(this.panelUpDown, 0, 1);
            this.tableUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUpDown.Location = new System.Drawing.Point(201, 0);
            this.tableUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.tableUpDown.Name = "tableUpDown";
            this.tableUpDown.RowCount = 3;
            this.tableUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableUpDown.Size = new System.Drawing.Size(35, 347);
            this.tableUpDown.TabIndex = 0;
            // 
            // panelUpDown
            // 
            this.panelUpDown.Controls.Add(this.btnMoveUp);
            this.panelUpDown.Controls.Add(this.btnMoveDown);
            this.panelUpDown.Location = new System.Drawing.Point(0, 145);
            this.panelUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpDown.MinimumSize = new System.Drawing.Size(35, 56);
            this.panelUpDown.Name = "panelUpDown";
            this.panelUpDown.Size = new System.Drawing.Size(35, 56);
            this.panelUpDown.TabIndex = 12;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(3, 0);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(29, 23);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.Text = "/\\";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(3, 29);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(29, 23);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.Text = "\\/";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // tableSelected
            // 
            this.tableSelected.ColumnCount = 1;
            this.tableSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSelected.Controls.Add(this.lbSelected, 0, 1);
            this.tableSelected.Controls.Add(this.lblSelected, 0, 0);
            this.tableSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSelected.Location = new System.Drawing.Point(0, 0);
            this.tableSelected.Margin = new System.Windows.Forms.Padding(0);
            this.tableSelected.Name = "tableSelected";
            this.tableSelected.RowCount = 2;
            this.tableSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSelected.Size = new System.Drawing.Size(201, 347);
            this.tableSelected.TabIndex = 1;
            // 
            // lbSelected
            // 
            this.lbSelected.AllowDrop = true;
            this.lbSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.Location = new System.Drawing.Point(0, 20);
            this.lbSelected.Margin = new System.Windows.Forms.Padding(0);
            this.lbSelected.MinimumSize = new System.Drawing.Size(100, 100);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(201, 327);
            this.lbSelected.TabIndex = 15;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(3, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(49, 13);
            this.lblSelected.TabIndex = 14;
            this.lblSelected.Text = "Selected";
            // 
            // MultipleSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterAndBody);
            this.Name = "MultipleSelectionControl";
            this.Size = new System.Drawing.Size(447, 386);
            this.FilterAndBody.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.splitAvailableSelected.Panel1.ResumeLayout(false);
            this.splitAvailableSelected.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAvailableSelected)).EndInit();
            this.splitAvailableSelected.ResumeLayout(false);
            this.tableLeftSplit.ResumeLayout(false);
            this.tableLeftRight.ResumeLayout(false);
            this.panelLeftRight.ResumeLayout(false);
            this.tableAvailable.ResumeLayout(false);
            this.tableAvailable.PerformLayout();
            this.tableRightSplit.ResumeLayout(false);
            this.tableUpDown.ResumeLayout(false);
            this.panelUpDown.ResumeLayout(false);
            this.tableSelected.ResumeLayout(false);
            this.tableSelected.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FilterAndBody;
        private System.Windows.Forms.SplitContainer splitAvailableSelected;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TableLayoutPanel tableLeftSplit;
        private System.Windows.Forms.TableLayoutPanel tableLeftRight;
        private System.Windows.Forms.Panel panelLeftRight;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TableLayoutPanel tableAvailable;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lbAvailable;
        private System.Windows.Forms.TableLayoutPanel tableRightSplit;
        private System.Windows.Forms.TableLayoutPanel tableUpDown;
        private System.Windows.Forms.Panel panelUpDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.TableLayoutPanel tableSelected;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lbSelected;

    }
}
