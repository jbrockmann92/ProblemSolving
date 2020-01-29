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
            HighAndLow high = new HighAndLow();
            List<int> list = new List<int>();
            list = high.ConvertToInt();
            string complete = high.HighLow(list);

            Console.WriteLine($"{complete}");
            Console.ReadLine();
        }
    }
}
