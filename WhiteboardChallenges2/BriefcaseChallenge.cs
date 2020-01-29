using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class BriefcaseChallenge
    {
        //Member Variables
        int totalMoves;
        int[] combination;
        int[] currentCombination;

        //Constructor
        public BriefcaseChallenge()
        {
            combination = new int[4] { 3, 8, 9, 3};
            currentCombination = new int[4] { 5, 2, 9, 6 };
        }

        //Member Methods
        //public int[] ConvertToArray() //Converts int into array of ints
        //{
        //    char[] comboArray = combination.ToString().ToCharArray();
        //    int[] intArray = new int[comboArray.Length];

        //    for (int i = 0; i < comboArray.Length; i++)
        //    {
        //        intArray[i] = Convert.ToInt32(comboArray[i]);
        //    }

        //    return intArray;
        //}

        public int CombinationTest()
        {
            for (int i = 0; i < combination.Length; i++)
            {
                if (currentCombination[i] - combination[i] <= 5 && currentCombination[i] - combination[i] > 0)
                {
                    totalMoves += (currentCombination[i] - combination[i]);
                }
                else if (currentCombination[i] - combination[i] > 5)
                {
                    totalMoves += ((9 - currentCombination[i]) + combination[i] + 1);
                }
                else if (currentCombination[i] - combination[i] < 0)
                {
                    totalMoves += (combination[i] - currentCombination[i]);
                }
            }

            Console.WriteLine($"It would take {totalMoves} total turns to move where the combination is to where it needs to be");
            return totalMoves;
        }
    }
}
