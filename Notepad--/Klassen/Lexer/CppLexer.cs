﻿using AutocompleteMenuNS;
using FastColoredTextBoxNS;
using Notepad__.Klassen;
using Notepad__.Properties;
using System.Collections.Generic;
using System.Drawing;

public class CppLexer
{
    private readonly FastColoredTextBox fastColoredTextBox;
    private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu;

    AutoCompleteTool act = new AutoCompleteTool();

    private readonly List<string> keywords = new List<string>
    {
        "alignas", "alignof", "and", "and_eq", "asm", "auto",
        "bitand", "bitor", "bool", "break",
        "case", "catch", "char", "char8_t", "char16_t", "char32_t", "class", "compl", "concept", "const",
        "consteval", "constexpr", "const_cast", "continue",
        "co_await", "co_return", "co_yield",
        "decltype", "default", "delete", "do", "double", "dynamic_cast",
        "else", "enum", "explicit", "export", "extern",
        "false", "float", "for", "friend",
        "goto",
        "if", "import", "inline", "int",
        "long",
        "module", "mutable",
        "namespace", "new", "noexcept", "not", "not_eq", "nullptr",
        "operator", "or", "or_eq",
        "private", "protected", "public",
        "ref", "register", "reinterpret_cast", "requires", "return",
        "short", "signed", "sizeof", "static", "static_assert", "static_cast", "struct", "switch",
        "template", "this", "thread_local", "throw", "true", "try", "typedef", "typeid", "typename",
        "union", "unsigned", "using",
        "virtual", "void", "volatile",
        "wchar_t", "while", "xor", "xor_eq", "cout", "cin", "std"
    };

    public CppLexer(FastColoredTextBox editor, AutocompleteMenuNS.AutocompleteMenu autocompleteMenu)
    {
        fastColoredTextBox = editor;
        act = new AutoCompleteTool();
        this.autocompleteMenu = autocompleteMenu;
    }

    public void ApplyCppLexer()
    {
        if (Settings.Default.ColoredCode)
        {
            // Füge Autovervollständigungsdaten hinzu
            fastColoredTextBox.AutoCompleteBrackets = true;
            act.AutoComplete(fastColoredTextBox, autocompleteMenu);
        }
    }
}
