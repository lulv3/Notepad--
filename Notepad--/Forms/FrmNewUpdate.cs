using AutoUpdate.Klassen;
using Notepad__.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__.Forms
{
    public partial class FrmNewUpdate : Form
    {
        UpdaterSystem updaterSys = new UpdaterSystem(); 
        public FrmNewUpdate()
        {
            InitializeComponent();
        }

        private void FrmNewUpdate_Load(object sender, EventArgs e)
        {
            lblCurrentVersion.Text = $"Current Version: {GlobalData.version}";
            lblNewVersion.Text = $"New Version: {updaterSys.GetWebVersion()}"
;        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Process.Start("Updater.exe");
            Application.Exit();
        }
    }
}
