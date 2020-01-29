using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class HighAndLow
    {
        //Member Variables (HAS A)
        string intsString;

        //Constructor
        public HighAndLow()
        {
            intsString = "3 9 0 1 4 8 10 2";
        }

        //Member Methods (CAN DO)
        public List<int> ConvertToInt()
        {
            bool test = false;
            bool test2 = true;
            intsString += " ";
            int[] digits = new int[intsString.Length + 1]; 
            digits = intsString.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            List<int> converted = new List<int>();
            for (int i = 1; i < digits.Length - 1; i++)
            {
                if (digits[i] != -1)
                {
                    if (digits[i + 1] == -1)
                    {
                        test = true;
                    }

                    if (digits[i + 1] == -1 && digits[i - 1] == -1 && test == true)
                    {
                        converted.Add(digits[i]);
                    }
                    else if (test2 == true)
                    {
                        string temp = Convert.ToString(digits[i]);
                        string temp2 = Convert.ToString(digits[i + 1]);
                        string combo = temp + temp2;
                        converted.Add(int.Parse(combo));
                        test2 = false;
                    }
                    //Might end up out of bounds at the end
                }
            }
            return converted;
        }

        public string HighLow(List<int> list)
        {
            string highLow = "";
            int high = 0;
            int low = 99;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    //Need to assign only when it's higher than all others
                    if (list[i] > high)
                    {
                        high = list[i];
                    }
                    if (list[i] < low)
                    {
                        low = list[i];
                    }
                }
            }
            highLow += Convert.ToString(low);
            highLow += " ";
            highLow += Convert.ToString(high);
            return highLow;
        }
    }
}
