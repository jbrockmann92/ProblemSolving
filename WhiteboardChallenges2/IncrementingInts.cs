using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class IncrementingInts
    {
        //Member Variables (HAS A)
        public List<int> testList1;
        public List<int> testList2;
        public bool canIncrement;

        //Constructor
        public IncrementingInts()
        {
            testList1 = new List<int>() { 5, 7, 3, 8, 6 };
            testList2 = new List<int>() { 17, 15, 20, 19, 21, 16, 18 };
            canIncrement = false;
        }

        //Member Methods (CAN DO)
        public bool CanListIncrement(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    int tempListLocation = list[i];
                    if (list[j] == tempListLocation++)
                    {
                        canIncrement = true;
                    }
                    else
                    {
                        canIncrement = false;
                        return canIncrement;
                    }
                }
            }
            return canIncrement;
        }

    }
}
