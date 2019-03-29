namespace OQAMain
{
    partial class FrmDefectSend
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAbnInf = new System.Windows.Forms.GroupBox();
            this.txtHoldCmt = new System.Windows.Forms.TextBox();
            this.txtHoldCode = new System.Windows.Forms.TextBox();
            this.txtStepName = new System.Windows.Forms.TextBox();
            this.txtStepId = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.labHoldCmt = new System.Windows.Forms.Label();
            this.labHoldCode = new System.Windows.Forms.Label();
            this.labStepName = new System.Windows.Forms.Label();
            this.labStepId = new System.Windows.Forms.Label();
            this.labQty = new System.Windows.Forms.Label();
            this.labPartId = new System.Windows.Forms.Label();
            this.labLotid = new System.Windows.Forms.Label();
            this.grpPndnInf = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labOperatorNo = new System.Windows.Forms.Label();
            this.txtOperatorNo = new System.Windows.Forms.TextBox();
            this.txtSupervisorNo = new System.Windows.Forms.TextBox();
            this.labSupervisorNo = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.grpAbnInf.SuspendLayout();
            this.grpPndnInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 8);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(640, 8);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(640, 8);
            this.btnEdite.Visible = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.txtSupervisorNo);
            this.pnlMenu.Controls.Add(this.labSupervisorNo);
            this.pnlMenu.Controls.Add(this.txtOperatorNo);
            this.pnlMenu.Controls.Add(this.labOperatorNo);
            this.pnlMenu.Location = new System.Drawing.Point(0, 676);
            this.pnlMenu.Size = new System.Drawing.Size(875, 49);
            this.pnlMenu.Controls.SetChildIndex(this.labOperatorNo, 0);
            this.pnlMenu.Controls.SetChildIndex(this.txtOperatorNo, 0);
            this.pnlMenu.Controls.SetChildIndex(this.labSupervisorNo, 0);
            this.pnlMenu.Controls.SetChildIndex(this.txtSupervisorNo, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnRefresh, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnEdite, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnCreate, 0);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSucessMsg
            // 
            this.lblSucessMsg.Location = new System.Drawing.Point(124, 36);
            // 
            // grpAbnInf
            // 
            this.grpAbnInf.Controls.Add(this.txtHoldCmt);
            this.grpAbnInf.Controls.Add(this.txtHoldCode);
            this.grpAbnInf.Controls.Add(this.txtStepName);
            this.grpAbnInf.Controls.Add(this.txtStepId);
            this.grpAbnInf.Controls.Add(this.txtQty);
            this.grpAbnInf.Controls.Add(this.txtPartId);
            this.grpAbnInf.Controls.Add(this.txtLotId);
            this.grpAbnInf.Controls.Add(this.labHoldCmt);
            this.grpAbnInf.Controls.Add(this.labHoldCode);
            this.grpAbnInf.Controls.Add(this.labStepName);
            this.grpAbnInf.Controls.Add(this.labStepId);
            this.grpAbnInf.Controls.Add(this.labQty);
            this.grpAbnInf.Controls.Add(this.labPartId);
            this.grpAbnInf.Controls.Add(this.labLotid);
            this.grpAbnInf.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAbnInf.Location = new System.Drawing.Point(0, 0);
            this.grpAbnInf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAbnInf.Name = "grpAbnInf";
            this.grpAbnInf.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAbnInf.Size = new System.Drawing.Size(875, 80);
            this.grpAbnInf.TabIndex = 1;
            this.grpAbnInf.TabStop = false;
            this.grpAbnInf.Text = "Defect Lot Information";
            // 
            // txtHoldCmt
            // 
            this.txtHoldCmt.Location = new System.Drawing.Point(735, 47);
            this.txtHoldCmt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoldCmt.Name = "txtHoldCmt";
            this.txtHoldCmt.Size = new System.Drawing.Size(116, 23);
            this.txtHoldCmt.TabIndex = 13;
            // 
            // txtHoldCode
            // 
            this.txtHoldCode.Location = new System.Drawing.Point(512, 48);
            this.txtHoldCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoldCode.Name = "txtHoldCode";
            this.txtHoldCode.Size = new System.Drawing.Size(116, 23);
            this.txtHoldCode.TabIndex = 12;
            // 
            // txtStepName
            // 
            this.txtStepName.Location = new System.Drawing.Point(293, 48);
            this.txtStepName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.ReadOnly = true;
            this.txtStepName.Size = new System.Drawing.Size(116, 23);
            this.txtStepName.TabIndex = 11;
            // 
            // txtStepId
            // 
            this.txtStepId.Location = new System.Drawing.Point(78, 48);
            this.txtStepId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStepId.Name = "txtStepId";
            this.txtStepId.ReadOnly = true;
            this.txtStepId.Size = new System.Drawing.Size(116, 23);
            this.txtStepId.TabIndex = 10;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(512, 21);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(116, 23);
            this.txtQty.TabIndex = 9;
            // 
            // txtPartId
            // 
            this.txtPartId.Location = new System.Drawing.Point(293, 21);
            this.txtPartId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.ReadOnly = true;
            this.txtPartId.Size = new System.Drawing.Size(116, 23);
            this.txtPartId.TabIndex = 8;
            // 
            // txtLotId
            // 
            this.txtLotId.Location = new System.Drawing.Point(78, 21);
            this.txtLotId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(116, 23);
            this.txtLotId.TabIndex = 7;
            this.txtLotId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtLotId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLotId_MouseDown);
            // 
            // labHoldCmt
            // 
            this.labHoldCmt.AutoSize = true;
            this.labHoldCmt.Location = new System.Drawing.Point(665, 52);
            this.labHoldCmt.Name = "labHoldCmt";
            this.labHoldCmt.Size = new System.Drawing.Size(62, 15);
            this.labHoldCmt.TabIndex = 6;
            this.labHoldCmt.Text = "Hold Cmt:";
            // 
            // labHoldCode
            // 
            this.labHoldCode.AutoSize = true;
            this.labHoldCode.Location = new System.Drawing.Point(441, 52);
            this.labHoldCode.Name = "labHoldCode";
            this.labHoldCode.Size = new System.Drawing.Size(67, 15);
            this.labHoldCode.TabIndex = 5;
            this.labHoldCode.Text = "Hold Code:";
            // 
            // labStepName
            // 
            this.labStepName.AutoSize = true;
            this.labStepName.Location = new System.Drawing.Point(218, 55);
            this.labStepName.Name = "labStepName";
            this.labStepName.Size = new System.Drawing.Size(68, 15);
            this.labStepName.TabIndex = 4;
            this.labStepName.Text = "Step Name:";
            // 
            // labStepId
            // 
            this.labStepId.AutoSize = true;
            this.labStepId.Location = new System.Drawing.Point(17, 55);
            this.labStepId.Name = "labStepId";
            this.labStepId.Size = new System.Drawing.Size(47, 15);
            this.labStepId.TabIndex = 3;
            this.labStepId.Text = "Step ID:";
            // 
            // labQty
            // 
            this.labQty.AutoSize = true;
            this.labQty.Location = new System.Drawing.Point(444, 26);
            this.labQty.Name = "labQty";
            this.labQty.Size = new System.Drawing.Size(29, 15);
            this.labQty.TabIndex = 2;
            this.labQty.Text = "Qty:";
            // 
            // labPartId
            // 
            this.labPartId.AutoSize = true;
            this.labPartId.Location = new System.Drawing.Point(222, 26);
            this.labPartId.Name = "labPartId";
            this.labPartId.Size = new System.Drawing.Size(45, 15);
            this.labPartId.TabIndex = 1;
            this.labPartId.Text = "Part ID:";
            // 
            // labLotid
            // 
            this.labLotid.AutoSize = true;
            this.labLotid.Location = new System.Drawing.Point(21, 26);
            this.labLotid.Name = "labLotid";
            this.labLotid.Size = new System.Drawing.Size(41, 15);
            this.labLotid.TabIndex = 0;
            this.labLotid.Text = "Lot ID:";
            // 
            // grpPndnInf
            // 
            this.grpPndnInf.Controls.Add(this.dataGridView1);
            this.grpPndnInf.Controls.Add(this.lblSucessMsg);
            this.grpPndnInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPndnInf.Location = new System.Drawing.Point(0, 80);
            this.grpPndnInf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPndnInf.Name = "grpPndnInf";
            this.grpPndnInf.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPndnInf.Size = new System.Drawing.Size(875, 596);
            this.grpPndnInf.TabIndex = 2;
            this.grpPndnInf.TabStop = false;
            this.grpPndnInf.Text = "PNDN Plan Information";
            this.grpPndnInf.Controls.SetChildIndex(this.lblSucessMsg, 0);
            this.grpPndnInf.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(869, 572);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PNDN Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dept";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inspect Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Defect Code";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Slot ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Spec";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // labOperatorNo
            // 
            this.labOperatorNo.AutoSize = true;
            this.labOperatorNo.Location = new System.Drawing.Point(66, 15);
            this.labOperatorNo.Name = "labOperatorNo";
            this.labOperatorNo.Size = new System.Drawing.Size(76, 15);
            this.labOperatorNo.TabIndex = 1;
            this.labOperatorNo.Text = "Operator No:";
            // 
            // txtOperatorNo
            // 
            this.txtOperatorNo.Location = new System.Drawing.Point(162, 10);
            this.txtOperatorNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOperatorNo.Name = "txtOperatorNo";
            this.txtOperatorNo.ReadOnly = true;
            this.txtOperatorNo.Size = new System.Drawing.Size(116, 23);
            this.txtOperatorNo.TabIndex = 7;
            // 
            // txtSupervisorNo
            // 
            this.txtSupervisorNo.Location = new System.Drawing.Point(409, 10);
            this.txtSupervisorNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupervisorNo.Name = "txtSupervisorNo";
            this.txtSupervisorNo.Size = new System.Drawing.Size(116, 23);
            this.txtSupervisorNo.TabIndex = 10;
            this.txtSupervisorNo.Visible = false;
            // 
            // labSupervisorNo
            // 
            this.labSupervisorNo.AutoSize = true;
            this.labSupervisorNo.Location = new System.Drawing.Point(306, 15);
            this.labSupervisorNo.Name = "labSupervisorNo";
            this.labSupervisorNo.Size = new System.Drawing.Size(84, 15);
            this.labSupervisorNo.TabIndex = 9;
            this.labSupervisorNo.Text = "Supervisor No:";
            this.labSupervisorNo.Visible = false;
            // 
            // FrmDefectSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 725);
            this.Controls.Add(this.grpPndnInf);
            this.Controls.Add(this.grpAbnInf);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(875, 725);
            this.Name = "FrmDefectSend";
            this.Text = "Send PNDN";
            this.Load += new System.EventHandler(this.FrmDefectSend_Load);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.grpAbnInf, 0);
            this.Controls.SetChildIndex(this.grpPndnInf, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.grpAbnInf.ResumeLayout(false);
            this.grpAbnInf.PerformLayout();
            this.grpPndnInf.ResumeLayout(false);
            this.grpPndnInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAbnInf;
        private System.Windows.Forms.TextBox txtHoldCmt;
        private System.Windows.Forms.TextBox txtHoldCode;
        private System.Windows.Forms.TextBox txtStepName;
        private System.Windows.Forms.TextBox txtStepId;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.Label labHoldCmt;
        private System.Windows.Forms.Label labHoldCode;
        private System.Windows.Forms.Label labStepName;
        private System.Windows.Forms.Label labStepId;
        private System.Windows.Forms.Label labQty;
        private System.Windows.Forms.Label labPartId;
        private System.Windows.Forms.Label labLotid;
        private System.Windows.Forms.TextBox txtSupervisorNo;
        private System.Windows.Forms.Label labSupervisorNo;
        private System.Windows.Forms.TextBox txtOperatorNo;
        private System.Windows.Forms.Label labOperatorNo;
        private System.Windows.Forms.GroupBox grpPndnInf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}