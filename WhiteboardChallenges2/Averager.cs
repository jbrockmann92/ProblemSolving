using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class Averager
    {
        double number;
        public void GetAverage()
        {
            double result;

            Console.WriteLine("How many numbers would you like to find the average of?");
            int numOfNumbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfNumbers; i++)
            {
                Console.WriteLine($"Please enter number {i}");
                double numInput = double.Parse(Console.ReadLine());
                number += numInput;
            }
            result = number / numOfNumbers;
            Console.WriteLine(result);
        }
    }
}
