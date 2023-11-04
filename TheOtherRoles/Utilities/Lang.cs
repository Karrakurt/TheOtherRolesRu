using MonoMod.Utils;
using System.Collections.Generic;
using System.IO;

namespace TheOtherRoles.Utilities
{
    internal class Lang
    {
        private static readonly string EMBEDDED_LANG_PATH = "TheOtherRoles.Resources.Txt.embeddedLanguage.json";
        private static readonly string EXTERNAL_LANG_PATH = Path.Combine(Directory.GetCurrentDirectory(), "BepInEx", "plugins", "language.json");
        private static readonly LangDictionary _dict = new();
        public static string Get(string key)
        {
            if (_dict.Count == 0) Load();
            return _dict[key];
        }

        private static void Load()
        {
            string s = Helpers.readTextFromResources(EMBEDDED_LANG_PATH);
            if (JSON.FromString(s, out LangDictionary d)) _dict.AddRange(d);
            System.Console.WriteLine($"Looking for external language");
            if (File.Exists(EXTERNAL_LANG_PATH))
            {
                System.Console.WriteLine($"External language is foung. Trying to load");
                if (JSON.FromFile(EXTERNAL_LANG_PATH, out LangDictionary extLang))
                {
                    System.Console.WriteLine($"Loading language {extLang["Language"]}({extLang["TranslatedLanguage"]})");
                    foreach (var item in extLang)
                        _dict[item.Key] = item.Value;
                    System.Console.WriteLine($"Loaded {extLang.Count} pairs");
                }
            }
            else
                System.Console.WriteLine($"External language not found");
        }

        private class LangDictionary : Dictionary<string, string>
        {
            public new string this[string key]
            {
                get => TryGetValue(key, out string s) ? s : "";
                set => base[key] = value;
            }
        }
    }
}