namespace Notepad__.Forms
{
    partial class NotepadMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadMM));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUndone = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.msiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsiSave = new System.Windows.Forms.ToolStripButton();
            this.tsbLivePreview = new System.Windows.Forms.ToolStripButton();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.livePreviewUpdater = new System.Windows.Forms.Timer(this.components);
            this.acMenu = new AutocompleteMenuNS.AutocompleteMenu();
            this.acmImages = new System.Windows.Forms.ImageList(this.components);
            this.txtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.hilightUpdater = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.tsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.msiEdit,
            this.stmiSearch,
            this.cmsiSettings,
            this.mmsiHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(852, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "msMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiNew,
            this.msiOpen,
            this.msiSave,
            this.toolStripSeparator1,
            this.msiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // msiNew
            // 
            this.msiNew.Image = global::Notepad__.Properties.Resources.Add_File;
            this.msiNew.Name = "msiNew";
            this.msiNew.Size = new System.Drawing.Size(224, 26);
            this.msiNew.Text = "New";
            this.msiNew.Click += new System.EventHandler(this.msiNew_Click);
            // 
            // msiOpen
            // 
            this.msiOpen.Image = global::Notepad__.Properties.Resources.Opened_Folder;
            this.msiOpen.Name = "msiOpen";
            this.msiOpen.Size = new System.Drawing.Size(224, 26);
            this.msiOpen.Text = "Open";
            this.msiOpen.Click += new System.EventHandler(this.msiOpen_Click);
            // 
            // msiSave
            // 
            this.msiSave.Image = global::Notepad__.Properties.Resources.Save;
            this.msiSave.Name = "msiSave";
            this.msiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msiSave.Size = new System.Drawing.Size(224, 26);
            this.msiSave.Text = "Save";
            this.msiSave.ToolTipText = "Save";
            this.msiSave.Click += new System.EventHandler(this.msiSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // msiExit
            // 
            this.msiExit.Image = global::Notepad__.Properties.Resources.Cancel;
            this.msiExit.Name = "msiExit";
            this.msiExit.Size = new System.Drawing.Size(224, 26);
            this.msiExit.Text = "Exit";
            this.msiExit.Click += new System.EventHandler(this.msiExit_Click);
            // 
            // msiEdit
            // 
            this.msiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiUndone,
            this.msiRestore,
            this.msiSeperator2,
            this.msiCopy,
            this.msiCut,
            this.msiPaste,
            this.toolStripSeparator2,
            this.msiSelectAll});
            this.msiEdit.Name = "msiEdit";
            this.msiEdit.Size = new System.Drawing.Size(49, 24);
            this.msiEdit.Text = "Edit";
            // 
            // msiUndone
            // 
            this.msiUndone.Image = global::Notepad__.Properties.Resources.Undo;
            this.msiUndone.Name = "msiUndone";
            this.msiUndone.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.msiUndone.Size = new System.Drawing.Size(224, 26);
            this.msiUndone.Text = "Undone";
            this.msiUndone.Click += new System.EventHandler(this.msiUndone_Click);
            // 
            // msiRestore
            // 
            this.msiRestore.Image = global::Notepad__.Properties.Resources.Replay;
            this.msiRestore.Name = "msiRestore";
            this.msiRestore.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.msiRestore.Size = new System.Drawing.Size(224, 26);
            this.msiRestore.Text = "Restore";
            this.msiRestore.Click += new System.EventHandler(this.msiRestore_Click);
            // 
            // msiSeperator2
            // 
            this.msiSeperator2.Name = "msiSeperator2";
            this.msiSeperator2.Size = new System.Drawing.Size(221, 6);
            // 
            // msiCopy
            // 
            this.msiCopy.Image = global::Notepad__.Properties.Resources.Copy;
            this.msiCopy.Name = "msiCopy";
            this.msiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msiCopy.Size = new System.Drawing.Size(224, 26);
            this.msiCopy.Text = "Copy";
            this.msiCopy.Click += new System.EventHandler(this.msiCopy_Click);
            // 
            // msiCut
            // 
            this.msiCut.Image = global::Notepad__.Properties.Resources.Cut;
            this.msiCut.Name = "msiCut";
            this.msiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msiCut.Size = new System.Drawing.Size(224, 26);
            this.msiCut.Text = "Cut";
            this.msiCut.Click += new System.EventHandler(this.msiCut_Click);
            // 
            // msiPaste
            // 
            this.msiPaste.Image = global::Notepad__.Properties.Resources.Paste;
            this.msiPaste.Name = "msiPaste";
            this.msiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.msiPaste.Size = new System.Drawing.Size(224, 26);
            this.msiPaste.Text = "Paste";
            this.msiPaste.Click += new System.EventHandler(this.msiPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // msiSelectAll
            // 
            this.msiSelectAll.Image = global::Notepad__.Properties.Resources.Select_All;
            this.msiSelectAll.Name = "msiSelectAll";
            this.msiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.msiSelectAll.Size = new System.Drawing.Size(224, 26);
            this.msiSelectAll.Text = "Select all";
            this.msiSelectAll.Click += new System.EventHandler(this.msiSelectAll_Click);
            // 
            // stmiSearch
            // 
            this.stmiSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiSearch,
            this.msiReplace});
            this.stmiSearch.Name = "stmiSearch";
            this.stmiSearch.Size = new System.Drawing.Size(67, 24);
            this.stmiSearch.Text = "Search";
            // 
            // msiSearch
            // 
            this.msiSearch.Image = global::Notepad__.Properties.Resources.Search;
            this.msiSearch.Name = "msiSearch";
            this.msiSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.msiSearch.Size = new System.Drawing.Size(224, 26);
            this.msiSearch.Text = "Search...";
            this.msiSearch.Click += new System.EventHandler(this.msiSearch_Click);
            // 
            // msiReplace
            // 
            this.msiReplace.Image = global::Notepad__.Properties.Resources.Replace;
            this.msiReplace.Name = "msiReplace";
            this.msiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.msiReplace.Size = new System.Drawing.Size(224, 26);
            this.msiReplace.Text = "Replace...";
            this.msiReplace.Click += new System.EventHandler(this.msiReplace_Click);
            // 
            // cmsiSettings
            // 
            this.cmsiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiSettings,
            this.tsLanguage});
            this.cmsiSettings.Name = "cmsiSettings";
            this.cmsiSettings.Size = new System.Drawing.Size(76, 24);
            this.cmsiSettings.Text = "Settings";
            // 
            // msiSettings
            // 
            this.msiSettings.Image = global::Notepad__.Properties.Resources.Settings;
            this.msiSettings.Name = "msiSettings";
            this.msiSettings.Size = new System.Drawing.Size(224, 26);
            this.msiSettings.Text = "Settings";
            this.msiSettings.Click += new System.EventHandler(this.msiSettings_Click);
            // 
            // tsLanguage
            // 
            this.tsLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLanguageCPP,
            this.tsmiLanguageCSharp,
            this.tsmiLanguagePython,
            this.tsmiLanuageDefault,
            this.tsmiText});
            this.tsLanguage.Image = global::Notepad__.Properties.Resources.Source_Code;
            this.tsLanguage.Name = "tsLanguage";
            this.tsLanguage.Size = new System.Drawing.Size(224, 26);
            this.tsLanguage.Text = "Language";
            this.tsLanguage.Visible = false;
            // 
            // tsmiLanguageCPP
            // 
            this.tsmiLanguageCPP.Image = global::Notepad__.Properties.Resources.C__;
            this.tsmiLanguageCPP.Name = "tsmiLanguageCPP";
            this.tsmiLanguageCPP.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanguageCPP.Text = "C++";
            this.tsmiLanguageCPP.Click += new System.EventHandler(this.tsmiLanguageCPP_Click);
            // 
            // tsmiLanguageCSharp
            // 
            this.tsmiLanguageCSharp.Image = global::Notepad__.Properties.Resources.CSharp_Logo;
            this.tsmiLanguageCSharp.Name = "tsmiLanguageCSharp";
            this.tsmiLanguageCSharp.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanguageCSharp.Text = "C#";
            this.tsmiLanguageCSharp.Click += new System.EventHandler(this.tsmiLanguageCSharp_Click);
            // 
            // tsmiLanguagePython
            // 
            this.tsmiLanguagePython.Image = global::Notepad__.Properties.Resources.Python;
            this.tsmiLanguagePython.Name = "tsmiLanguagePython";
            this.tsmiLanguagePython.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanguagePython.Text = "Python";
            this.tsmiLanguagePython.Click += new System.EventHandler(this.tsmiLanguagePython_Click);
            // 
            // tsmiLanuageDefault
            // 
            this.tsmiLanuageDefault.Image = global::Notepad__.Properties.Resources.Source_Code;
            this.tsmiLanuageDefault.Name = "tsmiLanuageDefault";
            this.tsmiLanuageDefault.Size = new System.Drawing.Size(141, 26);
            this.tsmiLanuageDefault.Text = "Default";
            this.tsmiLanuageDefault.Click += new System.EventHandler(this.tsmiLanuageDefault_Click);
            // 
            // tsmiText
            // 
            this.tsmiText.Image = global::Notepad__.Properties.Resources.Text;
            this.tsmiText.Name = "tsmiText";
            this.tsmiText.Size = new System.Drawing.Size(141, 26);
            this.tsmiText.Text = "Text";
            this.tsmiText.Click += new System.EventHandler(this.tsmiText_Click);
            // 
            // mmsiHelp
            // 
            this.mmsiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiUpdate,
            this.msiInfo});
            this.mmsiHelp.Name = "mmsiHelp";
            this.mmsiHelp.Size = new System.Drawing.Size(55, 24);
            this.mmsiHelp.Text = "Help";
            // 
            // msiUpdate
            // 
            this.msiUpdate.Image = global::Notepad__.Properties.Resources.Installing_Updates;
            this.msiUpdate.Name = "msiUpdate";
            this.msiUpdate.Size = new System.Drawing.Size(224, 26);
            this.msiUpdate.Text = "Update";
            this.msiUpdate.Click += new System.EventHandler(this.msiUpdate_Click);
            // 
            // msiInfo
            // 
            this.msiInfo.Image = global::Notepad__.Properties.Resources.Info;
            this.msiInfo.Name = "msiInfo";
            this.msiInfo.Size = new System.Drawing.Size(224, 26);
            this.msiInfo.Text = "Info";
            this.msiInfo.Click += new System.EventHandler(this.msiInfo_Click);
            // 
            // tsTools
            // 
            this.tsTools.BackColor = System.Drawing.Color.White;
            this.tsTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsTools.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiSave,
            this.tsbLivePreview});
            this.tsTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsTools.Location = new System.Drawing.Point(0, 28);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(852, 27);
            this.tsTools.TabIndex = 1;
            this.tsTools.Text = "Tools";
            // 
            // tsiSave
            // 
            this.tsiSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiSave.Image = global::Notepad__.Properties.Resources.Save;
            this.tsiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiSave.Name = "tsiSave";
            this.tsiSave.Size = new System.Drawing.Size(29, 24);
            this.tsiSave.Text = "Save";
            this.tsiSave.Click += new System.EventHandler(this.tsiSave_Click);
            // 
            // tsbLivePreview
            // 
            this.tsbLivePreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLivePreview.Image = global::Notepad__.Properties.Resources.Live;
            this.tsbLivePreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLivePreview.Name = "tsbLivePreview";
            this.tsbLivePreview.Size = new System.Drawing.Size(29, 24);
            this.tsbLivePreview.Text = "Live Preview";
            this.tsbLivePreview.Click += new System.EventHandler(this.tsbLivePreview_Click);
            // 
            // updater
            // 
            this.updater.Enabled = true;
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // livePreviewUpdater
            // 
            this.livePreviewUpdater.Interval = 500;
            this.livePreviewUpdater.Tick += new System.EventHandler(this.livePreviewUpdater_Tick);
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
            // acmImages
            // 
            this.acmImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("acmImages.ImageStream")));
            this.acmImages.TransparentColor = System.Drawing.Color.Transparent;
            this.acmImages.Images.SetKeyName(0, "Code.png");
            this.acmImages.Images.SetKeyName(1, "Func.png");
            this.acmImages.Images.SetKeyName(2, "SFunc.png");
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
            this.txtEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtEditor.CharHeight = 18;
            this.txtEditor.CharWidth = 10;
            this.txtEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.IsReplaceMode = false;
            this.txtEditor.Location = new System.Drawing.Point(0, 55);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.txtEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtEditor.ServiceColors")));
            this.txtEditor.ShowCaretWhenInactive = true;
            this.txtEditor.ShowFoldingLines = true;
            this.txtEditor.Size = new System.Drawing.Size(852, 425);
            this.txtEditor.SourceTextBox = this.txtEditor;
            this.txtEditor.TabIndex = 3;
            this.txtEditor.Zoom = 100;
            // 
            // hilightUpdater
            // 
            this.hilightUpdater.Enabled = true;
            this.hilightUpdater.Interval = 5000;
            this.hilightUpdater.Tick += new System.EventHandler(this.hilightUpdater_Tick);
            // 
            // NotepadMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(852, 480);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NotepadMM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad--";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotepadMM_FormClosing);
            this.Load += new System.EventHandler(this.NotepadMM_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiNew;
        private System.Windows.Forms.ToolStripMenuItem msiOpen;
        private System.Windows.Forms.ToolStripMenuItem msiSave;
        private System.Windows.Forms.ToolStripMenuItem msiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsiSave;
        private System.Windows.Forms.Timer updater;
        private System.Windows.Forms.ToolStripMenuItem msiEdit;
        private System.Windows.Forms.ToolStripMenuItem msiUndone;
        private System.Windows.Forms.ToolStripMenuItem msiRestore;
        private System.Windows.Forms.ToolStripSeparator msiSeperator2;
        private System.Windows.Forms.ToolStripMenuItem msiCopy;
        private System.Windows.Forms.ToolStripMenuItem msiCut;
        private System.Windows.Forms.ToolStripMenuItem msiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem msiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem stmiSearch;
        private System.Windows.Forms.ToolStripMenuItem msiSearch;
        private System.Windows.Forms.ToolStripMenuItem msiReplace;
        private System.Windows.Forms.ToolStripMenuItem cmsiSettings;
        private System.Windows.Forms.ToolStripMenuItem msiSettings;
        private System.Windows.Forms.ToolStripMenuItem mmsiHelp;
        private System.Windows.Forms.ToolStripMenuItem msiUpdate;
        private System.Windows.Forms.ToolStripButton tsbLivePreview;
        private System.Windows.Forms.Timer livePreviewUpdater;
        public AutocompleteMenuNS.AutocompleteMenu acMenu;
        private System.Windows.Forms.ImageList acmImages;
        private System.Windows.Forms.Timer hilightUpdater;
        private System.Windows.Forms.ToolStripMenuItem msiInfo;
        public FastColoredTextBoxNS.FastColoredTextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem tsLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguageCPP;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguageCSharp;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguagePython;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanuageDefault;
        private System.Windows.Forms.ToolStripMenuItem tsmiText;
    }
}