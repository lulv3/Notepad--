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
    public partial class SExperimental : UserControl
    {

        bool autoCode = Settings.Default.AutoCode;
        bool autoChar = Settings.Default.AutoChar;
        bool livePreview = Settings.Default.htmlLivePreview;
        bool autoCheckForUpdates = Settings.Default.AutoCheckForUpdate;
        bool notepadV2 = Settings.Default.useNotepadMMV2;

        public SExperimental()
        {
            InitializeComponent();
            LoadSettings();
        }

        void LoadSettings()
        {
            cbAutoCode.Checked = autoCode;
            cbAutoChar.Checked = autoChar;
            cbLivePreview.Checked = livePreview;
            cbAutoCheckUpdates.Checked = autoCheckForUpdates;
            cbNodepadv2.Checked = notepadV2;
        }

        void SaveSettings()
        {
            Settings.Default.AutoCode = autoCode;
            Settings.Default.AutoChar = autoChar;
            Settings.Default.htmlLivePreview = livePreview;
            Settings.Default.AutoCheckForUpdate = autoCheckForUpdates;
            Settings.Default.useNotepadMMV2 = notepadV2;
            Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void cbAutoCode_CheckedChanged(object sender, EventArgs e)
        {
            autoCode = cbAutoCode.Checked;
        }

        private void cbAutoChar_CheckedChanged(object sender, EventArgs e)
        {
            autoChar = cbAutoChar.Checked;
        }

        private void cbLivePreview_CheckedChanged(object sender, EventArgs e)
        {
            livePreview = cbLivePreview.Checked;
        }

        private void cbAutoCheckUpdates_CheckedChanged(object sender, EventArgs e)
        {
            autoCheckForUpdates = cbAutoCheckUpdates.Checked;
        }

        private void cbNotepadV2_CheckedChanged(object sender, EventArgs e)
        {
            notepadV2 = cbNodepadv2.Checked;
        }
    }
}
