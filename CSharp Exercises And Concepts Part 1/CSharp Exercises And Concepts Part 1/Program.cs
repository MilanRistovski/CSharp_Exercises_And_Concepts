using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_Exercises_And_Concepts_Part_1
{
    class Program
    {
        public static object Teams { get; private set; }

        static void Main(string[] args)
        {
            //string path = @"C:\Code\Chapter03";
            //Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            //string message = string.Empty;

            //message = s switch
            //{
            //    FileStream writeableFile when s.CanWrite => "The stream is a file that I can write to.",
            //    FileStream readOnlyFile => "The stream is a read-only file.",
            //    MemoryStream ms => "The stream is a memory address",
            //    null => "The stream is null",
            //};
            //Console.WriteLine(message);

            //string password = string.Empty;
            //int tries = 0;
            //do
            //{
            //    Console.WriteLine("Enter Your Password");
            //    password = Console.ReadLine();
            //    tries++;

            //    if (tries > 4)
            //    {
            //        Console.WriteLine("Out of opportunities");
            //    }

            //    if (tries <= 4 && password == "Stojanche") 
            //    {
            //        Console.WriteLine("Correctemundo");
            //    }
            //}
            //while (password != "Stojanche" && tries <= 4);

            ////Console.WriteLine("Correctemundo");
            ///
            //string[] names = { "Stole", "Trajce", "Kurto" };

            //IEnumerator e = names.GetEnumerator();
            //while(e.MoveNext())
            //{
            //    string name = (string)e.Current;
            //    Console.WriteLine($"{name} has {name.Length} characters");
            //}

            //double c = 9.8;
            //int d = (int)c;
            //Console.WriteLine(d);

            //double g = 8.2;
            //decimal f = (decimal)g;
            //Console.WriteLine(f);

            //double m = 72.6;
            //int n = Convert.ToInt32(m);
            //Console.WriteLine(n);

            //double[] doubles = new[] { 4.49, 5.50, 6.66, 9.99, 2.34 };

            //foreach (double x in doubles)
            //{
            //    Console.WriteLine($"Zaokruzena vrednost e {Convert.ToInt32(x)}");
            //}

            //double[] newDoubles = { 4.44, 3.67, 5.50, 4.99, 10.21 };
            //foreach (double z in newDoubles) 
            //{
            //    Console.WriteLine(Math.Round(z));
            //}

            //int number = 22;
            //Console.WriteLine(number.ToString());

            //bool boolean = true;
            //Console.WriteLine(boolean.ToString());

            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.ToString());

            //object random = new object();
            //Console.WriteLine(random.ToString());

            //int age = int.Parse("27");
            //DateTime birthday = DateTime.Parse("29 September 1992");

            //Console.WriteLine($"I am {age} years old, born on {birthday}");

            //Console.WriteLine("How Many eggs are there?");
            //int count;

            //string input = Console.ReadLine();
            //if (int.TryParse(input, out count))
            //{
            //    Console.WriteLine($"There are {count} eggs");
            //}
            //else 
            //{
            //    Console.WriteLine("I could not parse this input");
            //}

            //Console.WriteLine("Before parsing");
            //Console.WriteLine("Enter Your Age");

            //string input = Console.ReadLine();

            //try
            //{
            //    int age = int.Parse(input);
            //    Console.WriteLine($"You're {age} old");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.GetType()} says {ex.Message}");

            //}
            //Console.WriteLine("After Parsing");

            //checked { 
            //int x = int.MaxValue - 1;
            //Console.WriteLine($"Initial value : {x}");
            //x++;
            //Console.WriteLine($"After incrementing: {x}");
            //x++;
            //Console.WriteLine($"After another incrementation: {x}");
            //x++;
            //Console.WriteLine($"After ANOTHER ANOTHER incrementation: {x}");
            //}
            //try 
            //{
            //    checked
            //    {
            //        int x = int.MaxValue - 1;
            //        Console.WriteLine($"Initial value : {x}");
            //        x++;
            //        Console.WriteLine($"After incrementing: {x}");
            //        x++;
            //        Console.WriteLine($"After another incrementation: {x}");
            //        x++;
            //        Console.WriteLine($"After ANOTHER ANOTHER incrementation: {x}");
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The code is overflowed but I caught the exception.");
            //}

            //static void TimesTable(byte number)
            //{
            //    Console.WriteLine($"This is the {number} times table: ");
            //    for (int row = 1; row <= 12; row++)
            //    {
            //        Console.WriteLine($"{row} x {number} = {row * number}");
            //    }
            //    Console.WriteLine();
            //}

            //static void RunFunction()
            //{
            //    bool isNumber;
            //    do
            //    {
            //        Console.WriteLine("Enter a number between 0 and 255");
            //        isNumber = byte.TryParse(Console.ReadLine(), out byte number);

            //        if (isNumber)
            //        {
            //            TimesTable(number);
            //        }
            //        else
            //        {
            //            Console.WriteLine("You did not enter a valid number");
            //        }
            //    }
            //    while (isNumber);
            //}
            //RunFunction();

            //static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
            //{
            //    decimal rate = 0.0M;
            //    switch(twoLetterRegionCode)
            //    {
            //        case "CH":
            //            rate = 0.08M;
            //            break;

            //        case "MK":
            //            rate = 0.10M;
            //            break;

            //        case "GR":
            //            rate = 0.12M;
            //            break;
            //        default:
            //            break;
            //    }
            //    return rate * amount;
            //}

            //static void RunCalculateTax ()
            //{
            //    Console.WriteLine("Enter your amount:");
            //    string amountInText = Console.ReadLine();

            //    Console.WriteLine("Enter a two-letter code for your country");
            //    string region = Console.ReadLine();

            //    if (decimal.TryParse(amountInText, out decimal amount))
            //    {
            //        decimal taxToPay = CalculateTax(amount, region);
            //        Console.WriteLine($"You must pay {taxToPay} in taxes");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("No valid amount was entered");
            //    }
            //}
            //RunCalculateTax();

            //static string CardinalToOrdinal(int number) 
            //     {
            //     switch(number)
            //     {
            //         case 11:
            //         case 12:
            //         case 13:
            //             return $"{number}th";

            //         default:
            //             string numberAsText = number.ToString();
            //             char lastDigit = numberAsText[numberAsText.Length - 1];
            //             string suffix = string.Empty;

            //             switch(lastDigit) 
            //             {
            //                 case '1':
            //                     suffix = "st";
            //                     break;
            //                 case '2':
            //                     suffix = "nd";
            //                     break;
            //                 case '3':
            //                     suffix = "rd";
            //                     break;
            //                 default:
            //                     suffix = "th";
            //                     break;
            //             }
            //             return $"{number}{suffix}";
            //     }
            // }
            // static void RunFunction()
            // {
            //     for (int number = 1; number <= 40; number++)
            //     {
            //         Console.WriteLine($"{CardinalToOrdinal(number)}");
            //     }
            //     Console.WriteLine();
            // }
            // RunFunction();

            //static int Factorial (int number)
            //{
            //    if(number < 1)
            //    {
            //        return 0;
            //    }
            //    else if (number == 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return number * Factorial(number - 1);
            //    }
            //}

            //static void RunFactorial()
            //{
            //    bool isNumber;
            //    do
            //    {
            //        Console.WriteLine("Enter a number:");

            //        isNumber = int.TryParse(Console.ReadLine(), out int number);

            //        if (isNumber)
            //        {
            //            Console.WriteLine($"{number:N0}! = {Factorial(number): N0}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("You did not enter a valid number!");
            //        }
            //    }
            //    while (isNumber);
            //}
            //RunFactorial();

            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1999, 9, 22);
            bob.Teams = FavouriteTeams.Genoa;
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Stojanka" });

            //Console.WriteLine($"The name of the Person is {bob.Name}, born on {bob.DateOfBirth}");
            Console.WriteLine(format: "{0}'s favourite team is {1}, with an integer of {2}", arg0: bob.Name, arg1: bob.Teams, arg2: (int)bob.Teams);

            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7),
                Teams = FavouriteTeams.Internazionale
            };
            Console.WriteLine(format: "{0} was born on {1:dd MMM yy}... and the person's favourite team is {2}", arg0: alice.Name,
                arg1: alice.DateOfBirth, arg2: alice.Teams);

            var stole = new Person
            {
                Name = "Stole",
                DateOfBirth = new DateTime(1991, 8, 19),
                Teams = FavouriteTeams.Arsenal
            };
            Console.WriteLine($"{stole.Name}'s favourite teams are {stole.Teams}");

            Console.WriteLine($"{bob.Name} has {bob.Children.Count} children");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                Console.WriteLine($"The names of the children are {bob.Children[child].Name}");
            }

            var randomAccount = new BankAccount();
            BankAccount.InterestRate = 0.08m;

            randomAccount.AccountName = "Stole Stoilov";
            randomAccount.Balance = 2241.19m;

            //Console.WriteLine(format: "{0} has a balance of {1}. The interest rate is {2}. He will have to pay {5} in taxes.", arg0: randomAccount.AccountName, arg1: randomAccount.Balance, arg2: BankAccount.InterestRate); //**/*arg4:randomAccount.Balance * BankAccount.InterestRate*/);*/*/

            var newPerson = new Person("Trajche", "Pluto");
            Console.WriteLine($"{newPerson.Name} is the name, who comes from {newPerson.HomePlanet}. His profile was created on {newPerson.Instantiated}");

            bob.WriteToConsole();
            Console.WriteLine(bob.GetOrigin());
            Console.WriteLine(bob.GetInfo());

            var thing1 = ("Neville", 4);
            Console.WriteLine($"{thing1.Item1} and {thing1.Item2}");

            var thing2 = (bob.Name, bob.Children.Count);
            Console.WriteLine($"{ thing2.Name} has {thing2.Count} children");

            //(string name, int age) tupleWithNamedFields = GetPerson();
            //tupleWithNamedFields.age = 22;
            //t

            Console.WriteLine(bob.SayHello());
            Console.WriteLine(bob.SayHelloTo("Stojanka"));

            Console.WriteLine(bob.OptionalParameters("Jump!", 88.2));

            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine($"Before: a = {a}; b = {b}; c = {c}");

            bob.PassingParameters(a, ref b, out c);
            Console.WriteLine($"AFter: a = {a}, b = {b}, c = {c}");

            int d = 15;
            int e = 25;
            bob.PassingParameters(d, ref e, out int f);

            Console.WriteLine($"After: d = {d}; e = {e}; f = {f}");
            var Sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };

            Console.WriteLine(Sam.Origin);
            Console.WriteLine(Sam.Greeting);
            Console.WriteLine(Sam.Age);
            Sam.FavoriteIceCream = "ChocoLoco ";
            Sam.FavoritePrimaryColor = "Red";

            Console.WriteLine($"Sams favorite ice cream {Sam.FavoriteIceCream}. Sam's fave color: {Sam.FavoritePrimaryColor}");

            var Trajko = new Person { Name = "Trajko" };
            var Liljana = new Person { Name = "Liljana" };
            var Stefanka = new Person { Name = "Stefanka" };
            var Ilija = new Person { Name = "Ilija" };

            var baby1 = Trajko.ProcreateWith(Liljana);
            var baby2 = Trajko.ProcreateWith(Stefanka);
            baby2.Name = "Post Malone";
            var baby3 = Person.Procreate(Ilija, Stefanka);
            Console.WriteLine($"{Trajko.Name} with {Stefanka.Name} have a children with a name of {baby2.Name}");

            Console.WriteLine($"{Stefanka.Name} has {Stefanka.Children.Count} children");

            Employee john = new Employee
            {
                Name = "Johnny Depp",
                DateOfBirth = new DateTime(1992, 11, 22)
            };

            john.EmployeeCode = "PP2345AA";
            john.HireDate = new DateTime(2014, 9, 10);
            john.WriteToConsole();

            Employee aliceInEmployee = new Employee { Name = "Alice", EmployeeCode = "AA123" };
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            Console.WriteLine(aliceInEmployee.ToString());
            Console.WriteLine(aliceInPerson.ToString());

            var John = new Person
            {
                Name = "Johnny",
                DateOfBirth = new DateTime(1112, 11, 23)
            };

            try
            {
                John.TimeTravel(new DateTime(1111, 12, 22));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string email2 = "pamela@test.com";
            string email3 = "Milojko#test.com";
            //Console.WriteLine(StringExtensions.IsValidEmail(email2));
            //Console.WriteLine(StringExtensions.IsValidEmail(email3));
            Console.WriteLine(email2.IsValidEmail());
            Console.WriteLine(email3.IsValidEmail());

            var cities = new List<string>();
            cities.Add("Stojakovo");
            cities.Add("Sviripichino");

            foreach (var city in cities)
            {
                Console.WriteLine($"{ city}");
            }
            cities.Insert(2, "Mariovo");
            //cities.Sort()

            var keywords = new Dictionary<string, string>();
            keywords.Add("Stojakovo", "Trajonvski");
            keywords.Add("Mariovo", "Marjanovich");

            foreach (KeyValuePair<string, string> item in keywords)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var immutableCities = cities.ToImmutableList();
            var newList = immutableCities.Add("Rio");
            foreach (string city in immutableCities)
            {
                Console.WriteLine($"{city}");
            }
            Console.WriteLine();

            foreach (string city in newList)
            {
                Console.WriteLine($"{city}");
            }
            Console.WriteLine();

        }
    }
}
