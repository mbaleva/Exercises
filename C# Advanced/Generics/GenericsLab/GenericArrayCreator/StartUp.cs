using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] something = ArrayCreator.Create(5, "Pesho");
            Console.WriteLine(string.Join(" ", something));
        }
    }
}
