namespace OQAMain
{
    partial class FrmLotInspect
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
            this.grpRcvLot = new System.Windows.Forms.GroupBox();
            this.lblFoupFilter = new System.Windows.Forms.Label();
            this.TxtFoupFilter = new System.Windows.Forms.TextBox();
            this.lblLotFilter = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtLotFilter = new System.Windows.Forms.TextBox();
            this.btnFilterView = new System.Windows.Forms.Button();
            this.LstRcvLot = new System.Windows.Forms.ListView();
            this.LotID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoupID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transeq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Partdesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dieqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lotqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LotType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeptID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cust_lot_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cust_part_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grpOQAInfo = new System.Windows.Forms.GroupBox();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.lblPartID = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLotQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.labShift = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtLotType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLotID = new System.Windows.Forms.TextBox();
            this.labLot = new System.Windows.Forms.Label();
            this.txtRecDate = new System.Windows.Forms.TextBox();
            this.labDate = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.labDept = new System.Windows.Forms.Label();
            this.imageUploadLotIsp = new ImageUpload.ImageUpload();
            this.imageUpload1 = new ImageUpload.ImageUpload();
            this.pnlMenu.SuspendLayout();
            this.grpRcvLot.SuspendLayout();
            this.grpOQAInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRcvLot
            // 
            this.grpRcvLot.Controls.Add(this.lblFoupFilter);
            this.grpRcvLot.Controls.Add(this.TxtFoupFilter);
            this.grpRcvLot.Controls.Add(this.lblLotFilter);
            this.grpRcvLot.Controls.Add(this.txtCount);
            this.grpRcvLot.Controls.Add(this.txtLotFilter);
            this.grpRcvLot.Controls.Add(this.btnFilterView);
            this.grpRcvLot.Controls.Add(this.LstRcvLot);
            this.grpRcvLot.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpRcvLot.Location = new System.Drawing.Point(0, 0);
            this.grpRcvLot.Name = "grpRcvLot";
            this.grpRcvLot.Size = new System.Drawing.Size(250, 540);
            this.grpRcvLot.TabIndex = 3;
            this.grpRcvLot.TabStop = false;
            this.grpRcvLot.Text = "Recive Lot Query";
            // 
            // lblFoupFilter
            // 
            this.lblFoupFilter.AutoSize = true;
            this.lblFoupFilter.Location = new System.Drawing.Point(10, 19);
            this.lblFoupFilter.Name = "lblFoupFilter";
            this.lblFoupFilter.Size = new System.Drawing.Size(47, 12);
            this.lblFoupFilter.TabIndex = 11;
            this.lblFoupFilter.Text = "Foup ID";
            // 
            // TxtFoupFilter
            // 
            this.TxtFoupFilter.Location = new System.Drawing.Point(62, 16);
            this.TxtFoupFilter.Name = "TxtFoupFilter";
            this.TxtFoupFilter.Size = new System.Drawing.Size(100, 21);
            this.TxtFoupFilter.TabIndex = 10;
            // 
            // lblLotFilter
            // 
            this.lblLotFilter.AutoSize = true;
            this.lblLotFilter.Location = new System.Drawing.Point(10, 43);
            this.lblLotFilter.Name = "lblLotFilter";
            this.lblLotFilter.Size = new System.Drawing.Size(41, 12);
            this.lblLotFilter.TabIndex = 9;
            this.lblLotFilter.Text = "Lot ID";
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
            // txtLotFilter
            // 
            this.txtLotFilter.Location = new System.Drawing.Point(62, 40);
            this.txtLotFilter.Name = "txtLotFilter";
            this.txtLotFilter.Size = new System.Drawing.Size(100, 21);
            this.txtLotFilter.TabIndex = 5;
            // 
            // btnFilterView
            // 
            this.btnFilterView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFilterView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFilterView.Location = new System.Drawing.Point(184, 41);
            this.btnFilterView.Name = "btnFilterView";
            this.btnFilterView.Size = new System.Drawing.Size(36, 20);
            this.btnFilterView.TabIndex = 7;
            this.btnFilterView.Text = "View";
            // 
            // LstRcvLot
            // 
            this.LstRcvLot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstRcvLot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LotID,
            this.FoupID,
            this.transeq,
            this.PartID,
            this.Partdesc,
            this.Dieqty,
            this.Lotqty,
            this.LotType,
            this.Stage,
            this.DeptID,
            this.CustomerID,
            this.Cust_lot_ID,
            this.Cust_part_ID});
            this.LstRcvLot.Location = new System.Drawing.Point(9, 63);
            this.LstRcvLot.Name = "LstRcvLot";
            this.LstRcvLot.Size = new System.Drawing.Size(230, 450);
            this.LstRcvLot.TabIndex = 1;
            this.LstRcvLot.UseCompatibleStateImageBehavior = false;
            this.LstRcvLot.View = System.Windows.Forms.View.Details;
            // 
            // LotID
            // 
            this.LotID.Text = "Lot ID";
            this.LotID.Width = 120;
            // 
            // FoupID
            // 
            this.FoupID.Text = "Foup ID";
            this.FoupID.Width = 120;
            // 
            // transeq
            // 
            this.transeq.Text = "transeq";
            this.transeq.Width = 0;
            // 
            // PartID
            // 
            this.PartID.Text = "Part ID";
            // 
            // Partdesc
            // 
            this.Partdesc.Text = "Part desc";
            this.Partdesc.Width = 120;
            // 
            // Dieqty
            // 
            this.Dieqty.Text = "Die Qty";
            this.Dieqty.Width = 30;
            // 
            // Lotqty
            // 
            this.Lotqty.Text = "Lot Qty";
            this.Lotqty.Width = 30;
            // 
            // LotType
            // 
            this.LotType.Text = "Lot Type";
            this.LotType.Width = 30;
            // 
            // Stage
            // 
            this.Stage.Text = "Stage";
            this.Stage.Width = 40;
            // 
            // DeptID
            // 
            this.DeptID.Text = "Dept ID";
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "Customer ID";
            // 
            // Cust_lot_ID
            // 
            this.Cust_lot_ID.Text = "Cust Lot ID";
            this.Cust_lot_ID.Width = 100;
            // 
            // Cust_part_ID
            // 
            this.Cust_part_ID.Text = "Cust part ID";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(250, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 540);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // grpOQAInfo
            // 
            this.grpOQAInfo.Controls.Add(this.txtStage);
            this.grpOQAInfo.Controls.Add(this.lblStage);
            this.grpOQAInfo.Controls.Add(this.txtPartID);
            this.grpOQAInfo.Controls.Add(this.lblPartID);
            this.grpOQAInfo.Controls.Add(this.txtPhone);
            this.grpOQAInfo.Controls.Add(this.lblPhone);
            this.grpOQAInfo.Controls.Add(this.txtName);
            this.grpOQAInfo.Controls.Add(this.lblName);
            this.grpOQAInfo.Controls.Add(this.txtLotQty);
            this.grpOQAInfo.Controls.Add(this.label2);
            this.grpOQAInfo.Controls.Add(this.txtFoupID);
            this.grpOQAInfo.Controls.Add(this.label3);
            this.grpOQAInfo.Controls.Add(this.txtShift);
            this.grpOQAInfo.Controls.Add(this.labShift);
            this.grpOQAInfo.Controls.Add(this.txtUserID);
            this.grpOQAInfo.Controls.Add(this.lblUserID);
            this.grpOQAInfo.Controls.Add(this.txtLotType);
            this.grpOQAInfo.Controls.Add(this.label1);
            this.grpOQAInfo.Controls.Add(this.txtLotID);
            this.grpOQAInfo.Controls.Add(this.labLot);
            this.grpOQAInfo.Controls.Add(this.txtRecDate);
            this.grpOQAInfo.Controls.Add(this.labDate);
            this.grpOQAInfo.Controls.Add(this.txtDept);
            this.grpOQAInfo.Controls.Add(this.labDept);
            this.grpOQAInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOQAInfo.Location = new System.Drawing.Point(253, 0);
            this.grpOQAInfo.Name = "grpOQAInfo";
            this.grpOQAInfo.Size = new System.Drawing.Size(497, 120);
            this.grpOQAInfo.TabIndex = 8;
            this.grpOQAInfo.TabStop = false;
            this.grpOQAInfo.Text = "OQA Information";
            // 
            // txtStage
            // 
            this.txtStage.Enabled = false;
            this.txtStage.Location = new System.Drawing.Point(506, 92);
            this.txtStage.MaxLength = 1;
            this.txtStage.Name = "txtStage";
            this.txtStage.Size = new System.Drawing.Size(100, 21);
            this.txtStage.TabIndex = 23;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(418, 95);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(35, 12);
            this.lblStage.TabIndex = 22;
            this.lblStage.Text = "Stage";
            // 
            // txtPartID
            // 
            this.txtPartID.Enabled = false;
            this.txtPartID.Location = new System.Drawing.Point(506, 68);
            this.txtPartID.MaxLength = 50;
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(100, 21);
            this.txtPartID.TabIndex = 21;
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Location = new System.Drawing.Point(418, 71);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(83, 12);
            this.lblPartID.TabIndex = 20;
            this.lblPartID.Text = "Product  Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(506, 44);
            this.txtPhone.MaxLength = 1;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(418, 47);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(35, 12);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(506, 20);
            this.txtName.MaxLength = 1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(418, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtLotQty
            // 
            this.txtLotQty.Enabled = false;
            this.txtLotQty.Location = new System.Drawing.Point(280, 92);
            this.txtLotQty.MaxLength = 1;
            this.txtLotQty.Name = "txtLotQty";
            this.txtLotQty.Size = new System.Drawing.Size(100, 21);
            this.txtLotQty.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lot Qty";
            // 
            // txtFoupID
            // 
            this.txtFoupID.Enabled = false;
            this.txtFoupID.Location = new System.Drawing.Point(280, 68);
            this.txtFoupID.MaxLength = 50;
            this.txtFoupID.Name = "txtFoupID";
            this.txtFoupID.Size = new System.Drawing.Size(100, 21);
            this.txtFoupID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Foup ID";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(280, 44);
            this.txtShift.MaxLength = 1;
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(100, 21);
            this.txtShift.TabIndex = 11;
            // 
            // labShift
            // 
            this.labShift.AutoSize = true;
            this.labShift.Location = new System.Drawing.Point(220, 47);
            this.labShift.Name = "labShift";
            this.labShift.Size = new System.Drawing.Size(35, 12);
            this.labShift.TabIndex = 10;
            this.labShift.Text = "Shift";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(280, 20);
            this.txtUserID.MaxLength = 1;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 21);
            this.txtUserID.TabIndex = 9;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(220, 23);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(17, 12);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "ID";
            // 
            // txtLotType
            // 
            this.txtLotType.Enabled = false;
            this.txtLotType.Location = new System.Drawing.Point(73, 92);
            this.txtLotType.MaxLength = 1;
            this.txtLotType.Name = "txtLotType";
            this.txtLotType.Size = new System.Drawing.Size(100, 21);
            this.txtLotType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lot Type";
            // 
            // txtLotID
            // 
            this.txtLotID.Enabled = false;
            this.txtLotID.Location = new System.Drawing.Point(73, 68);
            this.txtLotID.MaxLength = 50;
            this.txtLotID.Name = "txtLotID";
            this.txtLotID.Size = new System.Drawing.Size(100, 21);
            this.txtLotID.TabIndex = 5;
            // 
            // labLot
            // 
            this.labLot.AutoSize = true;
            this.labLot.Location = new System.Drawing.Point(13, 71);
            this.labLot.Name = "labLot";
            this.labLot.Size = new System.Drawing.Size(41, 12);
            this.labLot.TabIndex = 4;
            this.labLot.Text = "Lot ID";
            // 
            // txtRecDate
            // 
            this.txtRecDate.Enabled = false;
            this.txtRecDate.Location = new System.Drawing.Point(73, 44);
            this.txtRecDate.MaxLength = 1;
            this.txtRecDate.Name = "txtRecDate";
            this.txtRecDate.Size = new System.Drawing.Size(100, 21);
            this.txtRecDate.TabIndex = 3;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(13, 47);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(29, 12);
            this.labDate.TabIndex = 2;
            this.labDate.Text = "Date";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(73, 20);
            this.txtDept.MaxLength = 1;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 21);
            this.txtDept.TabIndex = 1;
            // 
            // labDept
            // 
            this.labDept.AutoSize = true;
            this.labDept.Location = new System.Drawing.Point(13, 23);
            this.labDept.Name = "labDept";
            this.labDept.Size = new System.Drawing.Size(29, 12);
            this.labDept.TabIndex = 0;
            this.labDept.Text = "Dept";
            // 
            // imageUploadLotIsp
            // 
            this.imageUploadLotIsp.Location = new System.Drawing.Point(268, 126);
            this.imageUploadLotIsp.Name = "imageUploadLotIsp";
            this.imageUploadLotIsp.PicStream = null;
            this.imageUploadLotIsp.Size = new System.Drawing.Size(283, 31);
            this.imageUploadLotIsp.TabIndex = 9;
            // 
            // imageUpload1
            // 
            this.imageUpload1.Location = new System.Drawing.Point(278, 126);
            this.imageUpload1.Name = "imageUpload1";
            this.imageUpload1.PicStream = null;
            this.imageUpload1.Size = new System.Drawing.Size(283, 31);
            this.imageUpload1.TabIndex = 9;
            this.imageUpload1.btnUploadClicked += new ImageUpload.ImageUpload.BtnClickHandle(this.imageUpload1_btnUploadClicked);
            // 
            // FrmLotInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.imageUpload1);
            this.Controls.Add(this.grpOQAInfo);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grpRcvLot);
            this.Name = "FrmLotInspect";
            this.Text = "Lot Inspect";
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.grpRcvLot, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.grpOQAInfo, 0);
            this.Controls.SetChildIndex(this.imageUpload1, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.grpRcvLot.ResumeLayout(false);
            this.grpRcvLot.PerformLayout();
            this.grpOQAInfo.ResumeLayout(false);
            this.grpOQAInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRcvLot;
        protected System.Windows.Forms.TextBox txtCount;
        protected System.Windows.Forms.TextBox txtLotFilter;
        protected System.Windows.Forms.Button btnFilterView;
        private System.Windows.Forms.ListView LstRcvLot;
        private System.Windows.Forms.ColumnHeader LotID;
        private System.Windows.Forms.ColumnHeader FoupID;
        private System.Windows.Forms.ColumnHeader PartID;
        private System.Windows.Forms.ColumnHeader transeq;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblFoupFilter;
        protected System.Windows.Forms.TextBox TxtFoupFilter;
        private System.Windows.Forms.Label lblLotFilter;
        private System.Windows.Forms.ColumnHeader Partdesc;
        private System.Windows.Forms.ColumnHeader Dieqty;
        private System.Windows.Forms.ColumnHeader Lotqty;
        private System.Windows.Forms.ColumnHeader LotType;
        private System.Windows.Forms.ColumnHeader Stage;
        private System.Windows.Forms.ColumnHeader DeptID;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader Cust_lot_ID;
        private System.Windows.Forms.ColumnHeader Cust_part_ID;
        private System.Windows.Forms.GroupBox grpOQAInfo;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLotQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label labShift;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtLotType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLotID;
        private System.Windows.Forms.Label labLot;
        private System.Windows.Forms.TextBox txtRecDate;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label labDept;
        private ImageUpload.ImageUpload imageUploadLotIsp;
        private ImageUpload.ImageUpload imageUpload1;
    }
}