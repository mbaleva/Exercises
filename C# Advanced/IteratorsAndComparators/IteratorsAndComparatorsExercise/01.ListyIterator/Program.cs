using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string cmd = string.Empty;

            while ((cmd = Console.ReadLine())!="END")
            {
                try
                {
                    string[] arr = cmd
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string command = arr[0];
                    switch (command)
                    {
                        case "Create":
                            List<string> elements = arr
                                 .Skip(1)
                                 .ToList();
                            listyIterator = new ListyIterator<string>(elements);
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "PrintAll":
                            listyIterator.PrintAll();
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
