using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloWorldAPI
{
    internal class ObjectFactory
    {
        private Dictionary<string, string> targetDict = new Dictionary<string, string>();
        private Dictionary<string, Object> objectDict = new Dictionary<string, Object>();

        public ObjectFactory(String str)
        {
            targetDict = LoadConfigData(str);
        }

        private Dictionary<string, string> LoadConfigData(string str)
        {
            return XDocument
                .Load(str)
                .Descendants("targets")
                .Descendants("target")
                .ToDictionary(
                    p => p.Attribute("key").Value,
                    p => p.Attribute("value").Value
                );
        }




        public Object GetTypeInstance(string key)
        {
            Object obj = null;
            if (objectDict.TryGetValue(key, out obj))
                return obj;

            string className = null;
            targetDict.TryGetValue(key, out className);
            if (className == null)
                return null;

            Type type = Type.GetType(className);
            if (type == null)
                return null;
            objectDict[key] = (Object)Activator.CreateInstance(type);
            return objectDict[key];

        }
    }

}
