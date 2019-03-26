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
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.cboxSlotId = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.imageUpload1 = new ImageUpload.ImageUpload();
            this.waferSurF = new WaferSf.WaferSur();
            this.btnSide = new System.Windows.Forms.Button();
            this.rtboxCmt = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rtboxDsc = new System.Windows.Forms.RichTextBox();
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
            this.btnClose.Location = new System.Drawing.Point(685, 6);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.Location = new System.Drawing.Point(596, 6);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Enabled = false;
            this.btnEdite.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdite.Location = new System.Drawing.Point(596, 6);
            this.btnEdite.Visible = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.groupBox2.Controls.Add(this.rbtnB);
            this.groupBox2.Controls.Add(this.rbtnF);
            this.groupBox2.Controls.Add(this.cboxSlotId);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtLotId);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 50);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Macro inspection simple MAP";
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnB.Location = new System.Drawing.Point(408, 22);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(71, 16);
            this.rbtnB.TabIndex = 8;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "BackSide";
            this.rbtnB.UseVisualStyleBackColor = true;
            this.rbtnB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnF.Location = new System.Drawing.Point(325, 22);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(77, 16);
            this.rbtnF.TabIndex = 7;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "FrontSide";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // cboxSlotId
            // 
            this.cboxSlotId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxSlotId.FormattingEnabled = true;
            this.cboxSlotId.Location = new System.Drawing.Point(214, 20);
            this.cboxSlotId.Name = "cboxSlotId";
            this.cboxSlotId.Size = new System.Drawing.Size(100, 20);
            this.cboxSlotId.TabIndex = 4;
            this.cboxSlotId.SelectedIndexChanged += new System.EventHandler(this.slotComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(11, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "Lot ID";
            // 
            // txtLotId
            // 
            this.txtLotId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLotId.Location = new System.Drawing.Point(55, 20);
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(100, 21);
            this.txtLotId.TabIndex = 3;
            this.txtLotId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLotId_KeyPress);
            this.txtLotId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLotId_MouseDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(166, 24);
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
            this.groupBox3.Controls.Add(this.btnSide);
            this.groupBox3.Controls.Add(this.rtboxCmt);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.rtboxDsc);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 700);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(287, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(257, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "R:Residue M:Probe Mark  B: Bridge O:Others";
            // 
            // imageUpload1
            // 
            this.imageUpload1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imageUpload1.Location = new System.Drawing.Point(364, 250);
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
            this.waferSurF.Location = new System.Drawing.Point(38, 81);
            this.waferSurF.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.waferSurF.Name = "waferSurF";
            this.waferSurF.Size = new System.Drawing.Size(220, 220);
            this.waferSurF.TabIndex = 27;
            // 
            // btnSide
            // 
            this.btnSide.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSide.Location = new System.Drawing.Point(90, 310);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(123, 23);
            this.btnSide.TabIndex = 31;
            this.btnSide.Text = "Front side";
            this.btnSide.UseVisualStyleBackColor = true;
            // 
            // rtboxCmt
            // 
            this.rtboxCmt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtboxCmt.Location = new System.Drawing.Point(403, 224);
            this.rtboxCmt.Name = "rtboxCmt";
            this.rtboxCmt.Size = new System.Drawing.Size(300, 29);
            this.rtboxCmt.TabIndex = 16;
            this.rtboxCmt.Text = "";
            this.rtboxCmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmtRichTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(20, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "Pls mark the defect with below special code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(285, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(287, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "A:Arching  S:Scratch  D:Discolor  F:Defocus  C:Corrosion  P:Particle ";
            // 
            // rtboxDsc
            // 
            this.rtboxDsc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtboxDsc.Location = new System.Drawing.Point(403, 192);
            this.rtboxDsc.Name = "rtboxDsc";
            this.rtboxDsc.Size = new System.Drawing.Size(300, 29);
            this.rtboxDsc.TabIndex = 15;
            this.rtboxDsc.Text = "";
            this.rtboxDsc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decRichTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(286, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Defect image";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(287, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Comment";
            // 
            // FrmMarcoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 700);
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
        private System.Windows.Forms.ComboBox cboxSlotId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtboxCmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtboxDsc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private ImageUpload.ImageUpload imageUpload1;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.Label label13;
        private WaferSf.WaferSur waferSurF;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}