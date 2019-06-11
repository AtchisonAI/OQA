namespace OQAMain.YE
{
    partial class FrmYEHoldLotHandle
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
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gb_Qrery = new System.Windows.Forms.GroupBox();
            this.tb_LotID = new System.Windows.Forms.TextBox();
            this.lab_Technology = new System.Windows.Forms.Label();
            this.lab_Area = new System.Windows.Forms.Label();
            this.lab_ProductID = new System.Windows.Forms.Label();
            this.lab_Stage = new System.Windows.Forms.Label();
            this.lab_LotStatus = new System.Windows.Forms.Label();
            this.lab_Time = new System.Windows.Forms.Label();
            this.lab_Step = new System.Windows.Forms.Label();
            this.lab_LotID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gb_HoldLotList = new System.Windows.Forms.GroupBox();
            this.gb_HoldLotHandle = new System.Windows.Forms.GroupBox();
            this.dgv_HoldLotList = new System.Windows.Forms.DataGridView();
            this.lab_HoldLotCount = new System.Windows.Forms.Label();
            this.lab_OOCRatio = new System.Windows.Forms.Label();
            this.lab_OOCLotCount = new System.Windows.Forms.Label();
            this.lab_HoldLotRatio = new System.Windows.Forms.Label();
            this.lab_OOSLotCount = new System.Windows.Forms.Label();
            this.lab_OOSRatio = new System.Windows.Forms.Label();
            this.tb_HoldLotCount = new System.Windows.Forms.TextBox();
            this.tb_OOCLotCount = new System.Windows.Forms.TextBox();
            this.tb_OOSLOTCount = new System.Windows.Forms.TextBox();
            this.tb_HoldLotRatio = new System.Windows.Forms.TextBox();
            this.tb_OOCRatio = new System.Windows.Forms.TextBox();
            this.tb_OOSRatio = new System.Windows.Forms.TextBox();
            this.dgv_HoldLotHandle = new System.Windows.Forms.DataGridView();
            this.List_HoldLotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Technology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.List_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle_All = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Handle_HoldLotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle_Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle_Tech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle_Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_HoldLotComment = new System.Windows.Forms.Label();
            this.tb_HoldLotComment = new System.Windows.Forms.TextBox();
            this.lb_Action = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.gb_Qrery.SuspendLayout();
            this.gb_HoldLotList.SuspendLayout();
            this.gb_HoldLotHandle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoldLotList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoldLotHandle)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(254, 614);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // gb_Qrery
            // 
            this.gb_Qrery.Controls.Add(this.btn_Query);
            this.gb_Qrery.Controls.Add(this.dateTimePicker1);
            this.gb_Qrery.Controls.Add(this.comboBox6);
            this.gb_Qrery.Controls.Add(this.comboBox5);
            this.gb_Qrery.Controls.Add(this.comboBox4);
            this.gb_Qrery.Controls.Add(this.comboBox3);
            this.gb_Qrery.Controls.Add(this.comboBox2);
            this.gb_Qrery.Controls.Add(this.comboBox1);
            this.gb_Qrery.Controls.Add(this.tb_LotID);
            this.gb_Qrery.Controls.Add(this.lab_Technology);
            this.gb_Qrery.Controls.Add(this.lab_Area);
            this.gb_Qrery.Controls.Add(this.lab_ProductID);
            this.gb_Qrery.Controls.Add(this.lab_Stage);
            this.gb_Qrery.Controls.Add(this.lab_LotStatus);
            this.gb_Qrery.Controls.Add(this.lab_Time);
            this.gb_Qrery.Controls.Add(this.lab_Step);
            this.gb_Qrery.Controls.Add(this.lab_LotID);
            this.gb_Qrery.Location = new System.Drawing.Point(12, 12);
            this.gb_Qrery.Name = "gb_Qrery";
            this.gb_Qrery.Size = new System.Drawing.Size(232, 590);
            this.gb_Qrery.TabIndex = 2;
            this.gb_Qrery.TabStop = false;
            this.gb_Qrery.Text = "Query";
            // 
            // tb_LotID
            // 
            this.tb_LotID.Location = new System.Drawing.Point(96, 42);
            this.tb_LotID.Name = "tb_LotID";
            this.tb_LotID.Size = new System.Drawing.Size(121, 23);
            this.tb_LotID.TabIndex = 8;
            // 
            // lab_Technology
            // 
            this.lab_Technology.AutoSize = true;
            this.lab_Technology.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Technology.Location = new System.Drawing.Point(10, 396);
            this.lab_Technology.Name = "lab_Technology";
            this.lab_Technology.Size = new System.Drawing.Size(88, 21);
            this.lab_Technology.TabIndex = 7;
            this.lab_Technology.Text = "Technology";
            // 
            // lab_Area
            // 
            this.lab_Area.AutoSize = true;
            this.lab_Area.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Area.Location = new System.Drawing.Point(10, 345);
            this.lab_Area.Name = "lab_Area";
            this.lab_Area.Size = new System.Drawing.Size(42, 21);
            this.lab_Area.TabIndex = 6;
            this.lab_Area.Text = "Area";
            // 
            // lab_ProductID
            // 
            this.lab_ProductID.AutoSize = true;
            this.lab_ProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ProductID.Location = new System.Drawing.Point(10, 293);
            this.lab_ProductID.Name = "lab_ProductID";
            this.lab_ProductID.Size = new System.Drawing.Size(83, 21);
            this.lab_ProductID.TabIndex = 5;
            this.lab_ProductID.Text = "Product ID";
            // 
            // lab_Stage
            // 
            this.lab_Stage.AutoSize = true;
            this.lab_Stage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Stage.Location = new System.Drawing.Point(10, 241);
            this.lab_Stage.Name = "lab_Stage";
            this.lab_Stage.Size = new System.Drawing.Size(48, 21);
            this.lab_Stage.TabIndex = 4;
            this.lab_Stage.Text = "Stage";
            // 
            // lab_LotStatus
            // 
            this.lab_LotStatus.AutoSize = true;
            this.lab_LotStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_LotStatus.Location = new System.Drawing.Point(10, 190);
            this.lab_LotStatus.Name = "lab_LotStatus";
            this.lab_LotStatus.Size = new System.Drawing.Size(78, 21);
            this.lab_LotStatus.TabIndex = 3;
            this.lab_LotStatus.Text = "Lot Status";
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Time.Location = new System.Drawing.Point(10, 142);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(44, 21);
            this.lab_Time.TabIndex = 2;
            this.lab_Time.Text = "Time";
            // 
            // lab_Step
            // 
            this.lab_Step.AutoSize = true;
            this.lab_Step.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Step.Location = new System.Drawing.Point(10, 89);
            this.lab_Step.Name = "lab_Step";
            this.lab_Step.Size = new System.Drawing.Size(40, 21);
            this.lab_Step.TabIndex = 1;
            this.lab_Step.Text = "Step";
            // 
            // lab_LotID
            // 
            this.lab_LotID.AutoSize = true;
            this.lab_LotID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_LotID.Location = new System.Drawing.Point(10, 40);
            this.lab_LotID.Name = "lab_LotID";
            this.lab_LotID.Size = new System.Drawing.Size(51, 21);
            this.lab_LotID.TabIndex = 0;
            this.lab_LotID.Text = "Lot ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(96, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(96, 243);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(96, 295);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 12;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(96, 347);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 23);
            this.comboBox5.TabIndex = 13;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(96, 398);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 23);
            this.comboBox6.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // gb_HoldLotList
            // 
            this.gb_HoldLotList.Controls.Add(this.tb_OOSRatio);
            this.gb_HoldLotList.Controls.Add(this.tb_OOCRatio);
            this.gb_HoldLotList.Controls.Add(this.tb_HoldLotRatio);
            this.gb_HoldLotList.Controls.Add(this.tb_OOSLOTCount);
            this.gb_HoldLotList.Controls.Add(this.tb_OOCLotCount);
            this.gb_HoldLotList.Controls.Add(this.tb_HoldLotCount);
            this.gb_HoldLotList.Controls.Add(this.lab_OOSRatio);
            this.gb_HoldLotList.Controls.Add(this.lab_OOSLotCount);
            this.gb_HoldLotList.Controls.Add(this.lab_HoldLotRatio);
            this.gb_HoldLotList.Controls.Add(this.lab_OOCLotCount);
            this.gb_HoldLotList.Controls.Add(this.lab_OOCRatio);
            this.gb_HoldLotList.Controls.Add(this.lab_HoldLotCount);
            this.gb_HoldLotList.Controls.Add(this.dgv_HoldLotList);
            this.gb_HoldLotList.Location = new System.Drawing.Point(271, 12);
            this.gb_HoldLotList.Name = "gb_HoldLotList";
            this.gb_HoldLotList.Size = new System.Drawing.Size(822, 290);
            this.gb_HoldLotList.TabIndex = 3;
            this.gb_HoldLotList.TabStop = false;
            this.gb_HoldLotList.Text = "Hold Lot List";
            // 
            // gb_HoldLotHandle
            // 
            this.gb_HoldLotHandle.Controls.Add(this.comboBox7);
            this.gb_HoldLotHandle.Controls.Add(this.lb_Action);
            this.gb_HoldLotHandle.Controls.Add(this.tb_HoldLotComment);
            this.gb_HoldLotHandle.Controls.Add(this.lb_HoldLotComment);
            this.gb_HoldLotHandle.Controls.Add(this.dgv_HoldLotHandle);
            this.gb_HoldLotHandle.Location = new System.Drawing.Point(271, 308);
            this.gb_HoldLotHandle.Name = "gb_HoldLotHandle";
            this.gb_HoldLotHandle.Size = new System.Drawing.Size(822, 294);
            this.gb_HoldLotHandle.TabIndex = 4;
            this.gb_HoldLotHandle.TabStop = false;
            this.gb_HoldLotHandle.Text = "Hold Lot Handle";
            // 
            // dgv_HoldLotList
            // 
            this.dgv_HoldLotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoldLotList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.List_HoldLotID,
            this.List_Time,
            this.List_Area,
            this.List_Step,
            this.List_Stage,
            this.List_ProductID,
            this.List_Technology,
            this.List_Status});
            this.dgv_HoldLotList.Location = new System.Drawing.Point(9, 22);
            this.dgv_HoldLotList.Name = "dgv_HoldLotList";
            this.dgv_HoldLotList.RowTemplate.Height = 23;
            this.dgv_HoldLotList.Size = new System.Drawing.Size(799, 183);
            this.dgv_HoldLotList.TabIndex = 0;
            // 
            // lab_HoldLotCount
            // 
            this.lab_HoldLotCount.AutoSize = true;
            this.lab_HoldLotCount.Location = new System.Drawing.Point(17, 225);
            this.lab_HoldLotCount.Name = "lab_HoldLotCount";
            this.lab_HoldLotCount.Size = new System.Drawing.Size(89, 15);
            this.lab_HoldLotCount.TabIndex = 1;
            this.lab_HoldLotCount.Text = "Hold Lot Count";
            // 
            // lab_OOCRatio
            // 
            this.lab_OOCRatio.AutoSize = true;
            this.lab_OOCRatio.Location = new System.Drawing.Point(270, 263);
            this.lab_OOCRatio.Name = "lab_OOCRatio";
            this.lab_OOCRatio.Size = new System.Drawing.Size(63, 15);
            this.lab_OOCRatio.TabIndex = 2;
            this.lab_OOCRatio.Text = "OOC Ratio";
            // 
            // lab_OOCLotCount
            // 
            this.lab_OOCLotCount.AutoSize = true;
            this.lab_OOCLotCount.Location = new System.Drawing.Point(270, 225);
            this.lab_OOCLotCount.Name = "lab_OOCLotCount";
            this.lab_OOCLotCount.Size = new System.Drawing.Size(89, 15);
            this.lab_OOCLotCount.TabIndex = 3;
            this.lab_OOCLotCount.Text = "OOC Lot Count";
            // 
            // lab_HoldLotRatio
            // 
            this.lab_HoldLotRatio.AutoSize = true;
            this.lab_HoldLotRatio.Location = new System.Drawing.Point(17, 263);
            this.lab_HoldLotRatio.Name = "lab_HoldLotRatio";
            this.lab_HoldLotRatio.Size = new System.Drawing.Size(83, 15);
            this.lab_HoldLotRatio.TabIndex = 4;
            this.lab_HoldLotRatio.Text = "Hold Lot Ratio";
            // 
            // lab_OOSLotCount
            // 
            this.lab_OOSLotCount.AutoSize = true;
            this.lab_OOSLotCount.Location = new System.Drawing.Point(554, 225);
            this.lab_OOSLotCount.Name = "lab_OOSLotCount";
            this.lab_OOSLotCount.Size = new System.Drawing.Size(87, 15);
            this.lab_OOSLotCount.TabIndex = 5;
            this.lab_OOSLotCount.Text = "OOS Lot Count";
            // 
            // lab_OOSRatio
            // 
            this.lab_OOSRatio.AutoSize = true;
            this.lab_OOSRatio.Location = new System.Drawing.Point(554, 264);
            this.lab_OOSRatio.Name = "lab_OOSRatio";
            this.lab_OOSRatio.Size = new System.Drawing.Size(61, 15);
            this.lab_OOSRatio.TabIndex = 6;
            this.lab_OOSRatio.Text = "OOS Ratio";
            // 
            // tb_HoldLotCount
            // 
            this.tb_HoldLotCount.Location = new System.Drawing.Point(127, 222);
            this.tb_HoldLotCount.Name = "tb_HoldLotCount";
            this.tb_HoldLotCount.Size = new System.Drawing.Size(121, 23);
            this.tb_HoldLotCount.TabIndex = 9;
            // 
            // tb_OOCLotCount
            // 
            this.tb_OOCLotCount.Location = new System.Drawing.Point(384, 222);
            this.tb_OOCLotCount.Name = "tb_OOCLotCount";
            this.tb_OOCLotCount.Size = new System.Drawing.Size(121, 23);
            this.tb_OOCLotCount.TabIndex = 10;
            // 
            // tb_OOSLOTCount
            // 
            this.tb_OOSLOTCount.Location = new System.Drawing.Point(661, 222);
            this.tb_OOSLOTCount.Name = "tb_OOSLOTCount";
            this.tb_OOSLOTCount.Size = new System.Drawing.Size(121, 23);
            this.tb_OOSLOTCount.TabIndex = 11;
            // 
            // tb_HoldLotRatio
            // 
            this.tb_HoldLotRatio.Location = new System.Drawing.Point(127, 260);
            this.tb_HoldLotRatio.Name = "tb_HoldLotRatio";
            this.tb_HoldLotRatio.Size = new System.Drawing.Size(121, 23);
            this.tb_HoldLotRatio.TabIndex = 12;
            // 
            // tb_OOCRatio
            // 
            this.tb_OOCRatio.Location = new System.Drawing.Point(384, 261);
            this.tb_OOCRatio.Name = "tb_OOCRatio";
            this.tb_OOCRatio.Size = new System.Drawing.Size(121, 23);
            this.tb_OOCRatio.TabIndex = 13;
            // 
            // tb_OOSRatio
            // 
            this.tb_OOSRatio.Location = new System.Drawing.Point(661, 261);
            this.tb_OOSRatio.Name = "tb_OOSRatio";
            this.tb_OOSRatio.Size = new System.Drawing.Size(121, 23);
            this.tb_OOSRatio.TabIndex = 14;
            // 
            // dgv_HoldLotHandle
            // 
            this.dgv_HoldLotHandle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoldLotHandle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Handle_All,
            this.Handle_HoldLotID,
            this.Handle_Step,
            this.Handle_ProductID,
            this.Handle_Tech,
            this.Handle_Priority,
            this.Handle_Comment});
            this.dgv_HoldLotHandle.Location = new System.Drawing.Point(9, 22);
            this.dgv_HoldLotHandle.Name = "dgv_HoldLotHandle";
            this.dgv_HoldLotHandle.RowTemplate.Height = 23;
            this.dgv_HoldLotHandle.Size = new System.Drawing.Size(799, 199);
            this.dgv_HoldLotHandle.TabIndex = 0;
            // 
            // List_HoldLotID
            // 
            this.List_HoldLotID.HeaderText = "Hold Lot ID";
            this.List_HoldLotID.Name = "List_HoldLotID";
            // 
            // List_Time
            // 
            this.List_Time.HeaderText = "Time";
            this.List_Time.Name = "List_Time";
            // 
            // List_Area
            // 
            this.List_Area.HeaderText = "Area";
            this.List_Area.Name = "List_Area";
            // 
            // List_Step
            // 
            this.List_Step.HeaderText = "Step";
            this.List_Step.Name = "List_Step";
            // 
            // List_Stage
            // 
            this.List_Stage.HeaderText = "Stage";
            this.List_Stage.Name = "List_Stage";
            // 
            // List_ProductID
            // 
            this.List_ProductID.HeaderText = "Product ID";
            this.List_ProductID.Name = "List_ProductID";
            // 
            // List_Technology
            // 
            this.List_Technology.HeaderText = "Technology";
            this.List_Technology.Name = "List_Technology";
            // 
            // List_Status
            // 
            this.List_Status.HeaderText = "Status";
            this.List_Status.Name = "List_Status";
            // 
            // Handle_All
            // 
            this.Handle_All.HeaderText = "All";
            this.Handle_All.Name = "Handle_All";
            // 
            // Handle_HoldLotID
            // 
            this.Handle_HoldLotID.HeaderText = "Hold Lot ID";
            this.Handle_HoldLotID.Name = "Handle_HoldLotID";
            // 
            // Handle_Step
            // 
            this.Handle_Step.HeaderText = "Step";
            this.Handle_Step.Name = "Handle_Step";
            // 
            // Handle_ProductID
            // 
            this.Handle_ProductID.HeaderText = "Product ID";
            this.Handle_ProductID.Name = "Handle_ProductID";
            // 
            // Handle_Tech
            // 
            this.Handle_Tech.HeaderText = "TECH";
            this.Handle_Tech.Name = "Handle_Tech";
            // 
            // Handle_Priority
            // 
            this.Handle_Priority.HeaderText = "Priority";
            this.Handle_Priority.Name = "Handle_Priority";
            // 
            // Handle_Comment
            // 
            this.Handle_Comment.HeaderText = "Comment";
            this.Handle_Comment.Name = "Handle_Comment";
            // 
            // lb_HoldLotComment
            // 
            this.lb_HoldLotComment.AutoSize = true;
            this.lb_HoldLotComment.Location = new System.Drawing.Point(23, 236);
            this.lb_HoldLotComment.Name = "lb_HoldLotComment";
            this.lb_HoldLotComment.Size = new System.Drawing.Size(110, 15);
            this.lb_HoldLotComment.TabIndex = 5;
            this.lb_HoldLotComment.Text = "Hold Lot Comment";
            // 
            // tb_HoldLotComment
            // 
            this.tb_HoldLotComment.Location = new System.Drawing.Point(139, 233);
            this.tb_HoldLotComment.Name = "tb_HoldLotComment";
            this.tb_HoldLotComment.Size = new System.Drawing.Size(669, 23);
            this.tb_HoldLotComment.TabIndex = 6;
            // 
            // lb_Action
            // 
            this.lb_Action.AutoSize = true;
            this.lb_Action.Location = new System.Drawing.Point(23, 265);
            this.lb_Action.Name = "lb_Action";
            this.lb_Action.Size = new System.Drawing.Size(42, 15);
            this.lb_Action.TabIndex = 7;
            this.lb_Action.Text = "Action";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(139, 262);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 23);
            this.comboBox7.TabIndex = 10;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(60, 513);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 11;
            this.btn_Query.Text = "Query";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // FrmYEHoldLotHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 614);
            this.Controls.Add(this.gb_HoldLotHandle);
            this.Controls.Add(this.gb_HoldLotList);
            this.Controls.Add(this.gb_Qrery);
            this.Controls.Add(this.splitter2);
            this.Name = "FrmYEHoldLotHandle";
            this.Text = "FrmYEHoldLotHandle";
            this.gb_Qrery.ResumeLayout(false);
            this.gb_Qrery.PerformLayout();
            this.gb_HoldLotList.ResumeLayout(false);
            this.gb_HoldLotList.PerformLayout();
            this.gb_HoldLotHandle.ResumeLayout(false);
            this.gb_HoldLotHandle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoldLotList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoldLotHandle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox gb_Qrery;
        private System.Windows.Forms.Label lab_Technology;
        private System.Windows.Forms.Label lab_Area;
        private System.Windows.Forms.Label lab_ProductID;
        private System.Windows.Forms.Label lab_Stage;
        private System.Windows.Forms.Label lab_LotStatus;
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.Label lab_Step;
        private System.Windows.Forms.Label lab_LotID;
        private System.Windows.Forms.TextBox tb_LotID;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gb_HoldLotList;
        private System.Windows.Forms.GroupBox gb_HoldLotHandle;
        private System.Windows.Forms.DataGridView dgv_HoldLotList;
        private System.Windows.Forms.Label lab_OOSRatio;
        private System.Windows.Forms.Label lab_OOSLotCount;
        private System.Windows.Forms.Label lab_HoldLotRatio;
        private System.Windows.Forms.Label lab_OOCLotCount;
        private System.Windows.Forms.Label lab_OOCRatio;
        private System.Windows.Forms.Label lab_HoldLotCount;
        private System.Windows.Forms.TextBox tb_OOSLOTCount;
        private System.Windows.Forms.TextBox tb_OOCLotCount;
        private System.Windows.Forms.TextBox tb_HoldLotCount;
        private System.Windows.Forms.TextBox tb_OOSRatio;
        private System.Windows.Forms.TextBox tb_OOCRatio;
        private System.Windows.Forms.TextBox tb_HoldLotRatio;
        private System.Windows.Forms.DataGridView dgv_HoldLotHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_HoldLotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_Technology;
        private System.Windows.Forms.DataGridViewTextBoxColumn List_Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Handle_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn Handle_HoldLotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Handle_Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn Handle_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Handle_Tech;
        private System.Windows.Forms.DataGridViewTextBoxColumn Handle_Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Handle_Comment;
        private System.Windows.Forms.TextBox tb_HoldLotComment;
        private System.Windows.Forms.Label lb_HoldLotComment;
        private System.Windows.Forms.Label lb_Action;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button btn_Query;
    }
}