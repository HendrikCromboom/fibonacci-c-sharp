using System;
using System.Collections.Generic;

namespace FibonacciNumbers
{
    class Program
    {
        private static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> {1, 1};

            while(fibonacciNumbers[(fibonacciNumbers.Count)- 1] >0){
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach(var item in fibonacciNumbers)
                if (item > 0) {
                    Console.WriteLine(item);
                }
        }
    } 
}
