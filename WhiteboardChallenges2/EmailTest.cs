using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges2
{
    class EmailTest
    {
        //Member Variables (HAS A)
        bool body;
        bool symbol;
        bool domain;
        bool dot;
        bool qualifier;
        bool isEmail;
        string email = "";
        public char[] charEmail;

        //Constructor
        public EmailTest()
        {
            body = false;
            symbol = false;
            domain = false;
            dot = false;
            qualifier = false;
            isEmail = false;
        }

        //Member Methods (CAN DO)
        public void GetEmail()
        {
            Console.WriteLine("Please enter your email address: ");
            email = Console.ReadLine();

            charEmail = email.ToCharArray();
        }
        public void TestEmail(char[] charEmail)
        {
            for (int i = 0; i < charEmail.Length; i++)
            {
                if (Char.IsLetter(charEmail[i]) == true)
                {
                    body = true;
                }
                if (charEmail[i] == '@' && body == true)
                {
                    symbol = true;
                }
                if (Char.IsLetter(charEmail[i]) && body == true && symbol == true)
                {
                    domain = true;
                }
                if (charEmail[i] == '.' && Char.IsLetter(charEmail[i + 1]) && body == true && symbol == true && domain == true)
                {
                    isEmail = true;
                }
            }
            if (isEmail == true)
            {
                Console.WriteLine("That is a valid email address");
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }

    }
}
