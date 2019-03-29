namespace OQAMain
{
    partial class FrmOQAShipListPrint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkToUse = new System.Windows.Forms.CheckBox();
            this.chkFromUse = new System.Windows.Forms.CheckBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFromTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtToTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLotFilter = new System.Windows.Forms.TextBox();
            this.CheckShipID = new System.Windows.Forms.CheckedListBox();
            this.txtShipFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lisship = new System.Windows.Forms.ListView();
            this.Lot_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Part_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inspection_Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtShowShipID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(761, 5);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(419, 9);
            this.btnCreate.Visible = false;
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(320, 9);
            this.btnEdite.Text = "Export";
            this.btnEdite.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 676);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkToUse);
            this.groupBox1.Controls.Add(this.chkFromUse);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFromTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtToTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLotFilter);
            this.groupBox1.Controls.Add(this.CheckShipID);
            this.groupBox1.Controls.Add(this.txtShipFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(283, 676);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Ship ID";
            // 
            // chkToUse
            // 
            this.chkToUse.AutoSize = true;
            this.chkToUse.Checked = true;
            this.chkToUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkToUse.Location = new System.Drawing.Point(237, 107);
            this.chkToUse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkToUse.Name = "chkToUse";
            this.chkToUse.Size = new System.Drawing.Size(15, 14);
            this.chkToUse.TabIndex = 14;
            this.chkToUse.UseVisualStyleBackColor = true;
            this.chkToUse.CheckedChanged += new System.EventHandler(this.chkToUse_CheckedChanged);
            // 
            // chkFromUse
            // 
            this.chkFromUse.AutoSize = true;
            this.chkFromUse.Checked = true;
            this.chkFromUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFromUse.Location = new System.Drawing.Point(237, 82);
            this.chkFromUse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFromUse.Name = "chkFromUse";
            this.chkFromUse.Size = new System.Drawing.Size(15, 14);
            this.chkFromUse.TabIndex = 1;
            this.chkFromUse.UseVisualStyleBackColor = true;
            this.chkFromUse.CheckedChanged += new System.EventHandler(this.chkFromUse_CheckedChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(217, 22);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(42, 25);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "View";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "To Time";
            // 
            // dtFromTime
            // 
            this.dtFromTime.Location = new System.Drawing.Point(90, 76);
            this.dtFromTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFromTime.Name = "dtFromTime";
            this.dtFromTime.Size = new System.Drawing.Size(139, 23);
            this.dtFromTime.TabIndex = 11;
            this.dtFromTime.ValueChanged += new System.EventHandler(this.dtFromTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "From Time";
            // 
            // dtToTime
            // 
            this.dtToTime.Location = new System.Drawing.Point(90, 102);
            this.dtToTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtToTime.Name = "dtToTime";
            this.dtToTime.Size = new System.Drawing.Size(139, 23);
            this.dtToTime.TabIndex = 7;
            this.dtToTime.ValueChanged += new System.EventHandler(this.dtToTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lot ID";
            // 
            // txtLotFilter
            // 
            this.txtLotFilter.Location = new System.Drawing.Point(91, 49);
            this.txtLotFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLotFilter.Name = "txtLotFilter";
            this.txtLotFilter.Size = new System.Drawing.Size(120, 23);
            this.txtLotFilter.TabIndex = 5;
            this.txtLotFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLotFilter_KeyPress);
            // 
            // CheckShipID
            // 
            this.CheckShipID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckShipID.CheckOnClick = true;
            this.CheckShipID.FormattingEnabled = true;
            this.CheckShipID.Location = new System.Drawing.Point(16, 144);
            this.CheckShipID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckShipID.Name = "CheckShipID";
            this.CheckShipID.Size = new System.Drawing.Size(244, 526);
            this.CheckShipID.TabIndex = 4;
            this.CheckShipID.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckShipID_ItemCheck);
            // 
            // txtShipFilter
            // 
            this.txtShipFilter.Location = new System.Drawing.Point(91, 22);
            this.txtShipFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShipFilter.Name = "txtShipFilter";
            this.txtShipFilter.Size = new System.Drawing.Size(120, 23);
            this.txtShipFilter.TabIndex = 3;
            this.txtShipFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Press_check);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ship ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lisship);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(283, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(592, 241);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Ship Information";
            // 
            // lisship
            // 
            this.lisship.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lot_ID,
            this.Qty,
            this.Part_ID,
            this.Inspection_Result});
            this.lisship.Dock = System.Windows.Forms.DockStyle.Top;
            this.lisship.Location = new System.Drawing.Point(3, 55);
            this.lisship.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lisship.Name = "lisship";
            this.lisship.Size = new System.Drawing.Size(586, 186);
            this.lisship.TabIndex = 0;
            this.lisship.UseCompatibleStateImageBehavior = false;
            this.lisship.View = System.Windows.Forms.View.Details;
            // 
            // Lot_ID
            // 
            this.Lot_ID.Text = "Lot ID";
            this.Lot_ID.Width = 125;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty.Width = 125;
            // 
            // Part_ID
            // 
            this.Part_ID.Text = "Part ID";
            this.Part_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Part_ID.Width = 125;
            // 
            // Inspection_Result
            // 
            this.Inspection_Result.Text = "Inspection Result";
            this.Inspection_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Inspection_Result.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtShowShipID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 35);
            this.panel1.TabIndex = 2;
            // 
            // txtShowShipID
            // 
            this.txtShowShipID.Enabled = false;
            this.txtShowShipID.Location = new System.Drawing.Point(122, 4);
            this.txtShowShipID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShowShipID.Name = "txtShowShipID";
            this.txtShowShipID.Size = new System.Drawing.Size(120, 23);
            this.txtShowShipID.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(283, 241);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(592, 435);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Print";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "OQAMain.Print.FrmOQAShipListPrint.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 20);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(586, 411);
            this.reportViewer2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Selected Ship ID";
            // 
            // FrmOQAShipListPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 725);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FrmOQAShipListPrint";
            this.Text = "Ship  Print";
            this.Load += new System.EventHandler(this.FrmOQAShipListPrint_Load);
            this.Shown += new System.EventHandler(this.FrmOQAShipListPrint_Shown);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.ListView lisship;
        private System.Windows.Forms.TextBox txtShipFilter;
        private System.Windows.Forms.ColumnHeader Lot_ID;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Part_ID;
        private System.Windows.Forms.ColumnHeader Inspection_Result;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckedListBox CheckShipID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLotFilter;
        private System.Windows.Forms.DateTimePicker dtToTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFromTime;
        private System.Windows.Forms.CheckBox chkToUse;
        private System.Windows.Forms.CheckBox chkFromUse;
        private System.Windows.Forms.TextBox txtShowShipID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}