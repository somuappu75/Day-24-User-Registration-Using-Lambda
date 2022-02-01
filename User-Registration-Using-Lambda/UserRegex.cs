using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Using_Lambda
{
    class UserRegex
    {
        string pattern = "^[A-Za-z]{3,}$";
      


        public void ValidatingFirstName()
        {
            Regex Regex = new Regex(pattern);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            bool res = Regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("FirstName Valid");
            }
            else
            {
                Console.WriteLine("FirstName Invalid");
            }
        }
    }
}
