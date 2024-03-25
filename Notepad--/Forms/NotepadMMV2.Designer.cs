namespace Notepad__.Forms
{
    partial class NotepadMMV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadMMV2));
            this.app_content = new System.Windows.Forms.Panel();
            this.txtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.msMenu = new PulsarUI.Controles.PulsarUIMenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUndone = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.msiReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguageCPP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguageCSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguagePython = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanuageDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiText = new System.Windows.Forms.ToolStripMenuItem();
            this.mmsiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.msiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.hilightUpdater = new System.Windows.Forms.Timer(this.components);
            this.acmImages = new System.Windows.Forms.ImageList(this.components);
            this.acMenu = new AutocompleteMenuNS.AutocompleteMenu();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            this.app_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // app_titlebar
            // 
            this.app_titlebar.Size = new System.Drawing.Size(989, 33);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(99, 22);
            this.lblTitle.Text = "Notepad--";
            // 
            // app_content
            // 
            this.app_content.Controls.Add(this.txtEditor);
            this.app_content.Controls.Add(this.msMenu);
            this.app_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app_content.Location = new System.Drawing.Point(0, 33);
            this.app_content.Name = "app_content";
            this.app_content.Size = new System.Drawing.Size(989, 497);
            this.app_content.TabIndex = 1;
            // 
            // txtEditor
            // 
            this.txtEditor.AutoCompleteBrackets = true;
            this.txtEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.acMenu.SetAutocompleteMenu(this.txtEditor, this.acMenu);
            this.txtEditor.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.txtEditor.BackBrush = null;
            this.txtEditor.BackColor = System.Drawing.Color.Transparent;
            this.txtEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtEditor.CharHeight = 18;
            this.txtEditor.CharWidth = 10;
            this.txtEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.IndentBackColor = System.Drawing.Color.Transparent;
            this.txtEditor.IsReplaceMode = false;
            this.txtEditor.LineNumberColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditor.Location = new System.Drawing.Point(0, 28);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.txtEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.txtEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtEditor.ServiceColors")));
            this.txtEditor.ShowCaretWhenInactive = true;
            this.txtEditor.ShowFoldingLines = true;
            this.txtEditor.Size = new System.Drawing.Size(989, 469);
            this.txtEditor.SourceTextBox = this.txtEditor;
            this.txtEditor.TabIndex = 4;
            this.txtEditor.TextAreaBorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditor.Zoom = 100;
            this.txtEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txtEditor_TextChanged);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.msiEdit,
            this.stmiSearch,
            this.cmsiSettings,
            this.mmsiHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(989, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "msMenu";
            // 
            // tsmiFile
            // 
            this.tsmiFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiNew,
            this.msiOpen,
            this.msiSave,
            this.msiExit});
            this.tsmiFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(46, 24);
            this.tsmiFile.Text = "File";
            // 
            // msiNew
            // 
            this.msiNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiNew.Image = global::Notepad__.Properties.Resources.Add_File;
            this.msiNew.Name = "msiNew";
            this.msiNew.Size = new System.Drawing.Size(177, 26);
            this.msiNew.Text = "New";
            this.msiNew.Click += new System.EventHandler(this.msiNew_Click);
            // 
            // msiOpen
            // 
            this.msiOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiOpen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiOpen.Image = global::Notepad__.Properties.Resources.Opened_Folder;
            this.msiOpen.Name = "msiOpen";
            this.msiOpen.Size = new System.Drawing.Size(177, 26);
            this.msiOpen.Text = "Open";
            this.msiOpen.Click += new System.EventHandler(this.msiOpen_Click);
            // 
            // msiSave
            // 
            this.msiSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiSave.Image = global::Notepad__.Properties.Resources.Save;
            this.msiSave.Name = "msiSave";
            this.msiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msiSave.Size = new System.Drawing.Size(177, 26);
            this.msiSave.Text = "Save";
            this.msiSave.ToolTipText = "Save";
            this.msiSave.Click += new System.EventHandler(this.msiSave_Click);
            // 
            // msiExit
            // 
            this.msiExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiExit.Image = global::Notepad__.Properties.Resources.Cancel;
            this.msiExit.Name = "msiExit";
            this.msiExit.Size = new System.Drawing.Size(177, 26);
            this.msiExit.Text = "Exit";
            this.msiExit.Click += new System.EventHandler(this.msiExit_Click);
            // 
            // msiEdit
            // 
            this.msiEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiUndone,
            this.msiRestore,
            this.msiCopy,
            this.msiCut,
            this.msiPaste,
            this.msiSelectAll});
            this.msiEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiEdit.Name = "msiEdit";
            this.msiEdit.Size = new System.Drawing.Size(49, 24);
            this.msiEdit.Text = "Edit";
            // 
            // msiUndone
            // 
            this.msiUndone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiUndone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiUndone.Image = global::Notepad__.Properties.Resources.Undo;
            this.msiUndone.Name = "msiUndone";
            this.msiUndone.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.msiUndone.Size = new System.Drawing.Size(208, 26);
            this.msiUndone.Text = "Undone";
            this.msiUndone.Click += new System.EventHandler(this.msiUndone_Click);
            // 
            // msiRestore
            // 
            this.msiRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiRestore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiRestore.Image = global::Notepad__.Properties.Resources.Replay;
            this.msiRestore.Name = "msiRestore";
            this.msiRestore.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.msiRestore.Size = new System.Drawing.Size(208, 26);
            this.msiRestore.Text = "Restore";
            this.msiRestore.Click += new System.EventHandler(this.msiRestore_Click);
            // 
            // msiCopy
            // 
            this.msiCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiCopy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiCopy.Image = global::Notepad__.Properties.Resources.Copy;
            this.msiCopy.Name = "msiCopy";
            this.msiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msiCopy.Size = new System.Drawing.Size(208, 26);
            this.msiCopy.Text = "Copy";
            this.msiCopy.Click += new System.EventHandler(this.msiCopy_Click);
            // 
            // msiCut
            // 
            this.msiCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiCut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiCut.Image = global::Notepad__.Properties.Resources.Cut;
            this.msiCut.Name = "msiCut";
            this.msiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msiCut.Size = new System.Drawing.Size(208, 26);
            this.msiCut.Text = "Cut";
            this.msiCut.Click += new System.EventHandler(this.msiCut_Click);
            // 
            // msiPaste
            // 
            this.msiPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiPaste.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiPaste.Image = global::Notepad__.Properties.Resources.Paste;
            this.msiPaste.Name = "msiPaste";
            this.msiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.msiPaste.Size = new System.Drawing.Size(208, 26);
            this.msiPaste.Text = "Paste";
            this.msiPaste.Click += new System.EventHandler(this.msiPaste_Click);
            // 
            // msiSelectAll
            // 
            this.msiSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiSelectAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiSelectAll.Image = global::Notepad__.Properties.Resources.Select_All;
            this.msiSelectAll.Name = "msiSelectAll";
            this.msiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.msiSelectAll.Size = new System.Drawing.Size(208, 26);
            this.msiSelectAll.Text = "Select all";
            this.msiSelectAll.Click += new System.EventHandler(this.msiSelectAll_Click);
            // 
            // stmiSearch
            // 
            this.stmiSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.stmiSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiSearch,
            this.msiReplace});
            this.stmiSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.stmiSearch.Name = "stmiSearch";
            this.stmiSearch.Size = new System.Drawing.Size(67, 24);
            this.stmiSearch.Text = "Search";
            // 
            // msiSearch
            // 
            this.msiSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiSearch.Image = global::Notepad__.Properties.Resources.Search;
            this.msiSearch.Name = "msiSearch";
            this.msiSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.msiSearch.Size = new System.Drawing.Size(211, 26);
            this.msiSearch.Text = "Search...";
            // 
            // msiReplace
            // 
            this.msiReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiReplace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiReplace.Image = global::Notepad__.Properties.Resources.Replace;
            this.msiReplace.Name = "msiReplace";
            this.msiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.msiReplace.Size = new System.Drawing.Size(211, 26);
            this.msiReplace.Text = "Replace...";
            // 
            // cmsiSettings
            // 
            this.cmsiSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.cmsiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiSettings,
            this.tsLanguage});
            this.cmsiSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmsiSettings.Name = "cmsiSettings";
            this.cmsiSettings.Size = new System.Drawing.Size(76, 24);
            this.cmsiSettings.Text = "Settings";
            // 
            // msiSettings
            // 
            this.msiSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiSettings.Image = global::Notepad__.Properties.Resources.Settings;
            this.msiSettings.Name = "msiSettings";
            this.msiSettings.Size = new System.Drawing.Size(157, 26);
            this.msiSettings.Text = "Settings";
            this.msiSettings.Click += new System.EventHandler(this.msiSettings_Click);
            // 
            // tsLanguage
            // 
            this.tsLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.tsLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLanguageCPP,
            this.tsmiLanguageCSharp,
            this.tsmiLanguagePython,
            this.tsmiLanuageDefault,
            this.tsmiText});
            this.tsLanguage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsLanguage.Image = global::Notepad__.Properties.Resources.Source_Code;
            this.tsLanguage.Name = "tsLanguage";
            this.tsLanguage.Size = new System.Drawing.Size(157, 26);
            this.tsLanguage.Text = "Language";
            this.tsLanguage.Visible = false;
            // 
            // tsmiLanguageCPP
            // 
            this.tsmiLanguageCPP.Image = global::Notepad__.Properties.Resources.C__;
            this.tsmiLanguageCPP.Name = "tsmiLanguageCPP";
            this.tsmiLanguageCPP.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanguageCPP.Text = "C++";
            // 
            // tsmiLanguageCSharp
            // 
            this.tsmiLanguageCSharp.Image = global::Notepad__.Properties.Resources.CSharp_Logo;
            this.tsmiLanguageCSharp.Name = "tsmiLanguageCSharp";
            this.tsmiLanguageCSharp.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanguageCSharp.Text = "C#";
            // 
            // tsmiLanguagePython
            // 
            this.tsmiLanguagePython.Image = global::Notepad__.Properties.Resources.Python;
            this.tsmiLanguagePython.Name = "tsmiLanguagePython";
            this.tsmiLanguagePython.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanguagePython.Text = "Python";
            // 
            // tsmiLanuageDefault
            // 
            this.tsmiLanuageDefault.Image = global::Notepad__.Properties.Resources.Source_Code;
            this.tsmiLanuageDefault.Name = "tsmiLanuageDefault";
            this.tsmiLanuageDefault.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanuageDefault.Text = "Default";
            // 
            // tsmiText
            // 
            this.tsmiText.Image = global::Notepad__.Properties.Resources.Text;
            this.tsmiText.Name = "tsmiText";
            this.tsmiText.Size = new System.Drawing.Size(141, 26);
            this.tsmiText.Text = "Text";
            // 
            // mmsiHelp
            // 
            this.mmsiHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.mmsiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiUpdate,
            this.msiInfo});
            this.mmsiHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mmsiHelp.Name = "mmsiHelp";
            this.mmsiHelp.Size = new System.Drawing.Size(55, 24);
            this.mmsiHelp.Text = "Help";
            // 
            // msiUpdate
            // 
            this.msiUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiUpdate.Image = global::Notepad__.Properties.Resources.Installing_Updates;
            this.msiUpdate.Name = "msiUpdate";
            this.msiUpdate.Size = new System.Drawing.Size(224, 26);
            this.msiUpdate.Text = "Update";
            this.msiUpdate.Click += new System.EventHandler(this.msiUpdate_Click);
            // 
            // msiInfo
            // 
            this.msiInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.msiInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msiInfo.Image = global::Notepad__.Properties.Resources.Info;
            this.msiInfo.Name = "msiInfo";
            this.msiInfo.Size = new System.Drawing.Size(224, 26);
            this.msiInfo.Text = "Info";
            this.msiInfo.Click += new System.EventHandler(this.msiInfo_Click);
            // 
            // updater
            // 
            this.updater.Enabled = true;
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // hilightUpdater
            // 
            this.hilightUpdater.Enabled = true;
            this.hilightUpdater.Interval = 5000;
            this.hilightUpdater.Tick += new System.EventHandler(this.hilightUpdater_Tick);
            // 
            // acmImages
            // 
            this.acmImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("acmImages.ImageStream")));
            this.acmImages.TransparentColor = System.Drawing.Color.Transparent;
            this.acmImages.Images.SetKeyName(0, "Code.png");
            this.acmImages.Images.SetKeyName(1, "Func.png");
            this.acmImages.Images.SetKeyName(2, "SFunc.png");
            // 
            // acMenu
            // 
            this.acMenu.AllowsTabKey = true;
            this.acMenu.AppearInterval = 20;
            this.acMenu.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("acMenu.Colors")));
            this.acMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.acMenu.ImageList = this.acmImages;
            this.acMenu.Items = new string[0];
            this.acMenu.MinFragmentLength = 1;
            this.acMenu.TargetControlWrapper = null;
            // 
            // NotepadMMV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 530);
            this.Controls.Add(this.app_content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotepadMMV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad--";
            this.Controls.SetChildIndex(this.app_titlebar, 0);
            this.Controls.SetChildIndex(this.app_content, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            this.app_content.ResumeLayout(false);
            this.app_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel app_content;
        private PulsarUI.Controles.PulsarUIMenuStrip msMenu;
        public FastColoredTextBoxNS.FastColoredTextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem msiNew;
        private System.Windows.Forms.ToolStripMenuItem msiOpen;
        private System.Windows.Forms.ToolStripMenuItem msiSave;
        private System.Windows.Forms.ToolStripMenuItem msiExit;
        private System.Windows.Forms.ToolStripMenuItem msiEdit;
        private System.Windows.Forms.ToolStripMenuItem msiUndone;
        private System.Windows.Forms.ToolStripMenuItem msiRestore;
        private System.Windows.Forms.ToolStripMenuItem msiCopy;
        private System.Windows.Forms.ToolStripMenuItem msiCut;
        private System.Windows.Forms.ToolStripMenuItem msiPaste;
        private System.Windows.Forms.ToolStripMenuItem msiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem stmiSearch;
        private System.Windows.Forms.ToolStripMenuItem msiSearch;
        private System.Windows.Forms.ToolStripMenuItem msiReplace;
        private System.Windows.Forms.ToolStripMenuItem cmsiSettings;
        private System.Windows.Forms.ToolStripMenuItem msiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguageCPP;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguageCSharp;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguagePython;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanuageDefault;
        private System.Windows.Forms.ToolStripMenuItem tsmiText;
        private System.Windows.Forms.ToolStripMenuItem mmsiHelp;
        private System.Windows.Forms.ToolStripMenuItem msiUpdate;
        private System.Windows.Forms.ToolStripMenuItem msiInfo;
        private System.Windows.Forms.Timer updater;
        private System.Windows.Forms.Timer hilightUpdater;
        private System.Windows.Forms.ImageList acmImages;
        public AutocompleteMenuNS.AutocompleteMenu acMenu;
    }
}