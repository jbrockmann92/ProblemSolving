using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class StringAndNumbers
    {
        //Member Variables (HAS A)
        Dictionary<int, char> letterValueDictionary;

        //Constructor
        public StringAndNumbers()
        {
            letterValueDictionary = new Dictionary<int, char>();
            letterValueDictionary.Add(1, 'a');
            letterValueDictionary.Add(2, 'b');
            letterValueDictionary.Add(3, 'c');
            letterValueDictionary.Add(4, 'd');
            letterValueDictionary.Add(5, 'e');
            letterValueDictionary.Add(6, 'f');
            letterValueDictionary.Add(7, 'g');
            letterValueDictionary.Add(8, 'h');
            letterValueDictionary.Add(9, 'i');
            letterValueDictionary.Add(10, 'j');
            letterValueDictionary.Add(11, 'k');
            letterValueDictionary.Add(12, 'l');
            letterValueDictionary.Add(13, 'm');
            letterValueDictionary.Add(14, 'n');
            letterValueDictionary.Add(15, 'o');
            letterValueDictionary.Add(16, 'p');
            letterValueDictionary.Add(17, 'q');
            letterValueDictionary.Add(18, 'r');
            letterValueDictionary.Add(19, 's');
            letterValueDictionary.Add(20, 't');
            letterValueDictionary.Add(21, 'u');
            letterValueDictionary.Add(22, 'v');
            letterValueDictionary.Add(23, 'w');
            letterValueDictionary.Add(24, 'x');
            letterValueDictionary.Add(25, 'y');
            letterValueDictionary.Add(26, 'z');
        }
        //Should be able to add use built-in values, but this should work as well

        //Member Methods (CAN DO)
        public char[] ConvertToCharArray(string input)
        {
            char[] result;
            Console.WriteLine("What would you like converted?");
            string toConvert = Console.ReadLine();
            result = toConvert.ToCharArray();
            //Convert to char array
            return result;
        }
        //Need to make sure I don't convert spaces to anything?
        //Convert the whole thing to a string. Assign to 'result'

        public string ConvertToIntString(char[] input)
        {
            string result;
            int charValue;

            //Convert spaces to 0 with spaces around? Or leave spaces?
            for (int i = 0; i < input.Length; i++)
            {
                if (letterValueDictionary.ContainsValue(input[i]))
                {
                    //Want to charValue to be assigned the key that corresponds to the value at input[i]
                    charValue = letterValueDictionary.
                    result += 
                }
            }


            return result;
        }

    }
}
