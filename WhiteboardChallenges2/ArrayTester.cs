using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class ArrayTester
    {
        public bool greatSuccess;
        public int[] array1;
        public int[] array2 = { 3, 90, 16, 14, 9, 55, 20, 8 };
        int j;

        public ArrayTester()
        {
            greatSuccess = false;
            j = 0;
        }

        public bool ArrayComparer(int[] toBeTested, int testAgainst)
        {
            Console.WriteLine("This is an array tester. I'll test the arrays to see if they have two numbers that can add up to a given total");

            for (int i = 0; i < toBeTested.Length; i++)
            {
                for (int j = 0; j < toBeTested.Length; j++)
                {
                    if (toBeTested[i] + toBeTested[j] == testAgainst)
                    {
                        if (i == j)
                        {
                            j++;
                        }
                        else
                        {
                            Console.WriteLine("Success!");
                            return true;
                        }
                    }
                }
            }
            Console.WriteLine("The test fails!");
            return false;
        }
    }
}
