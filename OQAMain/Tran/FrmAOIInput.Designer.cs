namespace OQAMain
{
    partial class FrmAOIInput
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageUpload1 = new ImageUpload.ImageUpload();
            this.labelPer = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmtRichTextBox = new System.Windows.Forms.RichTextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.MagnificationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.defectTextBox = new System.Windows.Forms.TextBox();
            this.decRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReviewTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.frontButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.waferSurF = new WaferSf.WaferSur();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.slotComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lotTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(804, 11);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(536, 11);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(676, 11);
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlMenu.Location = new System.Drawing.Point(0, 811);
            this.pnlMenu.Size = new System.Drawing.Size(1049, 40);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.imageUpload1);
            this.groupBox3.Controls.Add(this.labelPer);
            this.groupBox3.Controls.Add(this.labelX);
            this.groupBox3.Controls.Add(this.rateTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmtRichTextBox);
            this.groupBox3.Controls.Add(this.qtyTextBox);
            this.groupBox3.Controls.Add(this.MagnificationTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.defectTextBox);
            this.groupBox3.Controls.Add(this.decRichTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ReviewTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 531);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(880, 225);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // imageUpload1
            // 
            this.imageUpload1.Location = new System.Drawing.Point(123, 80);
            this.imageUpload1.Name = "imageUpload1";
            this.imageUpload1.PicStream = null;
            this.imageUpload1.Size = new System.Drawing.Size(310, 31);
            this.imageUpload1.TabIndex = 20;
            this.imageUpload1.UpLoadByArea = null;
            this.imageUpload1.UpLoadByLot = null;
            this.imageUpload1.UpLoadBySide = null;
            this.imageUpload1.UpLoadByWafer = null;
            this.imageUpload1.btnUploadClicked += new ImageUpload.ImageUpload.BtnClickHandle(this.imageUpload1_btnUploadClicked);
            // 
            // labelPer
            // 
            this.labelPer.AutoSize = true;
            this.labelPer.BackColor = System.Drawing.Color.Transparent;
            this.labelPer.Location = new System.Drawing.Point(604, 89);
            this.labelPer.Name = "labelPer";
            this.labelPer.Size = new System.Drawing.Size(11, 12);
            this.labelPer.TabIndex = 19;
            this.labelPer.Text = "%";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.Transparent;
            this.labelX.Location = new System.Drawing.Point(213, 39);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(11, 12);
            this.labelX.TabIndex = 18;
            this.labelX.Text = "X";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Enabled = false;
            this.rateTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.rateTextBox.Location = new System.Drawing.Point(525, 84);
            this.rateTextBox.Multiline = true;
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label6.Location = new System.Drawing.Point(435, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Defect rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label7.Location = new System.Drawing.Point(647, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Review by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Magnification";
            // 
            // cmtRichTextBox
            // 
            this.cmtRichTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.cmtRichTextBox.Location = new System.Drawing.Point(133, 172);
            this.cmtRichTextBox.Name = "cmtRichTextBox";
            this.cmtRichTextBox.Size = new System.Drawing.Size(735, 29);
            this.cmtRichTextBox.TabIndex = 16;
            this.cmtRichTextBox.Text = "";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.qtyTextBox.Location = new System.Drawing.Point(768, 37);
            this.qtyTextBox.Multiline = true;
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextBox.TabIndex = 11;
            this.qtyTextBox.TextChanged += new System.EventHandler(this.qtyTextBox_TextChanged);
            this.qtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyTextBox_KeyPress);
            // 
            // MagnificationTextBox
            // 
            this.MagnificationTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.MagnificationTextBox.Location = new System.Drawing.Point(133, 37);
            this.MagnificationTextBox.Multiline = true;
            this.MagnificationTextBox.Name = "MagnificationTextBox";
            this.MagnificationTextBox.Size = new System.Drawing.Size(100, 20);
            this.MagnificationTextBox.TabIndex = 2;
            this.MagnificationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MagnificationTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label8.Location = new System.Drawing.Point(26, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description";
            // 
            // defectTextBox
            // 
            this.defectTextBox.Enabled = false;
            this.defectTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.defectTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.defectTextBox.Location = new System.Drawing.Point(525, 37);
            this.defectTextBox.Multiline = true;
            this.defectTextBox.Name = "defectTextBox";
            this.defectTextBox.Size = new System.Drawing.Size(100, 20);
            this.defectTextBox.TabIndex = 10;
            // 
            // decRichTextBox
            // 
            this.decRichTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.decRichTextBox.Location = new System.Drawing.Point(133, 119);
            this.decRichTextBox.Name = "decRichTextBox";
            this.decRichTextBox.Size = new System.Drawing.Size(735, 29);
            this.decRichTextBox.TabIndex = 15;
            this.decRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(435, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Defect code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(26, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Defect image";
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ReviewTextBox.Location = new System.Drawing.Point(768, 80);
            this.ReviewTextBox.Multiline = true;
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReviewTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label9.Location = new System.Drawing.Point(26, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Comment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label4.Location = new System.Drawing.Point(647, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Suffer die Qty";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.frontButton);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.waferSurF);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 398);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label13.Location = new System.Drawing.Point(96, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(301, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "R:Residue M:Probe Mark  B: Bridge O:Others";
            // 
            // frontButton
            // 
            this.frontButton.Enabled = false;
            this.frontButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.frontButton.Location = new System.Drawing.Point(309, 299);
            this.frontButton.Name = "frontButton";
            this.frontButton.Size = new System.Drawing.Size(123, 23);
            this.frontButton.TabIndex = 31;
            this.frontButton.Text = "Front side";
            this.frontButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label12.Location = new System.Drawing.Point(96, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(490, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "A:Arching  S:Scratch  D:Discolor  F:Defocus  C:Corrosion  P:Particle ";
            // 
            // waferSurF
            // 
            this.waferSurF.Location = new System.Drawing.Point(248, 70);
            this.waferSurF.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.waferSurF.Name = "waferSurF";
            this.waferSurF.Size = new System.Drawing.Size(220, 220);
            this.waferSurF.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(151, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(439, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Pls mark the defect with below special code";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.radioButtonB);
            this.groupBox2.Controls.Add(this.radioButtonF);
            this.groupBox2.Controls.Add(this.slotComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lotTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 94);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AOI inspection simple MAP";
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(720, 54);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(71, 16);
            this.radioButtonB.TabIndex = 6;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "BackSide";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(607, 54);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(77, 16);
            this.radioButtonF.TabIndex = 5;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "FrontSide";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // slotComboBox
            // 
            this.slotComboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slotComboBox.FormattingEnabled = true;
            this.slotComboBox.Location = new System.Drawing.Point(411, 56);
            this.slotComboBox.Name = "slotComboBox";
            this.slotComboBox.Size = new System.Drawing.Size(121, 22);
            this.slotComboBox.TabIndex = 4;
            this.slotComboBox.SelectedIndexChanged += new System.EventHandler(this.slotComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label15.Location = new System.Drawing.Point(81, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 1;
            this.label15.Text = "Lot ID";
            // 
            // lotTextBox
            // 
            this.lotTextBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lotTextBox.Location = new System.Drawing.Point(157, 56);
            this.lotTextBox.Multiline = true;
            this.lotTextBox.Name = "lotTextBox";
            this.lotTextBox.Size = new System.Drawing.Size(100, 21);
            this.lotTextBox.TabIndex = 3;
            this.lotTextBox.TextChanged += new System.EventHandler(this.lotTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label16.Location = new System.Drawing.Point(348, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "Slot";
            // 
            // FrmAOIInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 851);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAOIInput";
            this.Text = "AOIInput";
            this.Load += new System.EventHandler(this.FrmAOIInput_Load);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox cmtRichTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox MagnificationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox defectTextBox;
        private System.Windows.Forms.RichTextBox decRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReviewTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button frontButton;
        private System.Windows.Forms.Label label12;
        private WaferSf.WaferSur waferSurF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox slotComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lotTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelPer;
        private System.Windows.Forms.Label labelX;
        private ImageUpload.ImageUpload imageUpload1;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonF;
    }
}