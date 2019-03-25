namespace OQA_Core
{
    partial class OQABaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OQABaseForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSucessMsg = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.lblSucessMsg);
            this.pnlMenu.Controls.Add(this.btnRefresh);
            this.pnlMenu.Controls.Add(this.btnCreate);
            this.pnlMenu.Controls.Add(this.btnEdite);
            this.pnlMenu.Controls.Add(this.btnClose);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenu.Location = new System.Drawing.Point(0, 660);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(780, 40);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblSucessMsg
            // 
            this.lblSucessMsg.AutoSize = true;
            this.lblSucessMsg.Location = new System.Drawing.Point(35, 14);
            this.lblSucessMsg.Name = "lblSucessMsg";
            this.lblSucessMsg.Size = new System.Drawing.Size(107, 12);
            this.lblSucessMsg.TabIndex = 6;
            this.lblSucessMsg.Text = "                 ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(5, 8);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreate.Location = new System.Drawing.Point(483, 6);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 26);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Save";
            // 
            // btnEdite
            // 
            this.btnEdite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdite.Location = new System.Drawing.Point(577, 6);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(88, 26);
            this.btnEdite.TabIndex = 2;
            this.btnEdite.Text = "Submit";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(671, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OQABaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 700);
            this.Controls.Add(this.pnlMenu);
            this.Name = "OQABaseForm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnCreate;
        protected System.Windows.Forms.Button btnEdite;
        protected System.Windows.Forms.Panel pnlMenu;
        protected System.Windows.Forms.Button btnRefresh;
        protected System.Windows.Forms.Label lblSucessMsg;
    }
}