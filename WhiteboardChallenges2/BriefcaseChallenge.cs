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
            combination = new int[4] { 1, 2, 3, 4};
            currentCombination = new int[4] { 2, 7, 4, 5 };
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
                if (currentCombination[i] - combination[i] <= 5)
                {
                    totalMoves += (currentCombination[i] - combination[i]);
                }
                else
                {
                    totalMoves += ((9 - currentCombination[i]) + combination[i] + 1);
                }
            }

            Console.WriteLine($"It would take {totalMoves} total turns to move where the combination is to where it needs to be");
            return totalMoves;
        }
    }
}
