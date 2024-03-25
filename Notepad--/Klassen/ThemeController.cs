using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__.Klassen
{
    public class ThemeController
    {
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
        public void SetDarkTheme(Form form, FastColoredTextBox txtEditor, ToolStrip ts, ToolStripButton tsi)
        {
            txtEditor.BackColor = Color.FromArgb(16, 19, 25);
            txtEditor.ForeColor = Color.White;
            txtEditor.IndentBackColor = Color.FromArgb(16, 19, 25);
            txtEditor.LineNumberColor = Color.FromArgb(68, 90, 120);
            txtEditor.CaretColor = Color.Transparent;
            txtEditor.ServiceLinesColor = Color.FromArgb(40, 40, 40);
            txtEditor.SelectionColor = Color.FromArgb(103, 107, 119);

            form.BackColor = darkBackColor;
            form.ForeColor = darkForeColor;

            ts.ForeColor = darkForeColor;
            ts.BackColor = darkBackColor;
           
            //form.FormBorderStyle = FormBorderStyle.FixedSingle; // Oder ein anderes FormBorderStyle
            //form.BorderColor = darkFormBorderColor;
            //form.HeaderColor = darkFormHeaderColor;
            //form.ButtonColor = darkFormButtonColor;
        }
    }
}
