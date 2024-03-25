using Notepad__.Klassen;
using Notepad__.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__.Forms.UserWidgets
{
    public partial class SColors : UserControl
    {
        bool coloredCode = Settings.Default.ColoredCode;
        public SColors()
        {
            InitializeComponent();
            LoadSettings();
        }

        void LoadSettings()
        {
            cbColoredCode.Checked = coloredCode;
        }
        void SaveSettings()
        {
            Settings.Default.ColoredCode = coloredCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Settings.Default.Save();
            FileHandler.SetLexerByFileExtensionOnStartup(GlobalData.currentFilePath);
        }

        private void cbColoredCode_CheckedChanged(object sender, EventArgs e)
        {
            coloredCode = cbColoredCode.Checked;    
        }
    }
}
