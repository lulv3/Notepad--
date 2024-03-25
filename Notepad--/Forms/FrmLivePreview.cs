using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__.Forms
{
    public partial class FrmLivePreview : Form
    {
        public FrmLivePreview()
        {
            InitializeComponent();
        }

        private void FrmLivePreview_Load(object sender, EventArgs e)
        {

        }

        public void UpdatePreview(string htmlCode)
        {
            // Hier implementierst du den Code zum Aktualisieren der Live-Vorschau
            // basierend auf dem übergebenen HTML-Code.
            // Beispiel: webBrowser.DocumentText = htmlCode;
            wbLivePreview.DocumentText = htmlCode;
        }

        public void ClosePreview()
        {
            this.Close();
        }
    }
}
