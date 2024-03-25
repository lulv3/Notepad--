using Notepad__.Klassen;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdate.Klassen
{

    public class UpdaterSystem
    {

        public bool CheckForUpdate()
        {
            // URL zur Versionsinformation
            string versionUrl = "https://downloadnotepad.netlify.app/data/version.txt";

            // Hole die Versionsnummer von der Webseite
            string webVersion = GetWebVersion();

            if (GlobalData.version != webVersion)
            {
                // Update Avaleble
                return true;
            }
            else
            {
                // No Update
                return false;
            }

        }

        public string GetWebVersion()
        {
            string versionUrl = "https://downloadnotepad.netlify.app/data/version.txt";
            using (WebClient client = new WebClient())
            {
                try
                {
                    // Lese die Versionsnummer von der Webseite aus
                    return client.DownloadString(versionUrl).Trim();
                }
                catch (Exception ex)
                {
                    // Behandle den Fehler, z.B. durch Loggen oder Anzeigen einer Meldung
                    Console.WriteLine($"Fehler beim Abrufen der Version: {ex.Message}");
                    return string.Empty;
                }
            }
        }

        public string GetLastUpdate()
        {
            string versionUrl = "https://downloadnotepad.netlify.app/data/last-update.txt";
            using (WebClient client = new WebClient())
            {
                try
                {
                    // Lese die Versionsnummer von der Webseite aus
                    return client.DownloadString(versionUrl).Trim();
                }
                catch (Exception ex)
                {
                    // Behandle den Fehler, z.B. durch Loggen oder Anzeigen einer Meldung
                    Console.WriteLine($"Fehler beim Abrufen der Version: {ex.Message}");
                    return string.Empty;
                }
            }
        }
    }

}
