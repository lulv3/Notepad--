namespace Notepad__.Forms
{
    partial class FrmLivePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivePreview));
            this.wbLivePreview = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbLivePreview
            // 
            this.wbLivePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbLivePreview.Location = new System.Drawing.Point(0, 0);
            this.wbLivePreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLivePreview.Name = "wbLivePreview";
            this.wbLivePreview.Size = new System.Drawing.Size(800, 450);
            this.wbLivePreview.TabIndex = 0;
            // 
            // FrmLivePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.wbLivePreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLivePreview";
            this.Text = "LivePreview [EXPERIMENTAL]";
            this.Load += new System.EventHandler(this.FrmLivePreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser wbLivePreview;
    }
}