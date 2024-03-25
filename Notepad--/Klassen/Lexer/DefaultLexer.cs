using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using AutocompleteMenuNS;
using FastColoredTextBoxNS;
using Notepad__.Klassen;
using Notepad__.Properties;

public class DefaultLexer
{
    private readonly FastColoredTextBox fastColoredTextBox;
    private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu;
    AutoCompleteTool act = new AutoCompleteTool();



    public DefaultLexer(FastColoredTextBox editor, AutocompleteMenuNS.AutocompleteMenu autocompleteMenu)
    {
        fastColoredTextBox = editor;
        this.autocompleteMenu = autocompleteMenu;
    }

    public void ApplyDefaultLexer()
    {
        if (Settings.Default.ColoredCode)
        {
            fastColoredTextBox.Language = Language.Custom;

            // Handle das TextChanged-Ereignis, um die Syntaxhervorhebung zu aktualisieren
            fastColoredTextBox.TextChanged += FastColoredTextBox_TextChanged;

            // Füge Autovervollständigungsdaten hinzu
            fastColoredTextBox.AutoCompleteBrackets = true;
            act.AutoComplete(fastColoredTextBox, autocompleteMenu);
        }
        
    }

    private void FastColoredTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextHilight(e);
    }

    public void TextHilight(TextChangedEventArgs e)
    {
        

        // Weitere Muster und Stile können nach Bedarf hinzugefügt werden
    }
}
