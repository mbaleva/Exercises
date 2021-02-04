using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            
            while (true)
            {
                string firstLine = Console.ReadLine();

                if (firstLine == "Beast!")
                {
                    break;
                }

                string[] secondLine = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

               
                string name = secondLine[0];
                int age;
                if (!int.TryParse(secondLine[1], out age))
                {
                    throw new ArgumentException("Invalid input!");
                }

                string gender = secondLine[2];

                try
                {
                    switch (firstLine)
                    {
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine("Dog");
                            Console.WriteLine(dog.GetResult());
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine("Cat");
                            Console.WriteLine(cat.GetResult());
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine("Frog");
                            Console.WriteLine(frog.GetResult());
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age);
                            Console.WriteLine("Kitten");
                            Console.WriteLine(kitten.GetResult());
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            Console.WriteLine("Tomcat");
                            Console.WriteLine(tomcat.GetResult());
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}


