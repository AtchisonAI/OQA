namespace WcfClient.Forms
{
    partial class ControlAuthorityForm
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
            this.accessString_textBox = new System.Windows.Forms.TextBox();
            this.contrlPath_textBox = new System.Windows.Forms.TextBox();
            this.path_label = new System.Windows.Forms.Label();
            this.accessstring_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDataPager = new Syncfusion.WinForms.DataPager.SfDataPager();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accessString_textBox
            // 
            this.accessString_textBox.Location = new System.Drawing.Point(439, 15);
            this.accessString_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.accessString_textBox.Name = "accessString_textBox";
            this.accessString_textBox.Size = new System.Drawing.Size(261, 21);
            this.accessString_textBox.TabIndex = 1;
            // 
            // contrlPath_textBox
            // 
            this.contrlPath_textBox.Location = new System.Drawing.Point(55, 15);
            this.contrlPath_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.contrlPath_textBox.Name = "contrlPath_textBox";
            this.contrlPath_textBox.Size = new System.Drawing.Size(261, 21);
            this.contrlPath_textBox.TabIndex = 0;
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Location = new System.Drawing.Point(4, 18);
            this.path_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(53, 12);
            this.path_label.TabIndex = 0;
            this.path_label.Text = "控件名：";
            // 
            // accessstring_label
            // 
            this.accessstring_label.AutoSize = true;
            this.accessstring_label.Location = new System.Drawing.Point(349, 18);
            this.accessstring_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accessstring_label.Name = "accessstring_label";
            this.accessstring_label.Size = new System.Drawing.Size(89, 12);
            this.accessstring_label.TabIndex = 0;
            this.accessstring_label.Text = "AccessString：";
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Location = new System.Drawing.Point(1068, 13);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(50, 24);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "查询";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_button.Location = new System.Drawing.Point(1151, 13);
            this.reset_button.Margin = new System.Windows.Forms.Padding(2);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(50, 24);
            this.reset_button.TabIndex = 3;
            this.reset_button.Text = "重置";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.Location = new System.Drawing.Point(758, 13);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(50, 24);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "新增";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Location = new System.Drawing.Point(928, 13);
            this.delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(50, 24);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "删除";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // modify_button
            // 
            this.modify_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_button.Location = new System.Drawing.Point(843, 13);
            this.modify_button.Margin = new System.Windows.Forms.Padding(2);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(50, 24);
            this.modify_button.TabIndex = 5;
            this.modify_button.Text = "修改";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDeleting = true;
            this.sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGrid.Location = new System.Drawing.Point(6, 59);
            this.sfDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.sfDataGrid.Size = new System.Drawing.Size(1197, 258);
            this.sfDataGrid.TabIndex = 5;
            this.sfDataGrid.Text = "sfDataGrid";
            // 
            // sfDataPager
            // 
            this.sfDataPager.AccessibleName = "DataPager";
            this.sfDataPager.AllowOnDemandPaging = true;
            this.sfDataPager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sfDataPager.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfDataPager.Location = new System.Drawing.Point(392, 322);
            this.sfDataPager.Margin = new System.Windows.Forms.Padding(2);
            this.sfDataPager.Name = "sfDataPager";
            this.sfDataPager.PageCount = 1;
            this.sfDataPager.Size = new System.Drawing.Size(431, 37);
            this.sfDataPager.TabIndex = 7;
            this.sfDataPager.Text = "sfDataPager";
            this.sfDataPager.PageIndexChanged += new System.EventHandler<Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs>(this.sfDataPager_PageIndexChanged);
            // 
            // ControlAuthorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 361);
            this.Controls.Add(this.sfDataPager);
            this.Controls.Add(this.sfDataGrid);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.accessString_textBox);
            this.Controls.Add(this.accessstring_label);
            this.Controls.Add(this.contrlPath_textBox);
            this.Controls.Add(this.path_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ControlAuthorityForm";
            this.ShowMaximizeBox = false;
            this.Text = "权限控制";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label path_label;
        private System.Windows.Forms.Label accessstring_label;
        private System.Windows.Forms.TextBox accessString_textBox;
        private System.Windows.Forms.TextBox contrlPath_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button modify_button;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid;
        private Syncfusion.WinForms.DataPager.SfDataPager sfDataPager;
    }
}