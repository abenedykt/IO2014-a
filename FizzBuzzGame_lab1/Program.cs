using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
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

            for (int i = 1; i <= x; i++)
            {
                string co = fb.Play(i).ToString();
                f.WriteLine(co);

                xm.ZapiszDoFormatuXML(new[] {co});
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

            // zapis do pliku XML ale tylko ostaniego argumentu
            foreach (var item in kolekcja)
            {
                    XDocument src = new XDocument(
                    new XElement("Liczby",
                            new XElement("liczba",item)
                     ));

                src.Save("Napis.xml");
            }

            
            //writter.WriteStartDocument();
            //foreach (string item in kolekcja)
            //{
            //    if (item != null)
            //    {
            //        writter.WriteStartElement("Liczby");
            //        writter.WriteElementString("Liczba",item);
            //        writter.WriteEndElement();
            //    }
            //}
            //writter.WriteEndDocument();
            //writter.Flush();
            //writter.Close();

        }
    }

}

