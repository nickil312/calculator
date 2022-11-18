using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace pr6
{
    public class Filefile
    {
        public string age;
        public string name;
        public string favouritefood;
        static public string Ck_age = "";
        static public string Ck_name = "";
        static public string Ck_favouritefood = "";
        static public List<Filefile> PeopleList = new List<Filefile>();
        public Filefile()
        {
        }
        public Filefile(string age, string favouritefood, string name)
        {
            
            
            this.age = age;
            this.favouritefood = favouritefood;
            this.name = name;
        }

        public void A()
        {

        }
        public static void Menu()
        {
            string a;
            string b;
            Console.WriteLine("Введите путь к вашему файлу");
            Console.WriteLine("-------------------------------");
            a = Console.ReadLine();

            String a2 = a.Substring(a.Length - 4);
            if (a2 == ".txt")
            {
                Filefile Gregor = new Filefile();
                string firstLine = File.ReadLines($"{a}").ElementAtOrDefault(0);
                Gregor.name = firstLine;
                Ck_name = firstLine;
                //PeopleList.Add(Gregor.name);
                Console.WriteLine(Gregor.name);
                //Console.WriteLine(Ck_name);

                string secondLine = File.ReadLines($"{a}").ElementAtOrDefault(1);
                Gregor.age = secondLine;
                Ck_age = secondLine;
                //PeopleList.Add(Gregor.age);
                Console.WriteLine(Gregor.age);
                //Console.WriteLine(Ck_age);

                string thirdLine = File.ReadLines($"{a}").ElementAtOrDefault(2);
                Gregor.favouritefood = thirdLine;
                Ck_favouritefood = thirdLine;
                Console.WriteLine(Gregor.favouritefood);


                //Console.WriteLine(Ck_favouritefood);
                //PeopleList.Add(Gregor.favouritefood);
                PeopleList.Add(Gregor);
                //Console.WriteLine(Gregor);
                //return"";
            }
            if (a2 == "json")
            {
                int i;
                string text = File.ReadAllText($"{a}");
                PeopleList = JsonConvert.DeserializeObject<List<Filefile>>(text);
                foreach (var item in PeopleList)
                {
                    Console.WriteLine(item.name);
                    Console.WriteLine(item.age);
                    Console.WriteLine(item.favouritefood);
                }
                Console.ReadKey();
                //return "";
                


            }
            if (a2 == ".xml")
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Filefile>));
                using (FileStream fs = new FileStream($"{a}", FileMode.Open))
                {
                    PeopleList = (List<Filefile>)xml.Deserialize(fs);
                }
            }

            

            
            

            
        }
    }
}

