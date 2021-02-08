using System;

namespace _01.ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

            double length = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length,width,height);
            Console.WriteLine(box.Calculate());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Съкровището книгата на тайните
        }
    }
}
