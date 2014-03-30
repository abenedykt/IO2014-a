using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using tdd;

namespace konsola
{
    class Program
    {
        static IEnumerable<string> Generuj(int ile, FizzBazz fb)
        {
            List<string> lista = new List<string>();

            for (int i = 1; i <= ile; i++)
            {
                string item = fb.Play(i);
                lista.Add(item);
            }

            return lista;
        }

        static void Main(string[] args)
        {
            //if (args.Length == 0)
            //    return;
            //StreamWriter file = new FileInfo("default.txt").CreateText();
            //int ile = int.Parse(args[0]);
            //FizzBazz fb = new FizzBazz();
            //for (int i = 1; i <= ile; i++)
            //{
            //    string item = fb.Play(i);
            //    file.WriteLine(item);
            //}
            //file.Close();

            if (args.Length < 2)
            {
                Console.WriteLine("Wymaga 2 argumentów: 1 - liczba, 2 - typ pliku zapisywanego (txt, xml, json)");
                Console.ReadLine();
                return;
            }

            string arg1 = args[0];
            string agr2 = args[1];

            int ile;

            try
            {
                ile = int.Parse(arg1);
            }
            catch (Exception)
            {
                Console.WriteLine("Argument 1 musi być liczbą całkowitą dodatnią!");
                Console.ReadLine();
                return;
            }

            if (agr2 != "txt" && agr2 != "xml" && agr2 != "json")
            {
                Console.WriteLine("Dozwolone postacie argumentu 2 (z lewej):");
                Console.WriteLine("txt - zapis do pliku tekstowego");
                Console.WriteLine("xml - zapis do pliku XML");
                Console.WriteLine("json - zapis do pliku JSON");
                Console.ReadLine();
                return;
            }
            IZapisywaczka zapis = null;
            if (agr2 == "txt")
                zapis = new TXTZapis();
            else if (agr2 == "xml")
                zapis = new XMLZapis();
            else if (agr2 == "json")
                zapis = new JSONZapis();

            IEnumerable<string> kolekcja = Generuj(ile, new FizzBazz());
            zapis.Zapisz(kolekcja);

            Console.WriteLine("Zapisano!");
            Console.ReadLine();
        }
    }

    interface IZapisywaczka
    {
        void Zapisz(IEnumerable<string> collection);
    }

    class TXTZapis : IZapisywaczka
    {
        public void Zapisz(IEnumerable<string> collection)
        {
            string[] array = collection.ToArray();
            using (StreamWriter file = new FileInfo("default.txt").CreateText())
            {
                for (int i = 0; i < array.Length; i++)
                {
                    file.WriteLine(string.Format("{0} - {1}", (i + 1), array[i]));
                }
            }
        }
    }

    class XMLZapis : IZapisywaczka
    {
        public void Zapisz(IEnumerable<string> collection)
        {
            string[] array = collection.ToArray();
            using (XmlWriter file = XmlWriter.Create("default.xml", new XmlWriterSettings() { Indent = true, IndentChars = "\t", NewLineOnAttributes = false }))
            {
                file.WriteStartDocument();

                file.WriteStartElement("fizzbuzz");

                for (int i = 0; i < array.Length; i++)
                {
                    file.WriteStartElement("liczba");
                    file.WriteAttributeString("x", (i + 1).ToString());
                    file.WriteString(array[i]);
                    file.WriteEndElement();
                }

                file.WriteEndElement();

                file.WriteEndDocument();
            }
        }
    }

    class JSONZapis : IZapisywaczka
    {
        public void Zapisz(IEnumerable<string> collection)
        {
            int l = 0;
            Dictionary<int, string> dictionary = collection.ToDictionary(n => ++l);
            using (StreamWriter file = new FileInfo("default.json").CreateText())
            {
                string json = JsonConvert.SerializeObject(dictionary, new JsonSerializerSettings() { Formatting = Newtonsoft.Json.Formatting.Indented });
                file.Write(json);
            }
        }
    }
}
