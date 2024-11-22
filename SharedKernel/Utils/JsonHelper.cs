using System.Text.Json;

namespace Shared.Utils
{
    public static class JsonHelper
    {
        public static string Serialize<T>(T obj) => JsonSerializer.Serialize(obj);

        public static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json);
    }
}