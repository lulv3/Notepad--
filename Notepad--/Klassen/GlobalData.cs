using FastColoredTextBoxNS;
using Notepad__.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VailedTools;

namespace Notepad__.Klassen
{
    public class GlobalData
    {
        #region Keywords and more

        #region Default
        public static List<string> DefaultKeywords = new List<string>
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

        public static List<string> DefaultChar = new List<string>
        {
            "<", ">", "(", ")", "[", "]", "{", "}", "@", "*"
        };
        public static List<string> DefaultComment = new List<string>
        {
            "#", "//", "<-", "->"
        };
        #endregion

        #region CSharp
        public static List<string> CSharpStandardKeywords = new List<string>
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const",
            "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern",
            "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface",
            "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override",
            "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof",
            "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong",
            "unchecked", "unsafe", "ushort", "using", "using static", "virtual", "void", "volatile", "while", "yield",
            "Console", "async", "await", "dynamic", "nameof", "partial", "value", "when",
            "yield", "get", "set", "add", "remove", "value", "from", "group", "into", "orderby", "select", "join", "equals",
            "ascending", "descending", "let", "on", "equals", "by", "ascending", "descending", "into", "from", "where",
            "join", "let", "orderby", "select", "group", "in", "on", "equals", "by", "ascending", "descending", "into", "Taks"
        };

        public static List<string> CSharpSpecialKeywords = new List<string>
        {
            "Write", "WriteLine", "async", "await", "dynamic", "nameof", "partial", "value", "when",
            "yield", "get", "set", "add", "remove", "value", "from", "group", "into", "orderby", "select", "join", "equals",
            "ascending", "descending", "let", "on", "equals", "by", "ascending", "descending", "into", "from", "where",
            "join", "let", "orderby", "select", "group", "in", "on", "equals", "by", "ascending", "descending", "into", "Taks"
            // Fügen Sie hier weitere spezielle Schlüsselwörter hinzu, die Sie hervorheben möchten
        };
        #endregion

        #region CPP
        public static List<string> CPPKeywords = new List<string>
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
            "wchar_t", "while", "xor", "xor_eq", "std"
        };

        public static List<string> CPPSpecialKeywords = new List<string>
        {
            "cout", "cin", "endl", "vector", "list", "map", "set", "queue", "stack",
            "algorithm", "iterator", "string", "iostream", "fstream", "sstream", "cmath", "cstdlib",
            "cstdio", "cstring", "cctype", "cstddef", "cstdint", "cassert", "ctime", "cstdarg", "clocale",
            "cuchar", "cwchar", "cwctype", "cstdio", "csetjmp", "cstdarg", "cstddef", "ciso646", "ccomplex",
            "cfenv", "cfloat", "cinttypes", "csignal", "cstdbool", "cstdint", "clocale", "complex", "fenv.h",
            "clocale", "iomanip", "ios", "iosfwd", "iostream", "istream", "ostream", "ios", "bitset",
            "deque", "list", "map", "queue", "set", "stack", "vector", "algorithm", "functional", "iterator",
            "memory", "numeric", "utility", "cmath", "complex", "valarray", "cstddef", "cstdlib", "ctime",
            "cassert", "cerrno", "cctype", "cstring", "cstdio", "cuchar", "cwchar", "cwctype", "ciso646",
            "ccomplex", "cfenv", "cfloat", "cinttypes", "csignal", "cstdbool", "cstdint", "clocale", "locale",
            "csetjmp", "cstdarg", "cstddef", "ciso646", "ccomplex", "cfenv", "cfloat", "cinttypes", "csignal",
            "cstdbool", "cstdint", "clocale", "initializer_list"
        };
        #endregion

        #region Python
        public static List<string> PythonKeywords = new List<string>
        {
            "False", "None", "True", "and", "as", "assert", "async", "await", "break", "class", "continue", "def", "del", "elif", "else", "except",
            "False", "finally", "for", "from", "global", "if", "import", "in", "is", "lambda", "nonlocal", "not", "or", "pass", "raise", "return", "True",
            "try", "while", "with", "yield"
        };

        public static List<string> PythonFunctions = new List<string>
        {
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

        #endregion


        #endregion

        public static string version = "1.4.7";
        public static bool autoCheckForUpdate = Settings.Default.AutoCheckForUpdate;
        public static bool ShowUpdateNodes = Settings.Default.ShowUpdateNodes;

        public static bool livepreview = Settings.Default.htmlLivePreview;

        public static ConsoleSystem devCon = new ConsoleSystem(600, 300, ConsoleSystem.FormStyle.Normal);
        public static bool devMode = false;
        public static bool start_with_file = false;

        public static bool isSaved = false;
        public static string currentFilePath;
        public static string currentFileName;

        public static string lastSavedContent;
        public static string currentContent;

        public enum FileType
        {
            CSharp,
            CPP,
            Python,
            HTML,
            Text,
            Default
        }

        public static FileType fileType = FileType.Default;
        public static string editorTheme = Settings.Default.currentEditorTheme;

        //  Setting var
        public static bool AutoCompleteCode = Settings.Default.AutoCode;
        public static bool AutomaticCharacterHelp = Settings.Default.AutoChar;
    }
}
