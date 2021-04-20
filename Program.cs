using System;
using System.Collections.Generic;

namespace ArrayExample_Grp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;

            Console.WriteLine("-------------Array--------------");
            // Create an int arrray of size 5
            int[] numbers = new int[arraySize];
            numbers[2] = 10;
            System.Console.WriteLine($"Size of array is {numbers.Length}");
            numbers[1] = 20;
            System.Console.WriteLine($"Size of array is {numbers.Length}");

            int index = 0;

            while(index < numbers.Length) {
                Console.WriteLine(numbers[index]);
                index++;
            }

            Console.WriteLine("------------List-------------------");

            List<int> numbersList = new List<int>();
            System.Console.WriteLine($"Size of List is {numbersList.Count}");
            numbersList.Add(10);
            System.Console.WriteLine($"Size of List is {numbersList.Count}");
            numbersList.Add(90);
            System.Console.WriteLine($"Size of List is {numbersList.Count}");
            numbersList.Add(80);
            System.Console.WriteLine($"Size of List is {numbersList.Count}");
            numbersList.Add(30);
            System.Console.WriteLine($"Size of List is {numbersList.Count}");
            numbersList.Add(20);

            index = 0;
            while(index < numbersList.Count) {
                Console.WriteLine(numbersList[index]);
                index++;
            }

            for(int i = 0; i < numbersList.Count; i++) {
                Console.WriteLine(numbersList[i]);
            }
        }
    }
}
