using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_lab_01;
using System.Data;
using System.IO;
using System.Xml;


namespace FizzBuzzGame_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }
            FizzBuzz fb = new FizzBuzz();
            int x = int.Parse(args[0]);
            StreamWriter f = new FileInfo(@"Napisy.txt").CreateText();
            ZapisDoXML xm = new ZapisDoXML();


            for (int i = 1; i < x; i++)
            {
                var co = fb.Play(i).ToString();
                f.WriteLine(co);
                xm.ZapiszDoFormatuXML();
            }  
            f.Close();
        }
    }

    interface Zapisywaczka
    {
        void ZapiszDoFormatuXML(IEnumerable<string> kolekcja);
    }

    public class ZapisDoXML : Zapisywaczka
    {
        private XmlDocument xDoc;
        public void ZapiszDoFormatuXML(IEnumerable<string> kolekcja)
        {
            using (XmlWriter writter = XmlWriter.Create(@"Napis.xml"))
            {
                xDoc.CreateElement("Napis.xml");
                
                writter.WriteStartDocument();

                foreach (string item in kolekcja)
                {
                    if (item != null)
                    {
                        writter.WriteStartElement("liczba");
                        writter.WriteString(item);
                        writter.WriteEndElement();
                    }
                }

                writter.WriteEndDocument();
                xDoc.Save(writter);
            }
        }
	}
}

