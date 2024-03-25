using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutocompleteMenuNS;
using FastColoredTextBoxNS;
using Notepad__.Properties;

namespace Notepad__.Klassen
{
    public class AutoCompleteTool
    {
        FastColoredTextBox editor = new FastColoredTextBox();
        private bool preventInsertion = false;
        AutocompleteMenuNS.AutocompleteMenu acm;


        #region AutoCompleteCode
        public void AutoComplete(FastColoredTextBox txtEditor, AutocompleteMenuNS.AutocompleteMenu autocompleteMenu)
        {
            editor = txtEditor;
            acm = autocompleteMenu;

            switch (GlobalData.fileType)
            {
                case GlobalData.FileType.CSharp:
                    AutoCSharp(txtEditor);
                    break;
                case GlobalData.FileType.Python:
                    AutoPython(txtEditor);
                    break;
                case GlobalData.FileType.CPP:
                    AutoCPP(txtEditor);
                    break;
                case GlobalData.FileType.Default: 
                    CodeHelper(txtEditor);
                    break;
                default: 
                    break;
            }
        }

        public void CodeHelper(FastColoredTextBox txtEditor)
        {
            // Beispiel-Liste von Schlüsselwörtern für die Autovervollständigung
            List<string> AutoCompletionList = new List<string>
            {
                // Webentwicklung
                "html", "head", "body", "div", "span", "a", "img", "p", "h1", "h2", "h3", "h4", "h5", "h6", "ul", "ol", "li", "form",
                "input", "button", "select", "option", "textarea", "style", "link", "script", "meta",
                // Allgemeine Programmierung
                "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "class", "const", "continue", "decimal",
                "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "float",
                "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace",
                "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly",
                "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this",
                "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "using static", "virtual",
                "void", "volatile", "while", "yield",

                

                // CSS
                "color", "background-color", "font-size", "font-family", "margin", "padding", "border", "display", "position",
                "float", "clear", "width", "height", "text-align", "line-height", "overflow", "visibility", "opacity", "z-index",

                // JavaScript
                "var", "let", "const", "if", "else", "switch", "case", "default", "for", "while", "do", "function", "return",
                "break", "continue", "try", "catch", "throw", "typeof", "instanceof", "new", "this", "null", "undefined", "true",
                "false", "NaN", "Infinity", "Object", "Array", "String", "Number", "Boolean", "Date", "Math", "JSON",

                // C++
                "alignas", "alignof", "and", "and_eq", "asm", "atomic_cancel", "atomic_commit", "atomic_noexcept", "auto", "bitand",
                "bitor", "bool", "break", "case", "catch", "char", "class", "compl", "concept", "const", "consteval", "constexpr",
                "const_cast", "continue", "co_await", "co_return", "co_yield", "decltype", "default", "delete", "do", "double",
                "dynamic_cast", "else", "enum", "explicit", "export", "extern", "false", "float", "for", "friend", "goto", "if",
                "import", "inline", "int", "long", "module", "mutable", "namespace", "new", "noexcept", "not", "not_eq", "nullptr",
                "operator", "or", "or_eq", "private", "protected", "public", "reflexpr", "register", "reinterpret_cast", "requires",
                "return", "short", "signed", "sizeof", "static", "static_assert", "static_cast", "struct", "switch", "synchronized",
                "template", "this", "thread_local", "throw", "true", "try", "typedef", "typeid", "typename", "union", "unsigned",
                "using", "virtual", "void", "volatile", "wchar_t", "while", "xor", "xor_eq",

                // Python
                "False", "None", "True", "and", "as", "assert", "async", "await", "break", "class", "continue", "def", "del", "elif",
                "else", "except", "finally", "for", "from", "global", "if", "import", "in", "is", "lambda", "nonlocal", "not", "or",
                "pass", "raise", "return", "try", "while", "with", "yield", "print", "input", "len", "range", "list", "dict", "set",
                "tuple", "str", "int", "float", "bool"
                // ... Weitere Schlüsselwörter für Python können hinzugefügt werden
            };

            // Zeichen, die eine automatische Einrückung auslösen sollen
            char[] autoIndentTriggers = { '<', '>', '{', '}' };

            if (Settings.Default.AutoCode)
            {
                foreach (string itemText in AutoCompletionList)
                {
                    AutocompleteMenuNS.AutocompleteItem item = new AutocompleteMenuNS.AutocompleteItem(itemText)
                    {
                        ImageIndex = 1
                    };
                    acm.AddItem(item);
                }
            }

            // Debugging-Statement

        }

       
        void AutoCSharp(FastColoredTextBox txtEditor)
        {
           
            // Fügen Sie Ihre Autovervollständigungsdaten mit den zugehörigen Bildindizes hinzu

            if (Settings.Default.AutoCode)
            {
                // Erstellen Sie eine Liste von AutocompleteItems und setzen Sie das gemeinsame Bild für jedes Element
                List<AutocompleteMenuNS.AutocompleteItem> autocompleteItems = new List<AutocompleteMenuNS.AutocompleteItem>();
                foreach (string itemText in GlobalData.CSharpSpecialKeywords)
                {
                    AutocompleteMenuNS.AutocompleteItem item = new AutocompleteMenuNS.AutocompleteItem(itemText)
                    {
                        ImageIndex = 0
                    };
                    acm.AddItem(item);
                }

                List<AutocompleteMenuNS.AutocompleteItem> autocompleteItems2 = new List<AutocompleteMenuNS.AutocompleteItem>();
                foreach (string itemText in GlobalData.CSharpStandardKeywords)
                {
                    AutocompleteMenuNS.AutocompleteItem item = new AutocompleteMenuNS.AutocompleteItem(itemText)
                    {
                        ImageIndex = 0
                    };
                    acm.AddItem(item);
                }

                List<string> ExCompletionList = new List<string>
                {
                    "Console.Write", "Console.WriteLine"
                };
                List<AutocompleteMenuNS.AutocompleteItem> ExcompleteItems = new List<AutocompleteMenuNS.AutocompleteItem>();
                foreach (string itemText in ExCompletionList)
                {
                    AutocompleteMenuNS.AutocompleteItem item = new AutocompleteMenuNS.AutocompleteItem(itemText)
                    {
                        ImageIndex = 1
                    };
                    acm.AddItem(item);
                }
            }           
        }

