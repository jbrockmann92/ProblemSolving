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
        char star = '*';

        //Member Methods (CAN DO)
        public void CreatePyramid()
        {
            //Print a pyriamid of four levels of asterisks
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine('*');
                Console.WriteLine(' ');
            }
            Console.ReadLine();
        }
    }
}
