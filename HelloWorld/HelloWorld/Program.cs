using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 rows, 5 columns
            // var matrix = new int[3, 5];
            var matrix = new int[3, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15}
            };

            // Jagged array
            // var array = new int[3][];
            
            /*int[] numbers = new int[] {3, 7, 8, 1, 3, 2};
            int index = Array.IndexOf(numbers, 7);
            Console.WriteLine(index);
            
            Array.Clear(numbers, 0, 3);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/

            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(4);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}