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
        public void ValidatingLastName()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the last name : ");
            string input1 = Console.ReadLine();
            bool res1 = regex.IsMatch(input1);
            if (res1)
            {
                Console.WriteLine("LastName Valid");
            }
            else
            {
                Console.WriteLine("LastName Invalid--");
            }
        }
    }
}
