﻿namespace OQAMain
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
            this.slotComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lotTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.cmtRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.decRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.frontButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.waferSurF = new WaferSf.WaferSur();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(797, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(578, 10);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(688, 10);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 920);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Size = new System.Drawing.Size(906, 50);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.slotComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lotTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(28, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(841, 118);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Macro inspection simple MAP";
            // 
            // slotComboBox
            // 
            this.slotComboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slotComboBox.FormattingEnabled = true;
            this.slotComboBox.Location = new System.Drawing.Point(479, 70);
            this.slotComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slotComboBox.Name = "slotComboBox";
            this.slotComboBox.Size = new System.Drawing.Size(140, 22);
            this.slotComboBox.TabIndex = 4;
            this.slotComboBox.SelectedIndexChanged += new System.EventHandler(this.slotComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label15.Location = new System.Drawing.Point(94, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 1;
            this.label15.Text = "Lot ID";
            // 
            // lotTextBox
            // 
            this.lotTextBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lotTextBox.Location = new System.Drawing.Point(183, 70);
            this.lotTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lotTextBox.Multiline = true;
            this.lotTextBox.Name = "lotTextBox";
            this.lotTextBox.Size = new System.Drawing.Size(116, 25);
            this.lotTextBox.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label16.Location = new System.Drawing.Point(406, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "Slot";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imageTextBox);
            this.groupBox3.Controls.Add(this.cmtRichTextBox);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.decRichTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(28, 672);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(841, 204);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.imageTextBox.Location = new System.Drawing.Point(166, 29);
            this.imageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageTextBox.Multiline = true;
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(116, 24);
            this.imageTextBox.TabIndex = 12;
            // 
            // cmtRichTextBox
            // 
            this.cmtRichTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.cmtRichTextBox.Location = new System.Drawing.Point(166, 144);
            this.cmtRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmtRichTextBox.Name = "cmtRichTextBox";
            this.cmtRichTextBox.Size = new System.Drawing.Size(663, 35);
            this.cmtRichTextBox.TabIndex = 16;
            this.cmtRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(289, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label8.Location = new System.Drawing.Point(41, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description";
            // 
            // decRichTextBox
            // 
            this.decRichTextBox.Font = new System.Drawing.Font("宋体", 10.5F);
            this.decRichTextBox.Location = new System.Drawing.Point(166, 78);
            this.decRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decRichTextBox.Name = "decRichTextBox";
            this.decRichTextBox.Size = new System.Drawing.Size(663, 35);
            this.decRichTextBox.TabIndex = 15;
            this.decRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(41, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Defect image";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label9.Location = new System.Drawing.Point(41, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Comment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.frontButton);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.waferSurF);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(28, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(841, 498);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label13.Location = new System.Drawing.Point(112, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(301, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "R:Residue M:Probe Mark  B: Bridge O:Others";
            // 
            // frontButton
            // 
            this.frontButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.frontButton.Location = new System.Drawing.Point(303, 361);
            this.frontButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frontButton.Name = "frontButton";
            this.frontButton.Size = new System.Drawing.Size(143, 29);
            this.frontButton.TabIndex = 31;
            this.frontButton.Text = "Front side";
            this.frontButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label12.Location = new System.Drawing.Point(112, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(490, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "A:Arching  S:Scratch  D:Discolor  F:Defocus  C:Corrosion  P:Particle ";
            // 
            // waferSurF
            // 
            this.waferSurF.Location = new System.Drawing.Point(252, 88);
            this.waferSurF.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.waferSurF.Name = "waferSurF";
            this.waferSurF.Size = new System.Drawing.Size(245, 262);
            this.waferSurF.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(176, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(439, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Pls mark the defect with below special code";
            // 
            // FrmMarcoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 970);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FrmMarcoInput";
            this.Load += new System.EventHandler(this.FrmMarcoInput_Load);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox slotComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lotTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.RichTextBox cmtRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox decRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button frontButton;
        private System.Windows.Forms.Label label12;
        private WaferSf.WaferSur waferSurF;
        private System.Windows.Forms.Label label14;
    }
}