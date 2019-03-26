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
            this.pin_comboBox = new System.Windows.Forms.ComboBox();
            this.pin_checkBox = new System.Windows.Forms.CheckBox();
            this.foreign_comboBox = new System.Windows.Forms.ComboBox();
            this.seal_comboBox = new System.Windows.Forms.ComboBox();
            this.peel_comboBox = new System.Windows.Forms.ComboBox();
            this.packing_comboBox = new System.Windows.Forms.ComboBox();
            this.surface_comboBox = new System.Windows.Forms.ComboBox();
            this.ship_comboBox = new System.Windows.Forms.ComboBox();
            this.fosb_comboBox = new System.Windows.Forms.ComboBox();
            this.foreign_checkBox = new System.Windows.Forms.CheckBox();
            this.seal_checkBox = new System.Windows.Forms.CheckBox();
            this.peel_checkBox = new System.Windows.Forms.CheckBox();
            this.packing_checkBox = new System.Windows.Forms.CheckBox();
            this.surface_checkBox = new System.Windows.Forms.CheckBox();
            this.ship_checkBox = new System.Windows.Forms.CheckBox();
            this.fosb_checkBox = new System.Windows.Forms.CheckBox();
            this.pnlMenu.SuspendLayout();
            this.lotInfo_groupBox.SuspendLayout();
            this.package_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(883, 6);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(677, 6);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(780, 6);
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 653);
            this.pnlMenu.Size = new System.Drawing.Size(1000, 40);
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
            this.lotInfo_groupBox.Size = new System.Drawing.Size(1000, 64);
            this.lotInfo_groupBox.TabIndex = 2;
            this.lotInfo_groupBox.TabStop = false;
            this.lotInfo_groupBox.Text = "Lot Information";
            // 
            // print_button
            // 
            this.print_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_button.Location = new System.Drawing.Point(887, 23);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(62, 26);
            this.print_button.TabIndex = 2;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            // 
            // package_groupBox
            // 
            this.package_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.package_groupBox.Controls.Add(this.pin_comboBox);
            this.package_groupBox.Controls.Add(this.pin_checkBox);
            this.package_groupBox.Controls.Add(this.foreign_comboBox);
            this.package_groupBox.Controls.Add(this.seal_comboBox);
            this.package_groupBox.Controls.Add(this.peel_comboBox);
            this.package_groupBox.Controls.Add(this.packing_comboBox);
            this.package_groupBox.Controls.Add(this.surface_comboBox);
            this.package_groupBox.Controls.Add(this.ship_comboBox);
            this.package_groupBox.Controls.Add(this.fosb_comboBox);
            this.package_groupBox.Controls.Add(this.foreign_checkBox);
            this.package_groupBox.Controls.Add(this.seal_checkBox);
            this.package_groupBox.Controls.Add(this.peel_checkBox);
            this.package_groupBox.Controls.Add(this.packing_checkBox);
            this.package_groupBox.Controls.Add(this.surface_checkBox);
            this.package_groupBox.Controls.Add(this.ship_checkBox);
            this.package_groupBox.Controls.Add(this.fosb_checkBox);
            this.package_groupBox.Location = new System.Drawing.Point(0, 68);
            this.package_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.package_groupBox.Name = "package_groupBox";
            this.package_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.package_groupBox.Size = new System.Drawing.Size(1000, 581);
            this.package_groupBox.TabIndex = 3;
            this.package_groupBox.TabStop = false;
            this.package_groupBox.Text = "Wafer Package";
            // 
            // pin_comboBox
            // 
            this.pin_comboBox.Enabled = false;
            this.pin_comboBox.FormattingEnabled = true;
            this.pin_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.pin_comboBox.Location = new System.Drawing.Point(727, 241);
            this.pin_comboBox.Name = "pin_comboBox";
            this.pin_comboBox.Size = new System.Drawing.Size(76, 20);
            this.pin_comboBox.TabIndex = 24;
            this.pin_comboBox.Text = "Visual";
            // 
            // pin_checkBox
            // 
            this.pin_checkBox.AutoSize = true;
            this.pin_checkBox.Enabled = false;
            this.pin_checkBox.Location = new System.Drawing.Point(27, 241);
            this.pin_checkBox.Name = "pin_checkBox";
            this.pin_checkBox.Size = new System.Drawing.Size(330, 16);
            this.pin_checkBox.TabIndex = 22;
            this.pin_checkBox.Text = "No pin hole,damage and bump in sealing of packaging";
            this.pin_checkBox.UseVisualStyleBackColor = true;
            // 
            // foreign_comboBox
            // 
            this.foreign_comboBox.Enabled = false;
            this.foreign_comboBox.FormattingEnabled = true;
            this.foreign_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.foreign_comboBox.Location = new System.Drawing.Point(727, 394);
            this.foreign_comboBox.Name = "foreign_comboBox";
            this.foreign_comboBox.Size = new System.Drawing.Size(76, 20);
            this.foreign_comboBox.TabIndex = 20;
            this.foreign_comboBox.Text = "Visual";
            // 
            // seal_comboBox
            // 
            this.seal_comboBox.Enabled = false;
            this.seal_comboBox.FormattingEnabled = true;
            this.seal_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.seal_comboBox.Location = new System.Drawing.Point(727, 343);
            this.seal_comboBox.Name = "seal_comboBox";
            this.seal_comboBox.Size = new System.Drawing.Size(76, 20);
            this.seal_comboBox.TabIndex = 20;
            this.seal_comboBox.Text = "Manual";
            // 
            // peel_comboBox
            // 
            this.peel_comboBox.Enabled = false;
            this.peel_comboBox.FormattingEnabled = true;
            this.peel_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.peel_comboBox.Location = new System.Drawing.Point(727, 292);
            this.peel_comboBox.Name = "peel_comboBox";
            this.peel_comboBox.Size = new System.Drawing.Size(76, 20);
            this.peel_comboBox.TabIndex = 20;
            this.peel_comboBox.Text = "Visual";
            // 
            // packing_comboBox
            // 
            this.packing_comboBox.Enabled = false;
            this.packing_comboBox.FormattingEnabled = true;
            this.packing_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.packing_comboBox.Location = new System.Drawing.Point(727, 190);
            this.packing_comboBox.Name = "packing_comboBox";
            this.packing_comboBox.Size = new System.Drawing.Size(76, 20);
            this.packing_comboBox.TabIndex = 20;
            this.packing_comboBox.Text = "Visual";
            // 
            // surface_comboBox
            // 
            this.surface_comboBox.Enabled = false;
            this.surface_comboBox.FormattingEnabled = true;
            this.surface_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.surface_comboBox.Location = new System.Drawing.Point(727, 139);
            this.surface_comboBox.Name = "surface_comboBox";
            this.surface_comboBox.Size = new System.Drawing.Size(76, 20);
            this.surface_comboBox.TabIndex = 20;
            this.surface_comboBox.Text = "Visual";
            // 
            // ship_comboBox
            // 
            this.ship_comboBox.Enabled = false;
            this.ship_comboBox.FormattingEnabled = true;
            this.ship_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.ship_comboBox.Location = new System.Drawing.Point(727, 88);
            this.ship_comboBox.Name = "ship_comboBox";
            this.ship_comboBox.Size = new System.Drawing.Size(76, 20);
            this.ship_comboBox.TabIndex = 20;
            this.ship_comboBox.Text = "Visual";
            // 
            // fosb_comboBox
            // 
            this.fosb_comboBox.Enabled = false;
            this.fosb_comboBox.FormattingEnabled = true;
            this.fosb_comboBox.Items.AddRange(new object[] {
            "Visual",
            "Manual"});
            this.fosb_comboBox.Location = new System.Drawing.Point(727, 37);
            this.fosb_comboBox.Name = "fosb_comboBox";
            this.fosb_comboBox.Size = new System.Drawing.Size(76, 20);
            this.fosb_comboBox.TabIndex = 19;
            this.fosb_comboBox.Text = "Visual";
            // 
            // foreign_checkBox
            // 
            this.foreign_checkBox.AutoSize = true;
            this.foreign_checkBox.Enabled = false;
            this.foreign_checkBox.Location = new System.Drawing.Point(27, 394);
            this.foreign_checkBox.Name = "foreign_checkBox";
            this.foreign_checkBox.Size = new System.Drawing.Size(360, 16);
            this.foreign_checkBox.TabIndex = 17;
            this.foreign_checkBox.Text = "No foreign material residues in the sealing of packaging";
            this.foreign_checkBox.UseVisualStyleBackColor = true;
            // 
            // seal_checkBox
            // 
            this.seal_checkBox.AutoSize = true;
            this.seal_checkBox.Enabled = false;
            this.seal_checkBox.Location = new System.Drawing.Point(27, 343);
            this.seal_checkBox.Name = "seal_checkBox";
            this.seal_checkBox.Size = new System.Drawing.Size(486, 16);
            this.seal_checkBox.TabIndex = 15;
            this.seal_checkBox.Text = "No fuse infirm in sealing interface (pull the fuse sealing to flat by manual)";
            this.seal_checkBox.UseVisualStyleBackColor = true;
            // 
            // peel_checkBox
            // 
            this.peel_checkBox.AutoSize = true;
            this.peel_checkBox.Enabled = false;
            this.peel_checkBox.Location = new System.Drawing.Point(27, 292);
            this.peel_checkBox.Name = "peel_checkBox";
            this.peel_checkBox.Size = new System.Drawing.Size(384, 16);
            this.peel_checkBox.TabIndex = 13;
            this.peel_checkBox.Text = "No peel off phenomenon in material interface after packaging";
            this.peel_checkBox.UseVisualStyleBackColor = true;
            // 
            // packing_checkBox
            // 
            this.packing_checkBox.AutoSize = true;
            this.packing_checkBox.Enabled = false;
            this.packing_checkBox.Location = new System.Drawing.Point(27, 190);
            this.packing_checkBox.Name = "packing_checkBox";
            this.packing_checkBox.Size = new System.Drawing.Size(318, 16);
            this.packing_checkBox.TabIndex = 11;
            this.packing_checkBox.Text = "Smooth,flat and no bubble in sealing of packaging";
            this.packing_checkBox.UseVisualStyleBackColor = true;
            // 
            // surface_checkBox
            // 
            this.surface_checkBox.AutoSize = true;
            this.surface_checkBox.Enabled = false;
            this.surface_checkBox.Location = new System.Drawing.Point(27, 139);
            this.surface_checkBox.Name = "surface_checkBox";
            this.surface_checkBox.Size = new System.Drawing.Size(438, 16);
            this.surface_checkBox.TabIndex = 9;
            this.surface_checkBox.Text = "Clear handwriting,no dirt and damage on the surface of shipping label";
            this.surface_checkBox.UseVisualStyleBackColor = true;
            // 
            // ship_checkBox
            // 
            this.ship_checkBox.AutoSize = true;
            this.ship_checkBox.Enabled = false;
            this.ship_checkBox.Location = new System.Drawing.Point(27, 88);
            this.ship_checkBox.Name = "ship_checkBox";
            this.ship_checkBox.Size = new System.Drawing.Size(384, 16);
            this.ship_checkBox.TabIndex = 7;
            this.ship_checkBox.Text = "Shipping label correctly sticked on FOSB and anti-static bag";
            this.ship_checkBox.UseVisualStyleBackColor = true;
            // 
            // fosb_checkBox
            // 
            this.fosb_checkBox.AutoSize = true;
            this.fosb_checkBox.Enabled = false;
            this.fosb_checkBox.Location = new System.Drawing.Point(27, 37);
            this.fosb_checkBox.Name = "fosb_checkBox";
            this.fosb_checkBox.Size = new System.Drawing.Size(234, 16);
            this.fosb_checkBox.TabIndex = 5;
            this.fosb_checkBox.Text = "No chipping,crack and cross in FOSB";
            this.fosb_checkBox.UseVisualStyleBackColor = true;
            // 
            // FrmLotPackageCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 693);
            this.Controls.Add(this.package_groupBox);
            this.Controls.Add(this.lotInfo_groupBox);
            this.Name = "FrmLotPackageCheck";
            this.Text = "FrmLotPackageCheck";
            this.Controls.SetChildIndex(this.lotInfo_groupBox, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.package_groupBox, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.lotInfo_groupBox.ResumeLayout(false);
            this.lotInfo_groupBox.PerformLayout();
            this.package_groupBox.ResumeLayout(false);
            this.package_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lotId_textBox;
        private System.Windows.Forms.Label lotId_label;
        private System.Windows.Forms.GroupBox lotInfo_groupBox;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.GroupBox package_groupBox;
        private System.Windows.Forms.CheckBox fosb_checkBox;
        private System.Windows.Forms.CheckBox foreign_checkBox;
        private System.Windows.Forms.CheckBox seal_checkBox;
        private System.Windows.Forms.CheckBox peel_checkBox;
        private System.Windows.Forms.CheckBox packing_checkBox;
        private System.Windows.Forms.CheckBox surface_checkBox;
        private System.Windows.Forms.CheckBox ship_checkBox;
        private System.Windows.Forms.ComboBox surface_comboBox;
        private System.Windows.Forms.ComboBox ship_comboBox;
        private System.Windows.Forms.ComboBox fosb_comboBox;
        private System.Windows.Forms.ComboBox packing_comboBox;
        private System.Windows.Forms.ComboBox peel_comboBox;
        private System.Windows.Forms.ComboBox foreign_comboBox;
        private System.Windows.Forms.ComboBox seal_comboBox;
        private System.Windows.Forms.ComboBox pin_comboBox;
        private System.Windows.Forms.CheckBox pin_checkBox;
    }
}