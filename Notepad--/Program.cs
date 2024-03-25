using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad__.Forms;
using Notepad__.Klassen;
using Notepad__.Properties;

namespace Notepad__
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        // Prüfe auf Updates
        
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            // Wenn Argumente vorhanden sind, öffne die Datei
            if (args.Length > 0)
            {
                OpenFile(args[0]);
            }
            else
            {
                if (Settings.Default.useNotepadMMV2)
                {
                    Application.Run(new NotepadMMV2(null));
                }
               else
                {
                    Application.Run(new NotepadMM(null));
                }
                
            }
        }

        // Method for opening a file and setting the lexer
        // Methode zum Öffnen einer Datei und Setzen des Lexers
        private static void OpenFile(string filePath)
        {
            if (Settings.Default.useNotepadMMV2)
            {
                NotepadMMV2 mainForm = new NotepadMMV2(filePath);

                // Setze den Dateipfad in einer globalen Variable
                GlobalData.currentFilePath = filePath;

                // Setze den Dateinamen in einer globalen Variable
                GlobalData.currentFileName = System.IO.Path.GetFileName(filePath);

                // Setze den Lexer basierend auf der Dateiendung
                FileHandler.SetLexerByFileExtensionOnStartup(filePath);

                // Lese den Inhalt der Datei und setze ihn im Texteditor
                string fileContent = System.IO.File.ReadAllText(filePath);

                // Setze den Inhalt im Texteditor
                mainForm.SetFileContent(fileContent);

                // Setze die globalen Variablen für das Speichern
                GlobalData.isSaved = true;
                GlobalData.lastSavedContent = fileContent;
                GlobalData.currentContent = fileContent;

                Application.Run(mainForm);
            }
            else
            {
                NotepadMM mainForm = new NotepadMM(filePath);

                // Setze den Dateipfad in einer globalen Variable
                GlobalData.currentFilePath = filePath;

                // Setze den Dateinamen in einer globalen Variable
                GlobalData.currentFileName = System.IO.Path.GetFileName(filePath);

                // Setze den Lexer basierend auf der Dateiendung
                FileHandler.SetLexerByFileExtensionOnStartup(filePath);

                // Lese den Inhalt der Datei und setze ihn im Texteditor
                string fileContent = System.IO.File.ReadAllText(filePath);

                // Setze den Inhalt im Texteditor
                mainForm.SetFileContent(fileContent);

                // Setze die globalen Variablen für das Speichern
                GlobalData.isSaved = true;
                GlobalData.lastSavedContent = fileContent;
                GlobalData.currentContent = fileContent;

                Application.Run(mainForm);
            }
        }

    }
}
