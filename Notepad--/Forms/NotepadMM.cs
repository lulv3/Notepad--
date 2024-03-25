using Notepad__.Klassen;
using Notepad__.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection;
using AutoUpdate.Klassen;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;
using Notepad__.Klassen.Lexer;

namespace Notepad__.Forms
{
    public partial class NotepadMM : Form
    {
        #region Var

        #region ColorTemplates

        #region Dark

        // Editor
        Color darkBackColor = Color.FromArgb(16, 19, 25);
        Color darkForeColor = Color.White;
        Color darkIndentBackColor = Color.FromArgb(16, 19, 25);
        Color darkLineNumberColor = Color.FromArgb(68, 90, 120);
        Color darkCaretColor = Color.Transparent;
        Color darkServiceLinesColor = Color.FromArgb(40, 40, 40);
        Color darkSelectionColor = Color.FromArgb(103, 107, 119);


        #endregion

        #endregion

        private FileHandler fileHandler;
        private AutoCompleteTool autoCompleteTool = new AutoCompleteTool();
        DefaultLexer defaultLexer;
        UpdaterSystem updaterSystem;
        FrmLivePreview livePreviewWindow = new FrmLivePreview();
        ThemeController themes = new ThemeController();

        bool livePreview = false;

        #endregion

        // Form
        #region Form
        public NotepadMM(string path)
        {
            InitializeComponent();
            fileHandler = new FileHandler(txtEditor, acMenu);
            defaultLexer = new DefaultLexer(txtEditor, acMenu);
            updaterSystem = new UpdaterSystem();
            init(path);
            WriteCurrentVersion();
            
        }
        private void NotepadMM_Load(object sender, EventArgs e)
        {
            //pdateTheme();
        }
        private void NotepadMM_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CloseSoftware();
        }

        #region CustomFunc

        void UpdateTheme()
        {
            string theme = Settings.Default.currentEditorTheme;
            switch (theme)
            {
                case "Dark":
                    txtEditor.BackColor = Color.FromArgb(16, 19, 25);
                    txtEditor.ForeColor = Color.White;
                    txtEditor.IndentBackColor = Color.FromArgb(16, 19, 25);
                    txtEditor.LineNumberColor = Color.FromArgb(68, 90, 120);
                    txtEditor.CaretColor = Color.Transparent;
                    txtEditor.ServiceLinesColor = Color.FromArgb(40, 40, 40);
                    txtEditor.SelectionColor = Color.FromArgb(103, 107, 119);

                    this.BackColor = darkBackColor;
                    this.ForeColor = darkForeColor;

                    tsTools.ForeColor = darkForeColor;
                    tsTools.BackColor = darkBackColor;
                    tsiSave.BackColor = darkBackColor;
                    tsiSave.ForeColor = darkForeColor;
                    tsbLivePreview.BackColor = darkBackColor;
                    tsbLivePreview.ForeColor = darkForeColor;
                    txtEditor.BorderStyle = BorderStyle.None;
                    
                    break;
                case "Light":
                    break;
            }
        }

        void init(string filePath)
        {
            updater.Start();
            if (GlobalData.devMode)
            {
                GlobalData.devCon.ShowConsole();
            }

            if (GlobalData.start_with_file)
            {
                GlobalData.devCon.LogMessage("Application was started with a file", ConsoleColor.Magenta);
                GlobalData.devCon.LogMessage($"CurrentFileName: {GlobalData.currentFileName}");
                GlobalData.devCon.LogMessage($"CurrentFilePath: {GlobalData.currentFilePath}");
                GlobalData.devCon.LogMessage($"FileContent:\n{GlobalData.lastSavedContent}");
                GlobalData.start_with_file = true;

                //GlobalData.devCon.LogMessage($"");

            }
            else
            {
                GlobalData.devCon.LogMessage("Application was started immediately", ConsoleColor.Magenta);
            }
            if (GlobalData.fileType == GlobalData.FileType.Default)
            {
                defaultLexer.ApplyDefaultLexer();
            }

            if (GlobalData.autoCheckForUpdate)
            {
                if (updaterSystem.CheckForUpdate())
                {
                    FrmNewUpdate newUpdate = new FrmNewUpdate();
                    newUpdate.ShowDialog();
                }
            }

            if (!GlobalData.livepreview)
            {
                tsbLivePreview.Visible = false;
            }

        }
        #endregion
       
        #endregion

        #region MenuStrip

        #region File
        private void msiSave_Click(object sender, EventArgs e)
        {
            fileHandler.SaveFile();
        }

        private void msiExit_Click(object sender, EventArgs e)
        {
            CloseSoftware();
        }
        private void msiNew_Click(object sender, EventArgs e)
        {
            FullClear();
        }

        private void msiOpen_Click(object sender, EventArgs e)
        {
            ClearData();
            fileHandler.OpenFile();
        }
        #endregion

        #region Edit
        private void msiUndone_Click(object sender, EventArgs e)
        {
            txtEditor.Undo();
        }

        private void msiRestore_Click(object sender, EventArgs e)
        {
            txtEditor.Redo();
        }

