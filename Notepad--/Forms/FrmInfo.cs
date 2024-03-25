using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdate.Klassen;
using Notepad__.Klassen;

namespace Notepad__.Forms
{
    public partial class FrmInfo : Form
    {
        UpdaterSystem updater = new UpdaterSystem();
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            lblCurrentVersion.Text = "Current Version : " + GlobalData.version;
            lblNewestVersion.Text = $"Newest Version: {updater.GetWebVersion()}";
            lblLastUpdate.Text = $"Last Release: {updater.GetLastUpdate()}";
        }
    }
}
