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
            //Should be able to keep O(n) lower by copying the array instead of iterating over it twice. Want to avoid a nested for loop if possible
            //Could do it with a double nested loop, by saying that it has to run until a variable reaches 10, and that variable only increments when it adds an item to the resulting array
            List<int> resultList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (j < k)
                        {
                            resultList.Add(array[j]);
                        }
                    }
                }
            }
            Console.WriteLine(resultList.Count);
        }

    }
}
