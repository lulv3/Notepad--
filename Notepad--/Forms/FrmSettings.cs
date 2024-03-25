using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad__.Forms.UserWidgets;

namespace Notepad__.Forms
{
    public partial class FrmSettings : Form
    {
        private ImageList imageList = new ImageList();
        public FrmSettings()
        {
            InitializeComponent();
            imageList.Images.Add("Folder", Properties.Resources.Folder); // Annahme: Ein Bild mit dem Namen "Folder" wird hinzugefügt.
            imageList.Images.Add("OpenFolder", Properties.Resources.Opened_Folder); // Annahme: Ein Bild mit dem Namen "File" wird hinzugefügt.
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode.Text == "Language")
            {
                SLanguage lang = new SLanguage();   
                AddUserControlToPanel(lang, pnlContent);
            }

            if (selectedNode.Text == "Theme")
            {
                STheme theme = new STheme();
                AddUserControlToPanel(theme, pnlContent);
            }

            if (selectedNode.Text == "Experimental")
            {
                SExperimental ex = new SExperimental();
                AddUserControlToPanel(ex, pnlContent);
            }

            if (selectedNode.Text == "Colors")
            {
                SColors colors = new SColors();
                AddUserControlToPanel(colors, pnlContent);
            }
        }

        private void AddUserControlToPanel(UserControl uc, Panel pnl)
        {
            // Annahme: MyUserControl ist der Name deiner UserControl-Klasse
            pnl.Controls.Clear();

            // Setze die Größe und Position des UserControl
            uc.Dock = DockStyle.Fill;

            // Füge das UserControl zum Panel hinzu
            pnl.Controls.Add(uc);
        }
    }
}
