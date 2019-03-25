namespace OQAMain
{
    partial class FrmLotTransfer
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
            this.btnUnCheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.LotIDList = new System.Windows.Forms.CheckedListBox();
            this.txtSearchLotID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCreater = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listship = new System.Windows.Forms.ListView();
            this.Lot_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Part_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inspection_Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transeq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkALL = new System.Windows.Forms.CheckBox();
            this.pnlMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(685, 6);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(593, 6);
            this.btnCreate.Text = "OK";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(593, 6);
            this.btnEdite.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(14, 6);
            // 
            // lblSucessMsg
            // 
            this.lblSucessMsg.Location = new System.Drawing.Point(72, 12);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.chkALL);
            this.groupBox1.Controls.Add(this.btnUnCheckAll);
            this.groupBox1.Controls.Add(this.btnCheckAll);
            this.groupBox1.Controls.Add(this.LotIDList);
            this.groupBox1.Controls.Add(this.txtSearchLotID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 660);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待发料批次清单";
            // 
            // btnUnCheckAll
            // 
            this.btnUnCheckAll.Location = new System.Drawing.Point(62, 57);
            this.btnUnCheckAll.Name = "btnUnCheckAll";
            this.btnUnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnUnCheckAll.TabIndex = 9;
            this.btnUnCheckAll.Text = "Cancel";
            this.btnUnCheckAll.UseVisualStyleBackColor = true;
            this.btnUnCheckAll.Click += new System.EventHandler(this.btnUnCheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(147, 57);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 8;
            this.btnCheckAll.Text = "Choose All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // LotIDList
            // 
            this.LotIDList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LotIDList.BackColor = System.Drawing.SystemColors.Window;
            this.LotIDList.CheckOnClick = true;
            this.LotIDList.FormattingEnabled = true;
            this.LotIDList.Location = new System.Drawing.Point(12, 86);
            this.LotIDList.Name = "LotIDList";
            this.LotIDList.Size = new System.Drawing.Size(200, 548);
            this.LotIDList.TabIndex = 7;
            this.LotIDList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LotIDList_ItemCheck);
            // 
            // txtSearchLotID
            // 
            this.txtSearchLotID.Location = new System.Drawing.Point(62, 23);
            this.txtSearchLotID.Name = "txtSearchLotID";
            this.txtSearchLotID.Size = new System.Drawing.Size(150, 21);
            this.txtSearchLotID.TabIndex = 5;
            this.txtSearchLotID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Press_check);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lot ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.txtCreater);
            this.groupBox2.Controls.Add(this.txtQTY);
            this.groupBox2.Controls.Add(this.txtPartID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(231, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发料批次信息";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(243, 44);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 21);
            this.txtDate.TabIndex = 15;
            // 
            // txtCreater
            // 
            this.txtCreater.Location = new System.Drawing.Point(79, 47);
            this.txtCreater.Name = "txtCreater";
            this.txtCreater.ReadOnly = true;
            this.txtCreater.Size = new System.Drawing.Size(100, 21);
            this.txtCreater.TabIndex = 14;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(243, 21);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.ReadOnly = true;
            this.txtQTY.Size = new System.Drawing.Size(100, 21);
            this.txtQTY.TabIndex = 13;
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(79, 23);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(100, 21);
            this.txtPartID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Creater";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Part ID";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(228, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 660);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(780, 700);
            this.dataGridView1.TabIndex = 4;
            // 
            // listship
            // 
            this.listship.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lot_ID,
            this.Qty,
            this.Part_ID,
            this.Inspection_Result,
            this.Transeq});
            this.listship.Cursor = System.Windows.Forms.Cursors.Default;
            this.listship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listship.Location = new System.Drawing.Point(231, 80);
            this.listship.Name = "listship";
            this.listship.Size = new System.Drawing.Size(549, 580);
            this.listship.TabIndex = 5;
            this.listship.UseCompatibleStateImageBehavior = false;
            this.listship.View = System.Windows.Forms.View.Details;
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
            // Transeq
            // 
            this.Transeq.Width = 0;
            // 
            // chkALL
            // 
            this.chkALL.AutoSize = true;
            this.chkALL.Location = new System.Drawing.Point(15, 67);
            this.chkALL.Name = "chkALL";
            this.chkALL.Size = new System.Drawing.Size(42, 16);
            this.chkALL.TabIndex = 11;
            this.chkALL.Text = "ALL";
            this.chkALL.UseVisualStyleBackColor = true;
            this.chkALL.CheckedChanged += new System.EventHandler(this.chkALL_CheckedChanged);
            // 
            // FrmLotTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 700);
            this.Controls.Add(this.listship);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLotTransfer";
            this.Text = "FrmLotTransfer";
            this.Load += new System.EventHandler(this.FrmLotTransfer_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.listship, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCreater;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchLotID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listship;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Part_ID;
        private System.Windows.Forms.ColumnHeader Inspection_Result;
        private System.Windows.Forms.CheckedListBox LotIDList;
        private System.Windows.Forms.Button btnUnCheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.ColumnHeader Transeq;
        private System.Windows.Forms.ColumnHeader Lot_ID;
        private System.Windows.Forms.CheckBox chkALL;
    }
}