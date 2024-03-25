namespace Notepad__.Forms
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblNewestVersion = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(12, 101);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(131, 16);
            this.lblCurrentVersion.TabIndex = 0;
            this.lblCurrentVersion.Text = "Current Version: 1,4.2";
            // 
            // lblNewestVersion
            // 
            this.lblNewestVersion.AutoSize = true;
            this.lblNewestVersion.Location = new System.Drawing.Point(12, 121);
            this.lblNewestVersion.Name = "lblNewestVersion";
            this.lblNewestVersion.Size = new System.Drawing.Size(134, 16);
            this.lblNewestVersion.TabIndex = 0;
            this.lblNewestVersion.Text = "Newest Version: 1.4.2";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(12, 142);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(203, 16);
            this.lblLastUpdate.TabIndex = 0;
            this.lblLastUpdate.Text = "Last Update Release: 10.12.2024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notepad--";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 167);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.lblNewestVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblNewestVersion;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label label2;
    }
}