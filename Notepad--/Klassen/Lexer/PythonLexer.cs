using AutocompleteMenuNS;
using FastColoredTextBoxNS;
using Notepad__.Klassen;
using Notepad__.Properties;
using System.Collections.Generic;
using System.Drawing;

public class PythonLexer
{
    private readonly FastColoredTextBox fastColoredTextBox;
    private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu;
    AutoCompleteTool act = new AutoCompleteTool();

    List<string> AutoCompletionList = new List<string>
    {
        "False", "None", "True", "and", "as", "assert", "async", "await", "break", "class", "continue", "def", "del", "elif", "else", "except",
        "False", "finally", "for", "from", "global", "if", "import", "in", "is", "lambda", "nonlocal", "not", "or", "pass", "raise", "return", "True",
        "try", "while", "with", "yield",
        "print", "input", "len", "range", "list", "dict", "set", "tuple", "str", "int", "float", "bool",
        "elif", "exec", "global", "try", "except", "finally", "with", "yield", "async", "await",
        "property", "staticmethod", "classmethod", "super", "delattr", "getattr", "hasattr", "setattr",
        "dir", "divmod", "enumerate", "filter", "hex", "oct", "id", "map", "sorted", "sum", "type",
        "zip", "chr", "ord", "abs", "all", "any", "bin", "bool", "callable", "format", "frozenset",
        "getattr", "globals", "locals", "max", "min", "next", "repr", "round", "slice", "vars",
        "complex", "exec", "eval", "property", "zip", "slice", "sorted", "reversed", "ascii", "ord", "chr", "bin", "hex",
        "oct", "hash", "pow", "abs", "divmod", "round", "max", "min", "sum", "len", "enumerate", "map", "filter", "sorted",
        "any", "all", "dir", "vars", "globals", "locals", "id", "type", "callable", "isinstance", "issubclass", "hasattr",
        "getattr", "setattr", "delattr", "repr", "str", "bytes", "bytearray", "memoryview", "format", "ord", "chr", "hash",
        "ascii", "repr", "bin", "hex", "oct"
    };


    public PythonLexer(FastColoredTextBox editor, AutocompleteMenuNS.AutocompleteMenu autocompleteMenu)
    {
        fastColoredTextBox = editor;
        this.autocompleteMenu = autocompleteMenu;
    }

    public void ApplyPythonLexer()
    {
        if (Settings.Default.ColoredCode)
        {
            // Füge Autovervollständigungsdaten hinzu
            fastColoredTextBox.AutoCompleteBrackets = true;
            act.AutoComplete(fastColoredTextBox, autocompleteMenu);
        }
    }
}
