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
            StringAndNumbers stringAndNumbers = new StringAndNumbers();
            Console.WriteLine(stringAndNumbers.ConvertToIntString(stringAndNumbers.ConvertToCharArray()));
            Console.ReadLine();
        }
    }
}
