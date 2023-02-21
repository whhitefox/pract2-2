using Newtonsoft.Json;
using System;
using System.IO;

namespace Pract2
{
    public class Serializer
    {
        public static T Load<T>(string filename)
        {
            string put = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!File.Exists($"{put}\\{filename}"))
            {
                if (!Directory.Exists(put))
                {
                    Directory.CreateDirectory(put);
                }
                File.WriteAllText($"{put}\\{filename}", "");
            }

            string data = File.ReadAllText($"{put}\\{filename}");
            T list = JsonConvert.DeserializeObject<T>(data);
            return list;
        }

        public static void Save<T>(T data, string filename)
        {
            string put = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!Directory.Exists(put))
            {
                Directory.CreateDirectory(put);
            }

            string convertedData = JsonConvert.SerializeObject(data);
            File.WriteAllText($"{put}\\{filename}", convertedData);
        }
    }
}
