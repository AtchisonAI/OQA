﻿namespace OQAMain
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(818, 11);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(359, 7);
            this.btnCreate.Visible = false;
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(1518, 10);
            this.btnEdite.Text = "Export";
            this.btnEdite.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 540);
            this.pnlMenu.Size = new System.Drawing.Size(750, 40);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 13);
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 540);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Ship ID";
            // 
            // chkToUse
            // 
            this.chkToUse.AutoSize = true;
            this.chkToUse.Checked = true;
            this.chkToUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkToUse.Location = new System.Drawing.Point(216, 128);
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
            this.chkFromUse.Location = new System.Drawing.Point(216, 105);
            this.chkFromUse.Name = "chkFromUse";
            this.chkFromUse.Size = new System.Drawing.Size(15, 14);
            this.chkFromUse.TabIndex = 1;
            this.chkFromUse.UseVisualStyleBackColor = true;
            this.chkFromUse.CheckedChanged += new System.EventHandler(this.chkFromUse_CheckedChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(135, 151);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "To Time";
            // 
            // dtFromTime
            // 
            this.dtFromTime.Location = new System.Drawing.Point(90, 100);
            this.dtFromTime.Name = "dtFromTime";
            this.dtFromTime.Size = new System.Drawing.Size(120, 21);
            this.dtFromTime.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "From Time";
            // 
            // dtToTime
            // 
            this.dtToTime.Location = new System.Drawing.Point(90, 124);
            this.dtToTime.Name = "dtToTime";
            this.dtToTime.Size = new System.Drawing.Size(120, 21);
            this.dtToTime.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lot ID";
            // 
            // txtLotFilter
            // 
            this.txtLotFilter.Location = new System.Drawing.Point(68, 53);
            this.txtLotFilter.Name = "txtLotFilter";
            this.txtLotFilter.Size = new System.Drawing.Size(158, 21);
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
            this.CheckShipID.Location = new System.Drawing.Point(14, 197);
            this.CheckShipID.Name = "CheckShipID";
            this.CheckShipID.Size = new System.Drawing.Size(210, 340);
            this.CheckShipID.TabIndex = 4;
            this.CheckShipID.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckShipID_ItemCheck);
            // 
            // txtShipFilter
            // 
            this.txtShipFilter.Location = new System.Drawing.Point(68, 29);
            this.txtShipFilter.Name = "txtShipFilter";
            this.txtShipFilter.Size = new System.Drawing.Size(158, 21);
            this.txtShipFilter.TabIndex = 3;
            this.txtShipFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Press_check);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ship ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lisship);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(243, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 170);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发货批次信息";
            // 
            // lisship
            // 
            this.lisship.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lot_ID,
            this.Qty,
            this.Part_ID,
            this.Inspection_Result});
            this.lisship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lisship.Location = new System.Drawing.Point(3, 17);
            this.lisship.Name = "lisship";
            this.lisship.Size = new System.Drawing.Size(501, 150);
            this.lisship.TabIndex = 0;
            this.lisship.UseCompatibleStateImageBehavior = false;
            this.lisship.View = System.Windows.Forms.View.Details;
            // 
            // Lot_ID
            // 
            this.Lot_ID.Text = "Lot_ID";
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
            this.Part_ID.Text = "Part_ID";
            this.Part_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Part_ID.Width = 125;
            // 
            // Inspection_Result
            // 
            this.Inspection_Result.Text = "Inspection_Result";
            this.Inspection_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Inspection_Result.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(243, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 370);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "交接单打印预览";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "OQAMain.Print.FrmOQAShipListPrint.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 17);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(501, 350);
            this.reportViewer2.TabIndex = 5;
            // 
            // FrmOQAShipListPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOQAShipListPrint";
            this.Text = "FrmOQAShipListPrint";
            this.Load += new System.EventHandler(this.FrmOQAShipListPrint_Load);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}