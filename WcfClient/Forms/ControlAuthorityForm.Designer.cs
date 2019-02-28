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
            this.accessString_textBox.Location = new System.Drawing.Point(585, 19);
            this.accessString_textBox.Name = "accessString_textBox";
            this.accessString_textBox.Size = new System.Drawing.Size(347, 25);
            this.accessString_textBox.TabIndex = 3;
            // 
            // contrlPath_textBox
            // 
            this.contrlPath_textBox.Location = new System.Drawing.Point(73, 19);
            this.contrlPath_textBox.Name = "contrlPath_textBox";
            this.contrlPath_textBox.Size = new System.Drawing.Size(347, 25);
            this.contrlPath_textBox.TabIndex = 1;
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Location = new System.Drawing.Point(5, 23);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(67, 15);
            this.path_label.TabIndex = 0;
            this.path_label.Text = "控件名：";
            // 
            // accessstring_label
            // 
            this.accessstring_label.AutoSize = true;
            this.accessstring_label.Location = new System.Drawing.Point(465, 23);
            this.accessstring_label.Name = "accessstring_label";
            this.accessstring_label.Size = new System.Drawing.Size(118, 15);
            this.accessstring_label.TabIndex = 0;
            this.accessstring_label.Text = "AccessString：";
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Location = new System.Drawing.Point(1424, 16);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(66, 30);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "查询";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_button.Location = new System.Drawing.Point(1535, 16);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(66, 30);
            this.reset_button.TabIndex = 4;
            this.reset_button.Text = "重置";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.Location = new System.Drawing.Point(1010, 16);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(66, 30);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "新增";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Location = new System.Drawing.Point(1238, 16);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(66, 30);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "删除";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // modify_button
            // 
            this.modify_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_button.Location = new System.Drawing.Point(1124, 16);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(66, 30);
            this.modify_button.TabIndex = 4;
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
            this.sfDataGrid.Location = new System.Drawing.Point(8, 58);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.Size = new System.Drawing.Size(1595, 341);
            this.sfDataGrid.TabIndex = 5;
            this.sfDataGrid.Text = "sfDataGrid";
            // 
            // sfDataPager
            // 
            this.sfDataPager.AccessibleName = "DataPager";
            this.sfDataPager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sfDataPager.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfDataPager.Location = new System.Drawing.Point(616, 403);
            this.sfDataPager.Name = "sfDataPager";
            this.sfDataPager.Size = new System.Drawing.Size(376, 46);
            this.sfDataPager.TabIndex = 6;
            this.sfDataPager.Text = "sfDataPager";
            this.sfDataPager.PageIndexChanged += new System.EventHandler<Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs>(this.sfDataPager_PageIndexChanged);
            // 
            // ControlAuthorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 451);
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
            this.Location = new System.Drawing.Point(0, 0);
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