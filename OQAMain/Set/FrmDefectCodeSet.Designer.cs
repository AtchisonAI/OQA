namespace OQAMain
{
    partial class FrmDefectCodeSet
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
            this.LstIspCode = new System.Windows.Forms.ListView();
            this.InspectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DefectCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DefectDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transeq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpIspType = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilterView = new System.Windows.Forms.Button();
            this.rbnNoFilter = new System.Windows.Forms.RadioButton();
            this.rbnFilter = new System.Windows.Forms.RadioButton();
            this.grpDefectCode = new System.Windows.Forms.GroupBox();
            this.txtDefectDesc = new System.Windows.Forms.TextBox();
            this.labDefectDesc = new System.Windows.Forms.Label();
            this.txtDefectCode = new System.Windows.Forms.TextBox();
            this.labDefectCode = new System.Windows.Forms.Label();
            this.txtIspType = new System.Windows.Forms.TextBox();
            this.labIspType = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMenu.SuspendLayout();
            this.grpIspType.SuspendLayout();
            this.grpDefectCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(745, 6);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(651, 7);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(651, 6);
            this.btnEdite.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 540);
            this.pnlMenu.Size = new System.Drawing.Size(750, 40);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LstIspCode
            // 
            this.LstIspCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstIspCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InspectType,
            this.DefectCode,
            this.DefectDesc,
            this.transeq});
            this.LstIspCode.Location = new System.Drawing.Point(9, 63);
            this.LstIspCode.Name = "LstIspCode";
            this.LstIspCode.Size = new System.Drawing.Size(180, 450);
            this.LstIspCode.TabIndex = 1;
            this.LstIspCode.UseCompatibleStateImageBehavior = false;
            this.LstIspCode.View = System.Windows.Forms.View.Details;
            this.LstIspCode.SelectedIndexChanged += new System.EventHandler(this.LstIspCode_SelectedIndexChanged);
            // 
            // InspectType
            // 
            this.InspectType.Text = "Inspect Type";
            this.InspectType.Width = 120;
            // 
            // DefectCode
            // 
            this.DefectCode.Text = "Defect Code";
            this.DefectCode.Width = 120;
            // 
            // DefectDesc
            // 
            this.DefectDesc.Text = "Defect Desc";
            this.DefectDesc.Width = 200;
            // 
            // transeq
            // 
            this.transeq.Text = "transeq";
            this.transeq.Width = 0;
            // 
            // grpIspType
            // 
            this.grpIspType.Controls.Add(this.txtCount);
            this.grpIspType.Controls.Add(this.txtFilter);
            this.grpIspType.Controls.Add(this.btnFilterView);
            this.grpIspType.Controls.Add(this.rbnNoFilter);
            this.grpIspType.Controls.Add(this.rbnFilter);
            this.grpIspType.Controls.Add(this.LstIspCode);
            this.grpIspType.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpIspType.Location = new System.Drawing.Point(0, 0);
            this.grpIspType.Name = "grpIspType";
            this.grpIspType.Size = new System.Drawing.Size(200, 540);
            this.grpIspType.TabIndex = 2;
            this.grpIspType.TabStop = false;
            this.grpIspType.Text = "Inspect Type";
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(9, 515);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 21);
            this.txtCount.TabIndex = 8;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(31, 40);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 21);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // btnFilterView
            // 
            this.btnFilterView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFilterView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFilterView.Location = new System.Drawing.Point(153, 41);
            this.btnFilterView.Name = "btnFilterView";
            this.btnFilterView.Size = new System.Drawing.Size(36, 20);
            this.btnFilterView.TabIndex = 7;
            this.btnFilterView.Text = "View";
            this.btnFilterView.Click += new System.EventHandler(this.btnFilterView_Click);
            // 
            // rbnNoFilter
            // 
            this.rbnNoFilter.Location = new System.Drawing.Point(13, 19);
            this.rbnNoFilter.Name = "rbnNoFilter";
            this.rbnNoFilter.Size = new System.Drawing.Size(49, 15);
            this.rbnNoFilter.TabIndex = 6;
            this.rbnNoFilter.Text = "All";
            this.rbnNoFilter.CheckedChanged += new System.EventHandler(this.rbnNoFilter_CheckedChanged);
            // 
            // rbnFilter
            // 
            this.rbnFilter.Checked = true;
            this.rbnFilter.Location = new System.Drawing.Point(13, 43);
            this.rbnFilter.Name = "rbnFilter";
            this.rbnFilter.Size = new System.Drawing.Size(16, 14);
            this.rbnFilter.TabIndex = 4;
            this.rbnFilter.TabStop = true;
            this.rbnFilter.CheckedChanged += new System.EventHandler(this.rbnFilter_CheckedChanged);
            // 
            // grpDefectCode
            // 
            this.grpDefectCode.Controls.Add(this.txtDefectDesc);
            this.grpDefectCode.Controls.Add(this.labDefectDesc);
            this.grpDefectCode.Controls.Add(this.txtDefectCode);
            this.grpDefectCode.Controls.Add(this.labDefectCode);
            this.grpDefectCode.Controls.Add(this.txtIspType);
            this.grpDefectCode.Controls.Add(this.labIspType);
            this.grpDefectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDefectCode.Location = new System.Drawing.Point(200, 0);
            this.grpDefectCode.Name = "grpDefectCode";
            this.grpDefectCode.Size = new System.Drawing.Size(550, 540);
            this.grpDefectCode.TabIndex = 3;
            this.grpDefectCode.TabStop = false;
            this.grpDefectCode.Text = "Defect Code Information";
            // 
            // txtDefectDesc
            // 
            this.txtDefectDesc.Location = new System.Drawing.Point(135, 91);
            this.txtDefectDesc.MaxLength = 50;
            this.txtDefectDesc.Name = "txtDefectDesc";
            this.txtDefectDesc.Size = new System.Drawing.Size(150, 21);
            this.txtDefectDesc.TabIndex = 5;
            // 
            // labDefectDesc
            // 
            this.labDefectDesc.AutoSize = true;
            this.labDefectDesc.Location = new System.Drawing.Point(13, 95);
            this.labDefectDesc.Name = "labDefectDesc";
            this.labDefectDesc.Size = new System.Drawing.Size(113, 12);
            this.labDefectDesc.TabIndex = 4;
            this.labDefectDesc.Text = "Defect Description";
            // 
            // txtDefectCode
            // 
            this.txtDefectCode.Location = new System.Drawing.Point(135, 66);
            this.txtDefectCode.MaxLength = 1;
            this.txtDefectCode.Name = "txtDefectCode";
            this.txtDefectCode.Size = new System.Drawing.Size(100, 21);
            this.txtDefectCode.TabIndex = 3;
            // 
            // labDefectCode
            // 
            this.labDefectCode.AutoSize = true;
            this.labDefectCode.Location = new System.Drawing.Point(13, 70);
            this.labDefectCode.Name = "labDefectCode";
            this.labDefectCode.Size = new System.Drawing.Size(71, 12);
            this.labDefectCode.TabIndex = 2;
            this.labDefectCode.Text = "Defect Code";
            // 
            // txtIspType
            // 
            this.txtIspType.Location = new System.Drawing.Point(135, 42);
            this.txtIspType.MaxLength = 1;
            this.txtIspType.Name = "txtIspType";
            this.txtIspType.Size = new System.Drawing.Size(100, 21);
            this.txtIspType.TabIndex = 1;
            // 
            // labIspType
            // 
            this.labIspType.AutoSize = true;
            this.labIspType.Location = new System.Drawing.Point(13, 46);
            this.labIspType.Name = "labIspType";
            this.labIspType.Size = new System.Drawing.Size(77, 12);
            this.labIspType.TabIndex = 0;
            this.labIspType.Text = "Inspect Type";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 540);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // FrmDefectCodeSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grpDefectCode);
            this.Controls.Add(this.grpIspType);
            this.Name = "FrmDefectCodeSet";
            this.Text = "Defect Code Set";
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.grpIspType, 0);
            this.Controls.SetChildIndex(this.grpDefectCode, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.grpIspType.ResumeLayout(false);
            this.grpIspType.PerformLayout();
            this.grpDefectCode.ResumeLayout(false);
            this.grpDefectCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstIspCode;
        private System.Windows.Forms.GroupBox grpIspType;
        protected System.Windows.Forms.TextBox txtFilter;
        protected System.Windows.Forms.Button btnFilterView;
        protected System.Windows.Forms.RadioButton rbnNoFilter;
        protected System.Windows.Forms.RadioButton rbnFilter;
        private System.Windows.Forms.GroupBox grpDefectCode;
        private System.Windows.Forms.TextBox txtDefectDesc;
        private System.Windows.Forms.Label labDefectDesc;
        private System.Windows.Forms.TextBox txtDefectCode;
        private System.Windows.Forms.Label labDefectCode;
        private System.Windows.Forms.TextBox txtIspType;
        private System.Windows.Forms.Label labIspType;
        private System.Windows.Forms.ColumnHeader InspectType;
        private System.Windows.Forms.ColumnHeader DefectCode;
        private System.Windows.Forms.ColumnHeader DefectDesc;
        protected System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ColumnHeader transeq;
    }
}