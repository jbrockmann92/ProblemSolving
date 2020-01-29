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
            IncrementingInts incrementing = new IncrementingInts();

            incrementing.CanListIncrement(incrementing.testList1);
            Console.WriteLine($"{incrementing.canIncrement}");
            Console.ReadLine();
        }
    }
}
