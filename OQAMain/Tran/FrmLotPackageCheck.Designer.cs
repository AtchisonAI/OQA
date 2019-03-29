namespace OQAMain
{
    partial class FrmLotPackageCheck
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
            this.lotId_textBox = new System.Windows.Forms.TextBox();
            this.lotId_label = new System.Windows.Forms.Label();
            this.lotInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.print_button = new System.Windows.Forms.Button();
            this.package_groupBox = new System.Windows.Forms.GroupBox();
            this.check_sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlMenu.SuspendLayout();
            this.lotInfo_groupBox.SuspendLayout();
            this.package_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(651, 6);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(467, 6);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(559, 6);
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // lotId_textBox
            // 
            this.lotId_textBox.Location = new System.Drawing.Point(72, 28);
            this.lotId_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.lotId_textBox.Name = "lotId_textBox";
            this.lotId_textBox.Size = new System.Drawing.Size(163, 21);
            this.lotId_textBox.TabIndex = 0;
            this.lotId_textBox.Click += new System.EventHandler(this.lotId_textBox_Click);
            this.lotId_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lotId_textBox_KeyPress);
            // 
            // lotId_label
            // 
            this.lotId_label.AutoSize = true;
            this.lotId_label.Location = new System.Drawing.Point(25, 32);
            this.lotId_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lotId_label.Name = "lotId_label";
            this.lotId_label.Size = new System.Drawing.Size(47, 12);
            this.lotId_label.TabIndex = 1;
            this.lotId_label.Text = "Lot ID:";
            // 
            // lotInfo_groupBox
            // 
            this.lotInfo_groupBox.Controls.Add(this.print_button);
            this.lotInfo_groupBox.Controls.Add(this.lotId_textBox);
            this.lotInfo_groupBox.Controls.Add(this.lotId_label);
            this.lotInfo_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lotInfo_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lotInfo_groupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotInfo_groupBox.Location = new System.Drawing.Point(0, 0);
            this.lotInfo_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.lotInfo_groupBox.Name = "lotInfo_groupBox";
            this.lotInfo_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.lotInfo_groupBox.Size = new System.Drawing.Size(750, 64);
            this.lotInfo_groupBox.TabIndex = 2;
            this.lotInfo_groupBox.TabStop = false;
            this.lotInfo_groupBox.Text = "Lot Information";
            // 
            // print_button
            // 
            this.print_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_button.Location = new System.Drawing.Point(637, 23);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(62, 26);
            this.print_button.TabIndex = 2;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // package_groupBox
            // 
            this.package_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.package_groupBox.Controls.Add(this.check_sfDataGrid);
            this.package_groupBox.Location = new System.Drawing.Point(0, 68);
            this.package_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.package_groupBox.Name = "package_groupBox";
            this.package_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.package_groupBox.Size = new System.Drawing.Size(750, 468);
            this.package_groupBox.TabIndex = 3;
            this.package_groupBox.TabStop = false;
            this.package_groupBox.Text = "Wafer Package";
            // 
            // check_sfDataGrid
            // 
            this.check_sfDataGrid.AccessibleName = "Table";
            this.check_sfDataGrid.AllowDraggingColumns = true;
            this.check_sfDataGrid.AllowResizingColumns = true;
            this.check_sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_sfDataGrid.AutoGenerateColumns = false;
            this.check_sfDataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.check_sfDataGrid.Location = new System.Drawing.Point(1, 13);
            this.check_sfDataGrid.Name = "check_sfDataGrid";
            this.check_sfDataGrid.ShowBusyIndicator = true;
            this.check_sfDataGrid.Size = new System.Drawing.Size(745, 400);
            this.check_sfDataGrid.TabIndex = 26;
            this.check_sfDataGrid.Text = "sfDataGrid1";
            // 
            // FrmLotPackageCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.package_groupBox);
            this.Controls.Add(this.lotInfo_groupBox);
            this.Name = "FrmLotPackageCheck";
            this.Text = "Lot Package Check";
            this.Controls.SetChildIndex(this.lotInfo_groupBox, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.package_groupBox, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.lotInfo_groupBox.ResumeLayout(false);
            this.lotInfo_groupBox.PerformLayout();
            this.package_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_sfDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lotId_textBox;
        private System.Windows.Forms.Label lotId_label;
        private System.Windows.Forms.GroupBox lotInfo_groupBox;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.GroupBox package_groupBox;
        private Syncfusion.WinForms.DataGrid.SfDataGrid check_sfDataGrid;
    }
}