using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Using_Lambda
{
    class UserRegex
    {
        string pattern = "^[A-Za-z]{3,}$";

        public void ValidatingAllFields()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("First Name Validating");
            ValidatingFirstName();
            Console.WriteLine("Last Name Validating");
            ValidatingLastName();
            Console.WriteLine("The Email Address Validating");
            ValidateEmail();

        }



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

        public void ValidateEmail()
        {
            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
            Console.WriteLine("Enter email Id");
            string emails = Console.ReadLine();
            bool res = regex.IsMatch(emails);
            if (res)
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }
        }
    }
    }

