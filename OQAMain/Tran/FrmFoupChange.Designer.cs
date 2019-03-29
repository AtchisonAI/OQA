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
            this.btnClose.Location = new System.Drawing.Point(750, 6);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(647, 6);
            this.btnCreate.Text = "Submit";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(480, 9);
            this.btnEdite.Visible = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnPrint);
            this.pnlMenu.Location = new System.Drawing.Point(0, 676);
            this.pnlMenu.Size = new System.Drawing.Size(875, 49);
            this.pnlMenu.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnEdite, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnCreate, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnRefresh, 0);
            this.pnlMenu.Controls.SetChildIndex(this.lblSucessMsg, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnPrint, 0);
            // 
            // lblSucessMsg
            // 
            this.lblSucessMsg.Location = new System.Drawing.Point(62, 15);
            // 
            // grpLotInfo
            // 
            this.grpLotInfo.Controls.Add(this.btnCheck);
            this.grpLotInfo.Controls.Add(this.txtLotid);
            this.grpLotInfo.Controls.Add(this.labLotid);
            this.grpLotInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLotInfo.Location = new System.Drawing.Point(0, 0);
            this.grpLotInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLotInfo.Name = "grpLotInfo";
            this.grpLotInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLotInfo.Size = new System.Drawing.Size(875, 62);
            this.grpLotInfo.TabIndex = 1;
            this.grpLotInfo.TabStop = false;
            this.grpLotInfo.Text = "Lot Information";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(233, 17);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(87, 29);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtLotid
            // 
            this.txtLotid.Location = new System.Drawing.Point(86, 21);
            this.txtLotid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLotid.MaxLength = 20;
            this.txtLotid.Name = "txtLotid";
            this.txtLotid.Size = new System.Drawing.Size(116, 23);
            this.txtLotid.TabIndex = 1;
            this.txtLotid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtLotid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLotid_MouseDown);
            // 
            // labLotid
            // 
            this.labLotid.AutoSize = true;
            this.labLotid.Location = new System.Drawing.Point(12, 24);
            this.labLotid.Name = "labLotid";
            this.labLotid.Size = new System.Drawing.Size(38, 15);
            this.labLotid.TabIndex = 0;
            this.labLotid.Text = "Lot ID";
            // 
            // grpFoupChange
            // 
            this.grpFoupChange.Controls.Add(this.dataGridView1);
            this.grpFoupChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFoupChange.Location = new System.Drawing.Point(0, 62);
            this.grpFoupChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoupChange.Name = "grpFoupChange";
            this.grpFoupChange.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFoupChange.Size = new System.Drawing.Size(875, 614);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(869, 590);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "01";
            this.Column1.Name = "Column1";
            this.Column1.Width = 44;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "02";
            this.Column2.Name = "Column2";
            this.Column2.Width = 44;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "03";
            this.Column3.Name = "Column3";
            this.Column3.Width = 44;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "04";
            this.Column4.Name = "Column4";
            this.Column4.Width = 44;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "05";
            this.Column5.Name = "Column5";
            this.Column5.Width = 44;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "06";
            this.Column6.Name = "Column6";
            this.Column6.Width = 44;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "07";
            this.Column7.Name = "Column7";
            this.Column7.Width = 44;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "08";
            this.Column8.Name = "Column8";
            this.Column8.Width = 44;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "09";
            this.Column9.Name = "Column9";
            this.Column9.Width = 44;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "10";
            this.Column10.Name = "Column10";
            this.Column10.Width = 44;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "11";
            this.Column11.Name = "Column11";
            this.Column11.Width = 44;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "12";
            this.Column12.Name = "Column12";
            this.Column12.Width = 44;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "13";
            this.Column13.Name = "Column13";
            this.Column13.Width = 44;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "14";
            this.Column14.Name = "Column14";
            this.Column14.Width = 44;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "15";
            this.Column15.Name = "Column15";
            this.Column15.Width = 44;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "16";
            this.Column16.Name = "Column16";
            this.Column16.Width = 44;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "17";
            this.Column17.Name = "Column17";
            this.Column17.Width = 44;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "18";
            this.Column18.Name = "Column18";
            this.Column18.Width = 44;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "19";
            this.Column19.Name = "Column19";
            this.Column19.Width = 44;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "20";
            this.Column20.Name = "Column20";
            this.Column20.Width = 44;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "21";
            this.Column21.Name = "Column21";
            this.Column21.Width = 44;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "22";
            this.Column22.Name = "Column22";
            this.Column22.Width = 44;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "23";
            this.Column23.Name = "Column23";
            this.Column23.Width = 44;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "24";
            this.Column24.Name = "Column24";
            this.Column24.Width = 44;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "25";
            this.Column25.Name = "Column25";
            this.Column25.Width = 44;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(410, 10);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 32);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmFoupChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 725);
            this.Controls.Add(this.grpFoupChange);
            this.Controls.Add(this.grpLotInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FrmFoupChange";
            this.Text = "Foup Change";
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