using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class AscendingOrder
    {
        //Member Variables (HAS A)
        int[] array;

        //Constructor
        public AscendingOrder()
        {
            array = new int[10];
            array[0] = 33;
            array[1] = 55;
            array[2] = 2;
            array[3] = 43;
            array[4] = 6;
            array[5] = 80;
            array[6] = 81;
            array[7] = 1;
            array[8] = 20;
            array[9] = 71;
        }

        //Member Methods (CAN DO)
        public void OrderAscending()
        {
            for (int j = 1; j < array.Length; j++)
            {
                for (int k = 0; k < array.Length; k++)
                {
                    if (array[j] < array[k])
                    {
                        int temp = array[j];
                        array[j] = array[k];
                        array[k] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
