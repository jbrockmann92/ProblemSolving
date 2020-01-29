using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class ReciprocalReverse
    {
        //Member variables
        double reversed;
        double result;

        //Constructor

        //Methods
        public double Reverser()
        {
            //Will only work with ints. Do something with doubles, in which a decimal point is represented by a space on the char[]?
            int toReverse;
            Console.WriteLine("Please enter a number and I'll give you the reciprocal reverse of it");
            toReverse = int.Parse(Console.ReadLine());

            string toReverseString = toReverse.ToString();
            char[] toReverseArray = toReverseString.ToCharArray();
            char[] reversedArray = new char[toReverseArray.Length];
            for(int i = 0; i < toReverseArray.Length; i++)
            {
                reversedArray[i] = toReverseArray[toReverseArray.Length - (i + 1)];
            }

            string reversedString = new string(reversedArray);
            reversed = Double.Parse(reversedString);

            return reversed;
        }

        public double Reciprocal()
        {
            result = 1 / reversed;

            Console.WriteLine($" {result} is your reciprocal reverse!");
            return result;
        }
        
    }
}
