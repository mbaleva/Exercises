using System;
using System.Linq;
using System.Collections.Generic;


namespace _07.StoreBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> itemBoxes = new List<Box>();

            double totalPrice = 0.00;

            while (true)
            {
                string conditionToStopTheLoop = Console.ReadLine();

                if (conditionToStopTheLoop == "end")
                {
                    break;
                }

                string[] command = conditionToStopTheLoop.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = command[0];
                string itemName = command[1];
                int count = int.Parse(command[2]);
                double priceForOneBox = double.Parse(command[3]);

                Box box = new Box();

                totalPrice = count * priceForOneBox;

                box.SerialNumber = serialNumber;
                box.ItemName = itemName;
                box.ItemQuantity = count;
                box.PricePerOneBox = priceForOneBox;
                box.TotalPrice = totalPrice;

                itemBoxes.Add(box);
            }
            List<Box> sortedBox = itemBoxes.OrderBy(boxes => boxes.TotalPrice).ToList();
            sortedBox.Reverse();

            foreach (Box item in sortedBox)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.ItemName} - ${item.PricePerOneBox:F2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.TotalPrice:F2}");
            }
        }
    }
   
    public class Box
    {

       
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double PricePerOneBox { get; set; }
        public double TotalPrice { get; set; }
    }
}
