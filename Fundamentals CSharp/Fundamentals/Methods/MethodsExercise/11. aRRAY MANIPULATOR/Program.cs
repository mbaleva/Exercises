using System;
using System.Linq;


namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            string input = string.Empty;

            while ((input=Console.ReadLine())!="end")
            {
                string[] command = input.Split();

               
                if (command[0]=="exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index<0||index>arr.Length-1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(arr, index);
                }
                else if (command[0]=="max")
                {
                    if (command[1]=="even")
                    {
                        if (MaxEven(arr)==-1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(arr));
                    }
                    else if (command[1] == "odd")
                    {
                        if (MaxOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxOdd(arr));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(arr));
                    }
                    else if (command[1] == "odd")
                    {
                        if (MinOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinOdd(arr));
                    }
                }
                else if (command[0]=="first")
                {
                    int count = int.Parse(command[1]);
                    if (count>arr.Length||count<0)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2]=="even")
                    {
                        ReturnFirstEven(arr, count);
                    }
                    else if (command[2] == "odd")
                    {
                        ReturnFirstOdd(arr, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);

                    if (count > arr.Length||count<0)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2]=="even")
                    {
                        ReturnLastEven(arr, count);
                    }
                    else if (command[2] == "odd")
                    {
                        ReturnLastOdd(arr, count);
                    }
                }
            }
            Console.WriteLine("["+String.Join(", ",arr)+"]");
        }
       static void Exchange(int[] array, int index)
        {
            //17 16 15 14 13 12 11
            //14 13 12 11 17 16 15
            //11 17 16 15 14 13 12

            int[] firstArray = new int[array.Length-index-1];
            int[] secondArray = new int[index+1];

            int firstArrayCounter = 0;
            for (int i = index+1; i < array.Length; i++)
            {
                firstArray[firstArrayCounter] = array[i];
                firstArrayCounter++;
            }
            for (int i = 0; i < index+1; i++)
            {
                secondArray[i] = array[i];
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                array[i] = firstArray[i];
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                array[firstArray.Length + i] = secondArray[i];
            }
        }
        public static int MaxEven(int[] array)
        {
            int maxEven = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    if (array[i]>=maxEven)
                    {
                        maxEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int MaxOdd(int[] array)
        {
            int maxOdd = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int MinEven(int[] array)
        {
            int minEven = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEven)
                    {
                        minEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int MinOdd(int[] array)
        {
            int minOdd = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        public static void ReturnFirstEven(int[] array, int count)
        {
            int counter = 0;
            string numbers = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    numbers += array[i]+" ";
                    counter++;
                }
                if (counter>=count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter==0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("["+String.Join(", ",result)+"]");
            }
        }
        public static void ReturnFirstOdd(int[] array, int count)
        {
            int counter = 0;
            string numbers = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    numbers += array[i] + " ";
                    counter++;
                }
                if (counter >= count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
        public static void ReturnLastEven(int[] array, int count)
        {
            //1 3 5 4 5 8
            int counter = 0;
            string numbers = string.Empty;
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    counter++;
                    numbers += array[i] + " ";
                    
                }
                if (counter >= count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
        public static void ReturnLastOdd(int[] array, int count)
        {
            int counter = 0;
            string numbers = string.Empty;
            for (int i = array.Length-1; i >=0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    counter++;
                    numbers += array[i] + " ";
                    
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }

    }
}