        private void msiCopy_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void msiCut_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void msiPaste_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void msiSelectAll_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
        }

        #endregion

        #region Settings
        private void msiSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }

        #region Language

        private void tsmiLanguageCPP_Click(object sender, EventArgs e)
        {
            GlobalData.fileType = GlobalData.FileType.CPP;
            autoCompleteTool.AutoComplete(txtEditor, acMenu);
        }

        private void tsmiLanguageCSharp_Click(object sender, EventArgs e)
        {
            GlobalData.fileType = GlobalData.FileType.CSharp;
            autoCompleteTool.AutoComplete(txtEditor, acMenu);
        }

        private void tsmiLanguagePython_Click(object sender, EventArgs e)
        {
            GlobalData.fileType = GlobalData.FileType.Python;
            autoCompleteTool.AutoComplete(txtEditor, acMenu);
        }

        private void tsmiLanuageDefault_Click(object sender, EventArgs e)
        {
            GlobalData.fileType = GlobalData.FileType.Default;
            autoCompleteTool.AutoComplete(txtEditor, acMenu);
        }

        private void tsmiText_Click(object sender, EventArgs e)
        {
            GlobalData.fileType = GlobalData.FileType.Text;
            autoCompleteTool.AutoComplete(txtEditor, acMenu);
        }

        #endregion

        #endregion

        #region Search

        private void msiSearch_Click(object sender, EventArgs e)
        {

        }

        private void msiReplace_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Help
        private void msiUpdate_Click(object sender, EventArgs e)
        {
            if (updaterSystem.CheckForUpdate())
            {
                FrmNewUpdate newUpdate = new FrmNewUpdate();
                newUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("The software is already up to date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void msiInfo_Click(object sender, EventArgs e)
        {
            FrmInfo info = new FrmInfo();
            info.ShowDialog();
        }

        #endregion

        #endregion

        #region ToolStrip
        private void tsiSave_Click(object sender, EventArgs e)
        {
            fileHandler.SaveFile();
        }

        private void tsbLivePreview_Click(object sender, EventArgs e)
        {
            if (livePreview)
            {
                livePreview = false;
                tsbLivePreview.Image = Resources.Live;
                StopPreview();
            }
            else
            {
                livePreview = true;
                tsbLivePreview.Image = Resources.Stop;
                StartPreview();

            }
        }

        #endregion

        #region Custom Func

        #region Live Preview

        private void livePreviewUpdater_Tick(object sender, EventArgs e)
        {
            livePreviewWindow.UpdatePreview(txtEditor.Text);
        }

        void StartPreview()
        {
            livePreviewWindow = new FrmLivePreview();
            livePreviewUpdater.Start();
            livePreviewWindow.Show();
            livePreviewWindow.UpdatePreview(txtEditor.Text);
        }

        void StopPreview()
        {
            livePreviewUpdater.Stop();
            livePreviewWindow.ClosePreview();
        }

        #endregion

        #region Other

        private void FullClear()
        {
            txtEditor.Clear();
            GlobalData.currentFileName = null;
            GlobalData.currentFilePath = null;
            GlobalData.currentContent = null;
            GlobalData.lastSavedContent = null;
            GlobalData.fileType = default;
            txtEditor.Language = Language.Custom;
            GlobalData.isSaved = false;
        }

        // Lese die aktuelle Version aus der Konfigurationsdatei
        private static string GetCurrentVersion()
        {
            string configFilePath = "version.txt"; // Passe den Pfad zu deiner Konfigurationsdatei an

            try
            {
                if (File.Exists(configFilePath))
                {
                    // Lese die Versionsnummer aus der Datei
                    return File.ReadAllText(configFilePath).Trim();
                }
            }
            catch (Exception ex)
            {
                // Handle Ausnahmen bei Bedarf
                Console.WriteLine($"Fehler beim Lesen der Konfigurationsdatei: {ex.Message}");
            }

            // Standard-Version, falls etwas schief geht
            return "null";
        }

        // Schreibe die aktuelle Version in die Konfigurationsdatei
        private static void WriteCurrentVersion()
        {
            string configFilePath = "version.txt"; // Passe den Pfad zu deiner Konfigurationsdatei an

            try
            {
                // Schreibe die Versionsnummer in die Datei
                StreamWriter writer = new StreamWriter(configFilePath);
                writer.WriteLine(GlobalData.version);
                writer.Close();
            }
            catch (Exception ex)
            {
                // Handle Ausnahmen bei Bedarf
                Console.WriteLine($"Fehler beim Schreiben der Konfigurationsdatei: {ex.Message}");
            }
        }
        public void SetFileContent(string content)
        {
            txtEditor.Text = content;
        }

        void ClearData()
        {
            if (txtEditor.Text == "" || txtEditor.Text == " " || txtEditor.Text == null)
            {
                txtEditor.Text = null;
                GlobalData.currentFileName = null;
                GlobalData.currentFilePath = null;
                GlobalData.currentContent = null;
                GlobalData.lastSavedContent = null;
            }
            else
            {
                fileHandler.SaveFile();
                txtEditor.Text = null;
                GlobalData.currentFileName = null;
                GlobalData.currentFilePath = null;
                GlobalData.currentContent = null;
                GlobalData.lastSavedContent = null;
            }
            this.Text = "Notepad--";
        }

        void CloseSoftware()
        {
            if (GlobalData.isSaved)
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Alle fortschritte gehen verloren.\nMöchten sie Speichern?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Überprüfen Sie das Ergebnis der MessageBox
                if (result == DialogResult.Yes)
                {
                    fileHandler.SaveFile();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void UpdateHilight(FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            switch (GlobalData.fileType)
            {
                case GlobalData.FileType.CSharp:
                    e.ChangedRange.ClearStyle();
                    // Clear and Set Folder markers
                    e.ChangedRange.ClearFoldingMarkers();
                    e.ChangedRange.SetFoldingMarkers("{", "}");
                    // AddStyle
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "{");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "}");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "!");
                    e.ChangedRange.SetStyle(LexerTextStyles.mediumPurpleStyle, "=");
                    
                    var pattern = @"\b(" + string.Join("|", GlobalData.CSharpStandardKeywords.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.blueRegularStyle, pattern);
                    pattern = @"\b(" + string.Join("|", GlobalData.CSharpSpecialKeywords.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, pattern);
                    e.ChangedRange.ClearStyle();

                    e.ChangedRange.SetStyle(LexerTextStyles.greenStyle, @"//.*$");
                    break;
                case GlobalData.FileType.CPP:
                    e.ChangedRange.ClearStyle();
                    e.ChangedRange.ClearFoldingMarkers();
                    e.ChangedRange.SetFoldingMarkers("{", "}");

                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "{");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "}");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "!");

                    e.ChangedRange.SetStyle(LexerTextStyles.mediumPurpleStyle, "=");

                    pattern = @"\b(" + string.Join("|", GlobalData.CPPKeywords.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.blueRegularStyle, pattern);

                    pattern = @"\b(" + string.Join("|", GlobalData.CPPSpecialKeywords.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, pattern);

                    e.ChangedRange.SetStyle(LexerTextStyles.greenStyle, @"//.*$");
                    break;
                case GlobalData.FileType.Python:
                    e.ChangedRange.ClearStyle();
                    e.ChangedRange.ClearFoldingMarkers();
                    e.ChangedRange.SetFoldingMarkers("{", ":");

                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "{");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "}");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "!");

                    e.ChangedRange.SetStyle(LexerTextStyles.mediumPurpleStyle, "=");

                    pattern = @"\b(" + string.Join("|", GlobalData.PythonKeywords.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.blueRegularStyle, pattern);

                    pattern = @"\b(" + string.Join("|", GlobalData.PythonFunctions.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, pattern);

                    e.ChangedRange.SetStyle(LexerTextStyles.greenStyle, @"#.*$");
                    break;
                case GlobalData.FileType.Text:
                    e.ChangedRange.ClearStyle();
                    break;
                case GlobalData.FileType.Default:
                    e.ChangedRange.ClearStyle();
                    e.ChangedRange.ClearFoldingMarkers();
                    e.ChangedRange.SetFoldingMarkers("{", "}");

                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "{");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "}");
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, "!");

                    e.ChangedRange.SetStyle(LexerTextStyles.mediumPurpleStyle, "=");

                    // Hier implementierst du die Syntaxhervorhebung


                    pattern = @"\b(" + string.Join("|", GlobalData.DefaultKeywords.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.blueRegularStyle, pattern);

                    pattern = @"\b(" + string.Join("|", GlobalData.DefaultChar.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.redStyle, pattern);

                    pattern = @"\b(" + string.Join("|", GlobalData.DefaultComment.Select(Regex.Escape)) + @")\b";
                    e.ChangedRange.SetStyle(LexerTextStyles.greenStyle, pattern);
                    // Schlüsselwörter hervorheben
                    break;
                default: 
                    break;
            }

        }


        #endregion
        #endregion

        #region Editor Code

        private void txtEditor_Load(object sender, EventArgs e)
        {

        }

        private void txtEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            UpdateHilight(e);
            GlobalData.currentContent = txtEditor.Text;
        }

        #endregion

        #region updater
        private void updater_Tick(object sender, EventArgs e)
        {
            

            if (GlobalData.isSaved)
            {
                msiSave.Image = Resources.Saved;
                tsiSave.Image = Resources.Saved;
            }

            if (GlobalData.lastSavedContent != GlobalData.currentContent)
            {
                msiSave.Image = Resources.Save;
                tsiSave.Image = Resources.Save;
            }

            
            // Weitere Aktualisierungen hier
        }

        private void hilightUpdater_Tick(object sender, EventArgs e)
        {
            FastColoredTextBoxNS.TextChangedEventArgs ev = new FastColoredTextBoxNS.TextChangedEventArgs(txtEditor.Range);
            UpdateHilight(ev);
        }
        #endregion       
    }
}
