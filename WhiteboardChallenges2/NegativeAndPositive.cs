using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class NegativeAndPositive
    {
        //Member Variables (HAS A)
        int[] list1;
        public int[] negPos;

        //Constructor
        public NegativeAndPositive()
        {
            list1 = new int[11] { 7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21 };
            negPos = new int[2];
        }

        //Member Methods (CAN DO)
        public void CountPositive() //Counts up the positive numbers
        {
            for (int i = 0; i < list1.Length; i++)
            {
                if (list1[i] > 0)
                {
                    negPos[0]++;
                }
            }
        }

        public void AddNegative() //Adds all the negative numbers
        {
            for (int i = 0; i < list1.Length; i++)
            {
                if (list1[i] < 0)
                {
                    negPos[1] += list1[i];
                }
            }
        }

    }
}
