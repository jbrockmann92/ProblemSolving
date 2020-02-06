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
        }

        //Member Methods (CAN DO)
        public void OrderAscending()
        {
            //Should be able to keep O(n) lower by copying the array instead of iterating over it twice. Want to avoid a nested for loop if possible
            int[] arrayCopy = array;
            int[] arrayResult = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < arrayCopy[i])
                {

                }
                    //Need to set so that it only takes the lowest item first, then the second, etc.
            }
        }

    }
}
