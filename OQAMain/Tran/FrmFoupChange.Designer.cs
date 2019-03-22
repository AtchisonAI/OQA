namespace OQAMain
{
    partial class FrmFoupChange
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
            this.grpLotInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtLotid = new System.Windows.Forms.TextBox();
            this.labLotid = new System.Windows.Forms.Label();
            this.grpFoupChange = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.grpLotInfo.SuspendLayout();
            this.grpFoupChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 8);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(519, 7);
            this.btnCreate.Text = "Submit";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(150, 6);
            this.btnEdite.Visible = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnPrint);
            this.pnlMenu.Location = new System.Drawing.Point(0, 540);
            this.pnlMenu.Size = new System.Drawing.Size(750, 40);
            this.pnlMenu.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnEdite, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnCreate, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnRefresh, 0);
            this.pnlMenu.Controls.SetChildIndex(this.lblSucessMsg, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnPrint, 0);
            // 
            // lblSucessMsg
            // 
            this.lblSucessMsg.Location = new System.Drawing.Point(53, 12);
            // 
            // grpLotInfo
            // 
            this.grpLotInfo.Controls.Add(this.label1);
            this.grpLotInfo.Controls.Add(this.btnCheck);
            this.grpLotInfo.Controls.Add(this.txtLotid);
            this.grpLotInfo.Controls.Add(this.labLotid);
            this.grpLotInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLotInfo.Location = new System.Drawing.Point(0, 0);
            this.grpLotInfo.Name = "grpLotInfo";
            this.grpLotInfo.Size = new System.Drawing.Size(750, 50);
            this.grpLotInfo.TabIndex = 1;
            this.grpLotInfo.TabStop = false;
            this.grpLotInfo.Text = "Lot Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(179, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "*";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(200, 13);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtLotid
            // 
            this.txtLotid.Location = new System.Drawing.Point(74, 14);
            this.txtLotid.MaxLength = 20;
            this.txtLotid.Name = "txtLotid";
            this.txtLotid.Size = new System.Drawing.Size(100, 21);
            this.txtLotid.TabIndex = 1;
            this.txtLotid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // labLotid
            // 
            this.labLotid.AutoSize = true;
            this.labLotid.Location = new System.Drawing.Point(26, 20);
            this.labLotid.Name = "labLotid";
            this.labLotid.Size = new System.Drawing.Size(35, 12);
            this.labLotid.TabIndex = 0;
            this.labLotid.Text = "Lotid";
            // 
            // grpFoupChange
            // 
            this.grpFoupChange.Controls.Add(this.dataGridView1);
            this.grpFoupChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFoupChange.Location = new System.Drawing.Point(0, 50);
            this.grpFoupChange.Name = "grpFoupChange";
            this.grpFoupChange.Size = new System.Drawing.Size(750, 490);
            this.grpFoupChange.TabIndex = 2;
            this.grpFoupChange.TabStop = false;
            this.grpFoupChange.Text = "Foup Change";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(744, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "01";
            this.Column1.Name = "Column1";
            this.Column1.Width = 42;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "02";
            this.Column2.Name = "Column2";
            this.Column2.Width = 42;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "03";
            this.Column3.Name = "Column3";
            this.Column3.Width = 42;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "04";
            this.Column4.Name = "Column4";
            this.Column4.Width = 42;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "05";
            this.Column5.Name = "Column5";
            this.Column5.Width = 42;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "06";
            this.Column6.Name = "Column6";
            this.Column6.Width = 42;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "07";
            this.Column7.Name = "Column7";
            this.Column7.Width = 42;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "08";
            this.Column8.Name = "Column8";
            this.Column8.Width = 42;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "09";
            this.Column9.Name = "Column9";
            this.Column9.Width = 42;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "10";
            this.Column10.Name = "Column10";
            this.Column10.Width = 42;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "11";
            this.Column11.Name = "Column11";
            this.Column11.Width = 42;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "12";
            this.Column12.Name = "Column12";
            this.Column12.Width = 42;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "13";
            this.Column13.Name = "Column13";
            this.Column13.Width = 42;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "14";
            this.Column14.Name = "Column14";
            this.Column14.Width = 42;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "15";
            this.Column15.Name = "Column15";
            this.Column15.Width = 42;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "16";
            this.Column16.Name = "Column16";
            this.Column16.Width = 42;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "17";
            this.Column17.Name = "Column17";
            this.Column17.Width = 42;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "18";
            this.Column18.Name = "Column18";
            this.Column18.Width = 42;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "19";
            this.Column19.Name = "Column19";
            this.Column19.Width = 42;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "20";
            this.Column20.Name = "Column20";
            this.Column20.Width = 42;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "21";
            this.Column21.Name = "Column21";
            this.Column21.Width = 42;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "22";
            this.Column22.Name = "Column22";
            this.Column22.Width = 42;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "23";
            this.Column23.Name = "Column23";
            this.Column23.Width = 42;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "24";
            this.Column24.Name = "Column24";
            this.Column24.Width = 42;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "25";
            this.Column25.Name = "Column25";
            this.Column25.Width = 42;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(244, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 26);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmFoupChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.grpFoupChange);
            this.Controls.Add(this.grpLotInfo);
            this.Name = "FrmFoupChange";
            this.Text = "Foup Chang";
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.grpLotInfo, 0);
            this.Controls.SetChildIndex(this.grpFoupChange, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.grpLotInfo.ResumeLayout(false);
            this.grpLotInfo.PerformLayout();
            this.grpFoupChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLotInfo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtLotid;
        private System.Windows.Forms.Label labLotid;
        private System.Windows.Forms.GroupBox grpFoupChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
    }
}