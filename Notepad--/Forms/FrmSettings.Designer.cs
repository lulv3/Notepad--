namespace Notepad__.Forms
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Language", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Font", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Colors", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Appearance", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Experimental", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Advanced", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.pnlTree = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTree
            // 
            this.pnlTree.Controls.Add(this.treeView);
            this.pnlTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTree.Location = new System.Drawing.Point(0, 0);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Size = new System.Drawing.Size(178, 460);
            this.pnlTree.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ForeColor = System.Drawing.Color.Black;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imgList;
            this.treeView.ItemHeight = 30;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "gLanguage";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Language";
            treeNode2.Checked = true;
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "kGeneral";
            treeNode2.SelectedImageKey = "Opened Folder.png";
            treeNode2.Text = "General";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "SFont";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Font";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "SColors";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Colors";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "SAppearance";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Appearance";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "sExperimental";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Experimental";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "SAdvanced";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Advanced";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode7});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(178, 460);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Folder.png");
            this.imgList.Images.SetKeyName(1, "Opened Folder.png");
            this.imgList.Images.SetKeyName(2, "Settings.png");
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(178, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(505, 460);
            this.pnlContent.TabIndex = 2;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 460);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTree);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.pnlTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imgList;
    }
}