using System.IO;
using System.Text.Json;

internal class JSON
{
    public static string ToString<T>(T t, JsonSerializerOptions options = null) => ToString(t, out string s, options) ? s : "";

    public static bool ToString<T>(T t, out string s, JsonSerializerOptions options = null)
    {
        try
        {
            s = JsonSerializer.Serialize(t, options ?? new JsonSerializerOptions() { WriteIndented = true });
            return true;
        }
        catch { }
        s = "";
        return false;
    }

    public static T FromString<T>(string s, JsonSerializerOptions options = null) => FromString(s, out T t, options) ? t : default;

    public static bool FromString<T>(string s, out T t, JsonSerializerOptions options = null)
    {
        try
        {
            t = JsonSerializer.Deserialize<T>(s, options ?? new JsonSerializerOptions() { WriteIndented = true });
            return true;
        }
        catch { }
        t = default;
        return false;
    }

    public static bool ToFile<T>(string path, T t, JsonSerializerOptions options = null)
    {
        try
        {
            File.WriteAllText(path, ToString(t, options));
            return true;
        }
        catch { }
        return false;
    }

    public static T FromFile<T>(string path, JsonSerializerOptions options = null) => FromFile(path, out T t, options) ? t : default;

    public static bool FromFile<T>(string path, out T t, JsonSerializerOptions options = null)
    {
        if (File.Exists(path))
            try
            {
                t = FromString<T>(File.ReadAllText(path), options);
                return true;
            }
            catch { }
        t = default;
        return false;
    }
}
