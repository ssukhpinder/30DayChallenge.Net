using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _30DayChallenge.Net.Day30
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public static class EfficientSerialization
    {
        public static string XML<T>(T obj)
        {

            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
        public static string JSON<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
