namespace WcfClient
{
    partial class ShortcutForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("登出");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("系统", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("员工");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("快捷菜单", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Logout_node";
            treeNode1.Text = "登出";
            treeNode2.Name = "System_node";
            treeNode2.Text = "系统";
            treeNode3.Name = "Emp_node";
            treeNode3.Text = "员工";
            treeNode4.Name = "Root_node";
            treeNode4.Text = "快捷菜单";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView.Size = new System.Drawing.Size(193, 425);
            this.treeView.TabIndex = 0;
            // 
            // ShortcutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 425);
            this.Controls.Add(this.treeView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortcutForm";
            this.Text = "快捷菜单";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
    }
}