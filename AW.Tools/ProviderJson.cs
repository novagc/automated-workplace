using System.IO;
using System.Text;

namespace AW.Tools
{
    public static class ProviderJson
    {
        public static T DeserializeJsonFile<T>(string path) where T: class
        {
            if (File.Exists(path))
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(File.ReadAllText(path, Encoding.UTF8));
            }

            return null;
        }

        public static void SerializeToJsonFile<T>(T data, string path) where T : class
        {
            File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(data), Encoding.UTF8);
        }
    }
}
