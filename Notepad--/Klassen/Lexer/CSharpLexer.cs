using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using AutocompleteMenuNS;
using FastColoredTextBoxNS;
using Notepad__.Klassen;
using Notepad__.Properties;

public class CSharpLexer
{
    private readonly FastColoredTextBox fastColoredTextBox;
    private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu;

    AutoCompleteTool act = new AutoCompleteTool();

    public CSharpLexer(FastColoredTextBox editor, AutocompleteMenuNS.AutocompleteMenu autocompleteMenu)
    {
        fastColoredTextBox = editor;
        act = new AutoCompleteTool();
        this.autocompleteMenu = autocompleteMenu;
    }

    public void ApplyCSharpLexer()
    {
        if (Settings.Default.ColoredCode)
        {
            // Füge Autovervollständigungsdaten hinzu
            fastColoredTextBox.AutoCompleteBrackets = true;
            act.AutoComplete(fastColoredTextBox, autocompleteMenu);
        }
    }



}
