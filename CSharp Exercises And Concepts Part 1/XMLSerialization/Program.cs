using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using XMLSerialization;
using static System.Environment;
using static System.IO.Path;
using System.Threading.Tasks;
namespace XMLSerialization
{
    class Program
    {
        static async Task Main(string[] args)
        {


            var people = new List<Person>
            {
                new Person(3000M)
                {
                    FirstName = "Stole",
                    LastName = "Stoilov",
                    DateOfBirth = new DateTime(1992, 09, 29)

                },
                new Person(4000M)
                {
                    FirstName = "Milan",
                    LastName = "Ristovski",
                    DateOfBirth = new DateTime(1991, 10, 22)
                },
                new Person (2222M)
                {
                    FirstName = "Stojanka",
                    LastName = "Stefanovska",
                    DateOfBirth = new DateTime(1989, 11, 2),
                    Children = new HashSet<Person>
                    {
                        new Person(0M)
                        {
                            FirstName = "Trajanka",
                            LastName = "Trajanova",
                            DateOfBirth = new DateTime(2016, 3, 19)
                        }
                    }
                }
        };
            //var xs = new XmlSerializer(typeof(List<Person>));
            //string path = Combine(CurrentDirectory, "people.xml");

            //using (FileStream stream = File.Create(path))
            //{
            //    xs.Serialize(stream, people);
            //}
            //Console.WriteLine($"Written {new FileInfo(path).Length} bytes to {path}");y
            //Console.WriteLine();
            //Console.WriteLine(File.ReadAllText(path));

            string jsonPath = Combine(CurrentDirectory, "people.json");
            using (StreamWriter jsonStream = File.CreateText(jsonPath))
            {
                var jss = new Newtonsoft.Json.JsonSerializer();
                jss.Serialize(jsonStream, people);
            }
            Console.WriteLine();
            Console.WriteLine($"Written {new FileInfo(jsonPath).Length} bytes to {jsonPath}");
            Console.WriteLine(File.ReadAllText(jsonPath));

        }
    }
}