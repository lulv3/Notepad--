namespace Notepad__.Forms.UserWidgets
{
    partial class SExperimental
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbAutoCode = new System.Windows.Forms.CheckBox();
            this.cbAutoChar = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbLivePreview = new System.Windows.Forms.CheckBox();
            this.cbAutoCheckUpdates = new System.Windows.Forms.CheckBox();
            this.cbNodepadv2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Experimental";
            // 
            // cbAutoCode
            // 
            this.cbAutoCode.AutoSize = true;
            this.cbAutoCode.Location = new System.Drawing.Point(26, 123);
            this.cbAutoCode.Name = "cbAutoCode";
            this.cbAutoCode.Size = new System.Drawing.Size(152, 23);
            this.cbAutoCode.TabIndex = 1;
            this.cbAutoCode.Text = "AutoCodeComplete";
            this.cbAutoCode.UseVisualStyleBackColor = true;
            this.cbAutoCode.CheckedChanged += new System.EventHandler(this.cbAutoCode_CheckedChanged);
            // 
            // cbAutoChar
            // 
            this.cbAutoChar.AutoSize = true;
            this.cbAutoChar.Location = new System.Drawing.Point(26, 152);
            this.cbAutoChar.Name = "cbAutoChar";
            this.cbAutoChar.Size = new System.Drawing.Size(90, 23);
            this.cbAutoChar.TabIndex = 2;
            this.cbAutoChar.Text = "AutoChar";
            this.cbAutoChar.UseVisualStyleBackColor = true;
            this.cbAutoChar.CheckedChanged += new System.EventHandler(this.cbAutoChar_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbLivePreview
            // 
            this.cbLivePreview.AutoSize = true;
            this.cbLivePreview.Location = new System.Drawing.Point(26, 181);
            this.cbLivePreview.Name = "cbLivePreview";
            this.cbLivePreview.Size = new System.Drawing.Size(190, 23);
            this.cbLivePreview.TabIndex = 2;
            this.cbLivePreview.Text = "LivePreview (HTML ONLY)";
            this.cbLivePreview.UseVisualStyleBackColor = true;
            this.cbLivePreview.CheckedChanged += new System.EventHandler(this.cbLivePreview_CheckedChanged);
            // 
            // cbAutoCheckUpdates
            // 
            this.cbAutoCheckUpdates.AutoSize = true;
            this.cbAutoCheckUpdates.Location = new System.Drawing.Point(26, 263);
            this.cbAutoCheckUpdates.Name = "cbAutoCheckUpdates";
            this.cbAutoCheckUpdates.Size = new System.Drawing.Size(169, 23);
            this.cbAutoCheckUpdates.TabIndex = 1;
            this.cbAutoCheckUpdates.Text = "AutoCheckForUpdates";
            this.cbAutoCheckUpdates.UseVisualStyleBackColor = true;
            this.cbAutoCheckUpdates.CheckedChanged += new System.EventHandler(this.cbAutoCheckUpdates_CheckedChanged);
            // 
            // cbNodepadv2
            // 
            this.cbNodepadv2.AutoSize = true;
            this.cbNodepadv2.Location = new System.Drawing.Point(26, 334);
            this.cbNodepadv2.Name = "cbNodepadv2";
            this.cbNodepadv2.Size = new System.Drawing.Size(128, 23);
            this.cbNodepadv2.TabIndex = 1;
            this.cbNodepadv2.Text = "Use NotepadV2";
            this.cbNodepadv2.UseVisualStyleBackColor = true;
            this.cbNodepadv2.CheckedChanged += new System.EventHandler(this.cbNotepadV2_CheckedChanged);
            // 
            // SExperimental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbLivePreview);
            this.Controls.Add(this.cbAutoChar);
            this.Controls.Add(this.cbNodepadv2);
            this.Controls.Add(this.cbAutoCheckUpdates);
            this.Controls.Add(this.cbAutoCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SExperimental";
            this.Size = new System.Drawing.Size(505, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAutoCode;
        private System.Windows.Forms.CheckBox cbAutoChar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbLivePreview;
        private System.Windows.Forms.CheckBox cbAutoCheckUpdates;
        private System.Windows.Forms.CheckBox cbNodepadv2;
    }
}
