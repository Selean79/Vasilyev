using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // сохранение данных
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Иванов", "Иван"));
            persons.Add(new Person("Петров", "Петр"));

            FileStream fsout = new FileStream("peoples.dat", FileMode.Create, FileAccess.Write);
            XmlSerializer serializerout = new XmlSerializer(typeof(List<Person>),
                new Type[] { typeof(Person) });
            serializerout.Serialize(fsout, persons);
            fsout.Close();

            // загрузка данных
            List<Person> persons1 = new List<Person>();
            FileStream fsin = new FileStream("peoples.dat", FileMode.Open, FileAccess.Read);
            XmlSerializer serializerin = new XmlSerializer(typeof(List<Person>),
                new Type[] { typeof(Person) });
            persons1 = (List<Person>)serializerin.Deserialize(fsin);
            fsin.Close();

            // проверяем
            foreach (Person p in persons1)
                Console.WriteLine(p.FirstName);
            Console.ReadLine();
        }
    }
}
