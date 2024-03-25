using FastColoredTextBoxNS;
using Notepad__.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__.Klassen
{
    public class FileHandler
    {
        private FastColoredTextBox txtEditor;
        AutocompleteMenuNS.AutocompleteMenu acm;

        #region Lexer
        public static CSharpLexer csLexer;
        public static PythonLexer pythonLexer;
        public static CppLexer cppLexer;
        public static DefaultLexer defaultLexer;
        #endregion

        public FileHandler(FastColoredTextBox textEditor, AutocompleteMenuNS.AutocompleteMenu autocompleteMenu)
        {
            txtEditor = textEditor;
            acm = autocompleteMenu;
            csLexer = new CSharpLexer(txtEditor, acm);
            pythonLexer = new PythonLexer(txtEditor, acm);
            cppLexer = new CppLexer(txtEditor, acm);
            defaultLexer = new DefaultLexer(txtEditor, acm);
            Initialize();
        }

        private void Initialize()
        {
            GlobalData.currentFilePath = string.Empty;
            GlobalData.currentFileName = string.Empty;
            GlobalData.isSaved = false;
            GlobalData.lastSavedContent = string.Empty;
        }

        public void SaveFile()
        {
            if (GlobalData.isSaved)
            {
                File.WriteAllText(GlobalData.currentFilePath, txtEditor.Text);
                GlobalData.currentContent = txtEditor.Text;
                GlobalData.lastSavedContent = txtEditor.Text;
                GlobalData.isSaved = true;
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Textdateien|*.txt|Alle Dateien|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
                            GlobalData.currentFilePath = saveFileDialog.FileName;
                            GlobalData.isSaved = true;
                            GlobalData.currentContent = txtEditor.Text;
                            GlobalData.lastSavedContent = txtEditor.Text;
                            MessageBox.Show("Datei erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Fehler beim Speichern der Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        public void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt; *.xml; *.xaml)|*.txt;*.xml;*.xaml";
            openFileDialog.Title = "Open File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        txtEditor.Text = streamReader.ReadToEnd();
                        streamReader.Close();
                    }

                    GlobalData.currentFilePath = openFileDialog.FileName;
                    GlobalData.currentFileName = Path.GetFileName(openFileDialog.FileName);

                    SetFastColoredTextBoxLexerByFileExtension(GlobalData.currentFilePath);

                    GlobalData.isSaved = true;
                    GlobalData.currentContent = txtEditor.Text;
                    GlobalData.lastSavedContent = txtEditor.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GlobalData.isSaved = true;
        }
        public void SetFastColoredTextBoxLexerByFileExtension(string filePath)
        {
            if (Settings.Default.ColoredCode)
            {
                string fileExtension = Path.GetExtension(filePath);

                switch (fileExtension.ToLower())
                {
                    case ".cpp":
                        GlobalData.fileType = GlobalData.FileType.CPP;
                        txtEditor.Language = Language.Custom;
                        cppLexer.ApplyCppLexer();
                        break;
                    case ".cs":
                        GlobalData.fileType = GlobalData.FileType.CSharp;
                        txtEditor.Language = Language.CSharp;
                        csLexer.ApplyCSharpLexer();
                        break;
                    case ".py":
                        GlobalData.fileType = GlobalData.FileType.Python;
                        txtEditor.Language = Language.Custom;
                        pythonLexer.ApplyPythonLexer();
                        break;
                    case ".html":
                        GlobalData.fileType = GlobalData.FileType.HTML;
                        txtEditor.Language = Language.HTML;
                        break;
                    case ".txt":
                        GlobalData.fileType = GlobalData.FileType.Text;
                        txtEditor.Language = Language.Custom;
                        break;
                    // Add more cases for other file extensions and corresponding lexers if needed
                    default:
                        GlobalData.fileType = GlobalData.FileType.Text;
                        txtEditor.Language = Language.Custom;
                        //defaultLexer.ApplyDefaultLexer();
                        break;
                }
            }
        }

        public static void SetLexerByFileExtensionOnStartup(string filePath)
        {
            if (Settings.Default.ColoredCode)
            {
                string fileExtension = Path.GetExtension(filePath);

                switch (fileExtension.ToLower())
                {
                    case ".cs":
                        csLexer.ApplyCSharpLexer();
                        GlobalData.fileType = GlobalData.FileType.CSharp;
                        break;
                    case ".py":
                        pythonLexer.ApplyPythonLexer();
                        GlobalData.fileType = GlobalData.FileType.Python;
                        break;
                    case ".cpp":
                        cppLexer.ApplyCppLexer();
                        GlobalData.fileType = GlobalData.FileType.CPP;
                        break;

                    // Add more cases for other file extensions and corresponding lexers if needed
                    default:
                        defaultLexer.ApplyDefaultLexer();
                        GlobalData.fileType = GlobalData.FileType.Default;
                        break;
                }
            }
        }
    }
}
