using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;
using Newtonsoft.Json;

namespace pr6

{
    public class Programm
    {
        static void Main()
        {
            string b;
            Filefile.Menu();

            ConsoleKeyInfo f1;
            f1 = Console.ReadKey();

            if (f1.Key == ConsoleKey.F1)
            {
                Console.Clear();
                Console.WriteLine("Введите путь к вашему файлу");
                Console.WriteLine("-------------------------------");
                b = Console.ReadLine();
                File.Create($"{b}").Close();    
                String b2 = b.Substring(b.Length - 4);
                if (b2 == ".txt")
                {
                    string text1 = "";
                    foreach (var item in Filefile.PeopleList)
                    {
                        text1 += item.name;
                        text1 += "\n";
                        text1 += item.age;
                        text1 += "\n";
                        text1 += item.favouritefood;
                    }
                    File.WriteAllText($"{b}", text1);


                }
                if (b2 == "json")
                {

                    string jsontext = JsonConvert.SerializeObject(Filefile.PeopleList);
                    Console.WriteLine($"{Filefile.PeopleList}");
                    File.AppendAllText($"{b}", jsontext);
                    
                }
                if (b2 == ".xml")
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Filefile>));
                    using (FileStream fs = new FileStream($"{b}", FileMode.OpenOrCreate))
                    {
                           xml.Serialize(fs, Filefile.PeopleList);
                    }
                }
            }
        }
    }
}

