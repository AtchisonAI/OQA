namespace OQA_Core.Controls
{
    partial class PictureView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tool_panel = new System.Windows.Forms.Panel();
            this.picname_panel = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.path_label = new System.Windows.Forms.Label();
            this.picture_panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lspin_button = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.enlarge_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.reduce_button = new System.Windows.Forms.Button();
            this.rspin_button = new System.Windows.Forms.Button();
            this.zoom_button = new System.Windows.Forms.Button();
            this.tool_panel.SuspendLayout();
            this.picname_panel.SuspendLayout();
            this.picture_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.lspin_button);
            this.tool_panel.Controls.Add(this.print_button);
            this.tool_panel.Controls.Add(this.enlarge_button);
            this.tool_panel.Controls.Add(this.save_button);
            this.tool_panel.Controls.Add(this.reduce_button);
            this.tool_panel.Controls.Add(this.rspin_button);
            this.tool_panel.Controls.Add(this.zoom_button);
            this.tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_panel.Location = new System.Drawing.Point(0, 0);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(510, 37);
            this.tool_panel.TabIndex = 8;
            // 
            // picname_panel
            // 
            this.picname_panel.Controls.Add(this.name_label);
            this.picname_panel.Controls.Add(this.path_label);
            this.picname_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picname_panel.Location = new System.Drawing.Point(0, 402);
            this.picname_panel.Name = "picname_panel";
            this.picname_panel.Size = new System.Drawing.Size(510, 19);
            this.picname_panel.TabIndex = 9;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(58, 2);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 12);
            this.name_label.TabIndex = 1;
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Location = new System.Drawing.Point(3, 2);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(53, 12);
            this.path_label.TabIndex = 0;
            this.path_label.Text = "Picture:";
            // 
            // picture_panel
            // 
            this.picture_panel.Controls.Add(this.pictureBox);
            this.picture_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_panel.Location = new System.Drawing.Point(0, 37);
            this.picture_panel.Name = "picture_panel";
            this.picture_panel.Size = new System.Drawing.Size(510, 365);
            this.picture_panel.TabIndex = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(504, 359);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox_LoadCompleted);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // lspin_button
            // 
            this.lspin_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lspin_button.BackColor = System.Drawing.Color.Transparent;
            this.lspin_button.BackgroundImage = global::OQA_Core.Properties.Resources.arrow_rotate_clockwise;
            this.lspin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lspin_button.FlatAppearance.BorderSize = 0;
            this.lspin_button.Location = new System.Drawing.Point(290, 3);
            this.lspin_button.Name = "lspin_button";
            this.lspin_button.Size = new System.Drawing.Size(32, 32);
            this.lspin_button.TabIndex = 4;
            this.lspin_button.UseVisualStyleBackColor = false;
            this.lspin_button.Click += new System.EventHandler(this.lspin_button_Click);
            // 
            // print_button
            // 
            this.print_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_button.BackColor = System.Drawing.Color.Transparent;
            this.print_button.BackgroundImage = global::OQA_Core.Properties.Resources.scanner_working;
            this.print_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.print_button.Location = new System.Drawing.Point(474, 3);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(32, 32);
            this.print_button.TabIndex = 7;
            this.print_button.UseVisualStyleBackColor = false;
            this.print_button.Visible = false;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // enlarge_button
            // 
            this.enlarge_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enlarge_button.BackColor = System.Drawing.Color.Transparent;
            this.enlarge_button.BackgroundImage = global::OQA_Core.Properties.Resources.zoom_in1;
            this.enlarge_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enlarge_button.FlatAppearance.BorderSize = 0;
            this.enlarge_button.ForeColor = System.Drawing.Color.Transparent;
            this.enlarge_button.Location = new System.Drawing.Point(149, 3);
            this.enlarge_button.Name = "enlarge_button";
            this.enlarge_button.Size = new System.Drawing.Size(32, 32);
            this.enlarge_button.TabIndex = 1;
            this.enlarge_button.UseVisualStyleBackColor = false;
            this.enlarge_button.Click += new System.EventHandler(this.enlarge_button_Click);
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.BackgroundImage = global::OQA_Core.Properties.Resources.saved_imports;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_button.Location = new System.Drawing.Point(424, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(32, 32);
            this.save_button.TabIndex = 6;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // reduce_button
            // 
            this.reduce_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reduce_button.BackColor = System.Drawing.Color.Transparent;
            this.reduce_button.BackgroundImage = global::OQA_Core.Properties.Resources.zoom_out;
            this.reduce_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reduce_button.FlatAppearance.BorderSize = 0;
            this.reduce_button.Location = new System.Drawing.Point(196, 3);
            this.reduce_button.Name = "reduce_button";
            this.reduce_button.Size = new System.Drawing.Size(32, 32);
            this.reduce_button.TabIndex = 2;
            this.reduce_button.UseVisualStyleBackColor = false;
            this.reduce_button.Click += new System.EventHandler(this.reduce_button_Click);
            // 
            // rspin_button
            // 
            this.rspin_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rspin_button.BackColor = System.Drawing.Color.Transparent;
            this.rspin_button.BackgroundImage = global::OQA_Core.Properties.Resources.arrow_rotate_anticlockwise;
            this.rspin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rspin_button.FlatAppearance.BorderSize = 0;
            this.rspin_button.Location = new System.Drawing.Point(337, 3);
            this.rspin_button.Name = "rspin_button";
            this.rspin_button.Size = new System.Drawing.Size(32, 32);
            this.rspin_button.TabIndex = 5;
            this.rspin_button.UseVisualStyleBackColor = false;
            this.rspin_button.Click += new System.EventHandler(this.rspin_button_Click);
            // 
            // zoom_button
            // 
            this.zoom_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoom_button.BackColor = System.Drawing.Color.Transparent;
            this.zoom_button.BackgroundImage = global::OQA_Core.Properties.Resources.zone_resize_actual;
            this.zoom_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoom_button.FlatAppearance.BorderSize = 0;
            this.zoom_button.Location = new System.Drawing.Point(243, 3);
            this.zoom_button.Name = "zoom_button";
            this.zoom_button.Size = new System.Drawing.Size(32, 32);
            this.zoom_button.TabIndex = 3;
            this.zoom_button.UseVisualStyleBackColor = false;
            this.zoom_button.Click += new System.EventHandler(this.zoom_button_Click);
            // 
            // PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picture_panel);
            this.Controls.Add(this.picname_panel);
            this.Controls.Add(this.tool_panel);
            this.Name = "PictureView";
            this.Size = new System.Drawing.Size(510, 421);
            this.tool_panel.ResumeLayout(false);
            this.picname_panel.ResumeLayout(false);
            this.picname_panel.PerformLayout();
            this.picture_panel.ResumeLayout(false);
            this.picture_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button enlarge_button;
        private System.Windows.Forms.Button reduce_button;
        private System.Windows.Forms.Button zoom_button;
        private System.Windows.Forms.Button lspin_button;
        private System.Windows.Forms.Button rspin_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.Panel picname_panel;
        private System.Windows.Forms.Panel picture_panel;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label path_label;
    }
}
