using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using Newtonsoft.Json;
using TDD_Lab_01;

namespace FissBassConsole
{
    interface ISaver
    {
        void ToTxt(IEnumerable<ReturnType> fissBassCollection);
        void ToXml(IEnumerable<ReturnType> fissBassCollection);
        void ToJson(IEnumerable<ReturnType> fissBassCollection);
    }

    public class Saver : ISaver
    {
      
        public void ToTxt(IEnumerable<ReturnType> fissBassCollection)
        {
            using (var sw = new StreamWriter("file.txt"))
            {
                foreach (var item in fissBassCollection)
                {
                    sw.Write(item.Value  + ",");
                }
            }
        }
        public void ToXml(IEnumerable<ReturnType> fissBassCollection)
        {
            using (var writer = XmlWriter.Create("file.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("FissBass");

                foreach (var item in fissBassCollection)
                {
                    writer.WriteStartElement("liczba");
                    writer.WriteAttributeString("ID",item.ID.ToString());
                    writer.WriteString(item.Value);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        public void ToJson(IEnumerable<ReturnType> fissBassCollection)
        {
            var json = JsonConvert.SerializeObject(fissBassCollection);
            //write string to file
            File.WriteAllText("file.json", json);
        }
    }
}