        void AutoCPP(FastColoredTextBox txtEditor)
        {
            // Beispiel-Liste von Schlüsselwörtern für die Autovervollständigung
            List<string> AutoCompletionList = new List<string>
            {
                "alignas", "alignof", "and", "and_eq", "asm", "atomic_cancel", "atomic_commit", "atomic_noexcept", "auto", "bitand", "bitor", "bool",
                "break", "case", "catch", "char", "char8_t", "char16_t", "char32_t", "class", "compl", "concept", "const", "consteval", "constexpr",
                "const_cast", "continue", "co_await", "co_return", "co_yield", "decltype", "default", "delete", "do", "double", "dynamic_cast", "else",
                "enum", "explicit", "export", "extern", "false", "float", "for", "friend", "goto", "if", "import", "inline", "int", "long", "module",
                "mutable", "namespace", "new", "noexcept", "not", "not_eq", "nullptr", "operator", "or", "or_eq", "private", "protected", "public",
                "reflexpr", "register", "reinterpret_cast", "requires", "return", "short", "signed", "sizeof", "static", "static_assert", "static_cast",
                "struct", "switch", "synchronized", "template", "this", "thread_local", "throw", "true", "try", "typedef", "typeid", "typename", "union",
                "unsigned", "using", "virtual", "void", "volatile", "wchar_t", "while", "xor", "xor_eq",
                "alignas", "alignof", "and", "and_eq", "asm", "atomic_cancel", "atomic_commit", "atomic_noexcept", "auto", "bitand", "bitor", "bool",
                "break", "case", "catch", "char", "char8_t", "char16_t", "char32_t", "class", "compl", "concept", "const", "consteval", "constexpr",
                "const_cast", "continue", "co_await", "co_return", "co_yield", "decltype", "default", "delete", "do", "double", "dynamic_cast", "else",
                "enum", "explicit", "export", "extern", "false", "float", "for", "friend", "goto", "if", "import", "inline", "int", "long", "module",
                "mutable", "namespace", "new", "noexcept", "not", "not_eq", "nullptr", "operator", "or", "or_eq", "private", "protected", "public",
                "reflexpr", "register", "reinterpret_cast", "requires", "return", "short", "signed", "sizeof", "static", "static_assert", "static_cast",
                "struct", "switch", "synchronized", "template", "this", "thread_local", "throw", "true", "try", "typedef", "typeid", "typename", "union",
                "unsigned", "using", "virtual", "void", "volatile", "wchar_t", "while", "xor", "xor_eq",
                // Zusätzliche C++20-Schlüsselwörter
                "constinit", "consteval", "constexp", "synchronized", "export", "import", "module", "preprocessor"
            };

            // Erstellen Sie eine Liste von AutocompleteItems und setzen Sie das gemeinsame Bild für jedes Element
            if (Settings.Default.AutoCode)
            {
                foreach (string itemText in AutoCompletionList)
                {
                    AutocompleteMenuNS.AutocompleteItem item = new AutocompleteMenuNS.AutocompleteItem(itemText)
                    {
                        ImageIndex = 1
                    };
                    acm.AddItem(item);
                }
            }

        }

        void AutoPython(FastColoredTextBox txtEditor)
        {
            // Beispiel-Liste von Schlüsselwörtern für die Autovervollständigung
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
                "getattr", "globals", "locals", "max", "min", "next", "repr", "round", "slice", "vars"
            };

            if (Settings.Default.AutoCode)
            {
                foreach (string itemText in AutoCompletionList)
                {
                    AutocompleteMenuNS.AutocompleteItem item = new AutocompleteMenuNS.AutocompleteItem(itemText)
                    {
                        ImageIndex = 1
                    };
                    acm.AddItem(item);
                }
            }
        }
        #endregion

        #region AutoCompleteChar
        public void AutoChar(FastColoredTextBox txtEditor)
        {
            
        }
        #endregion
    }
}
