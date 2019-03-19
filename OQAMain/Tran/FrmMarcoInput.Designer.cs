namespace OQAMain
{
    partial class FrmMarcoInput
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.slotComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lotTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.imageUpload1 = new ImageUpload.ImageUpload();
            this.waferSurF = new WaferSf.WaferSur();
            this.frontButton = new System.Windows.Forms.Button();
            this.cmtRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.decRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(1254, 8);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.Location = new System.Drawing.Point(1076, 8);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdite.Location = new System.Drawing.Point(1165, 8);
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlMenu.Location = new System.Drawing.Point(0, 736);
            this.pnlMenu.Size = new System.Drawing.Size(1395, 40);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSucessMsg
            // 
            this.lblSucessMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonB);
            this.groupBox2.Controls.Add(this.radioButtonF);
            this.groupBox2.Controls.Add(this.slotComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lotTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1395, 94);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Macro inspection simple MAP";
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonB.Location = new System.Drawing.Point(411, 54);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(71, 16);
            this.radioButtonB.TabIndex = 8;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "BackSide";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonF.Location = new System.Drawing.Point(328, 54);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(77, 16);
            this.radioButtonF.TabIndex = 7;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "FrontSide";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // slotComboBox
            // 
            this.slotComboBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slotComboBox.FormattingEnabled = true;
            this.slotComboBox.Location = new System.Drawing.Point(217, 52);
            this.slotComboBox.Name = "slotComboBox";
            this.slotComboBox.Size = new System.Drawing.Size(100, 20);
            this.slotComboBox.TabIndex = 4;
            this.slotComboBox.SelectedIndexChanged += new System.EventHandler(this.slotComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(14, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "Lot ID";
            // 
            // lotTextBox
            // 
            this.lotTextBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lotTextBox.Location = new System.Drawing.Point(58, 52);
            this.lotTextBox.Multiline = true;
            this.lotTextBox.Name = "lotTextBox";
            this.lotTextBox.Size = new System.Drawing.Size(100, 20);
            this.lotTextBox.TabIndex = 3;
            this.lotTextBox.TextChanged += new System.EventHandler(this.lotTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(169, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "Slot ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.imageUpload1);
            this.groupBox3.Controls.Add(this.waferSurF);
            this.groupBox3.Controls.Add(this.frontButton);
            this.groupBox3.Controls.Add(this.cmtRichTextBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.decRichTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1395, 776);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(186, 508);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(257, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "R:Residue M:Probe Mark  B: Bridge O:Others";
            // 
            // imageUpload1
            // 
            this.imageUpload1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imageUpload1.Location = new System.Drawing.Point(93, 577);
            this.imageUpload1.Name = "imageUpload1";
            this.imageUpload1.PicStream = null;
            this.imageUpload1.Size = new System.Drawing.Size(380, 31);
            this.imageUpload1.TabIndex = 17;
            this.imageUpload1.UpLoadByArea = null;
            this.imageUpload1.UpLoadByLot = null;
            this.imageUpload1.UpLoadBySide = null;
            this.imageUpload1.UpLoadByWafer = null;
            this.imageUpload1.btnUploadClicked += new ImageUpload.ImageUpload.BtnClickHandle(this.imageUpload1_btnUploadClicked);
            this.imageUpload1.PreviewLableClicked += new ImageUpload.ImageUpload.PreViewClickHandle(this.imageUpload1_PreviewLableClicked);
            // 
            // waferSurF
            // 
            this.waferSurF.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.waferSurF.Location = new System.Drawing.Point(208, 179);
            this.waferSurF.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.waferSurF.Name = "waferSurF";
            this.waferSurF.Size = new System.Drawing.Size(220, 220);
            this.waferSurF.TabIndex = 27;
            // 
            // frontButton
            // 
            this.frontButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.frontButton.Location = new System.Drawing.Point(251, 422);
            this.frontButton.Name = "frontButton";
            this.frontButton.Size = new System.Drawing.Size(123, 23);
            this.frontButton.TabIndex = 31;
            this.frontButton.Text = "Front side";
            this.frontButton.UseVisualStyleBackColor = true;
            // 
            // cmtRichTextBox
            // 
            this.cmtRichTextBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmtRichTextBox.Location = new System.Drawing.Point(93, 647);
            this.cmtRichTextBox.Name = "cmtRichTextBox";
            this.cmtRichTextBox.Size = new System.Drawing.Size(569, 29);
            this.cmtRichTextBox.TabIndex = 16;
            this.cmtRichTextBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(212, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "Pls mark the defect with below special code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(14, 620);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(102, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "A:Arching  S:Scratch  D:Discolor  F:Defocus  C:Corrosion  P:Particle ";
            // 
            // decRichTextBox
            // 
            this.decRichTextBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.decRichTextBox.Location = new System.Drawing.Point(93, 611);
            this.decRichTextBox.Name = "decRichTextBox";
            this.decRichTextBox.Size = new System.Drawing.Size(569, 29);
            this.decRichTextBox.TabIndex = 15;
            this.decRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Defect image";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(14, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Comment";
            // 
            // FrmMarcoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmMarcoInput";
            this.Text = "MarcoInput";
            this.Load += new System.EventHandler(this.FrmMarcoInput_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox slotComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lotTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox cmtRichTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox decRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private ImageUpload.ImageUpload imageUpload1;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.Label label13;
        private WaferSf.WaferSur waferSurF;
        private System.Windows.Forms.Button frontButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}