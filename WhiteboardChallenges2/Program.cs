using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class Program
    {
        static void Main(string[] args)
        {
            NegativeAndPositive neg = new NegativeAndPositive();

            neg.CountPositive();
            neg.AddNegative();

            Console.WriteLine($"{neg.negPos[0]}, {neg.negPos[1]}");
            Console.ReadLine();
        }
    }
}
