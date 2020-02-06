using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class Pyramid
    {
        //Member Variables (HAS A)
        string star = "* ";

        //Member Methods (CAN DO)
        public void CreatePyramid()
        {
            //Print a pyriamid of four levels of asterisks
            for (int i = 1; i < 5; i++)
            {
                for (int j = 5; j > 0; j--)
                {
                    Console.Write(string.Concat(Enumerable.Repeat(" ", i)));
                    Console.Write(string.Concat(Enumerable.Repeat("* ", j)));
                }
            }
            Console.ReadLine();
        }
    }
}
