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
            Console.WriteLine("Enter the Phone Number(Start With Country Code)");
            ValidatePhoneNum();
            Console.WriteLine("Password Validation-Rule1=min 8 Chars");
            ValidatePassWord();
            Console.WriteLine("Password Validation-Rule2 at least one Upper casee");
            ValidatePassWord();

        }


        //uc-1 Validate First Name
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
        //uc-2 Validate Last Name
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
        //uc-3 Validate Email Address
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

        //uc-4 Validate Phone Number
        public void ValidatePhoneNum()
        {
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);
            Console.WriteLine("Enter valid Phone Number");
            string phoneNumber = Console.ReadLine();
            bool res = regex.IsMatch(phoneNumber);
            if (res)
            {
                Console.WriteLine("Phone Number Valid");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Phone Number!");
            }
        }

        //Uc-5 validating password -Rule-1
        //uc-6 Rule-2 validated
        //uc-7 rule -3 one digit
        //uc-8 Rule -4 one special character 
        public void ValidatePassWord()
        {
            // string passwordEx = @"[a-z,A-Z,0-9]{8,}$";
            //string passwordEx = @"^(?=.*[A-Z]).{8,}$";
            // string passwordEx = @"^[0-9]+[\s]+[0-9]{10}$";
            string passwordEx = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8}$";
            Regex regex = new Regex(passwordEx);
            Console.WriteLine("Enter password minimum 8 characters");
            string password = Console.ReadLine();
            bool res = regex.IsMatch(password);
            if (res)
            {
                Console.WriteLine("Password ruel-4 valid");
            }
            else
            {
                Console.WriteLine("invalid password!!");
            }
        }
        //uc-9 clear all email samples
        public void ClearEmailAllPass()
        {
            string EmailAllSample= "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex regex = new Regex(EmailAllSample);
            string EmailAll = Console.ReadLine();
            bool res = regex.IsMatch(EmailAllSample);
            if(res)
            {
                Console.WriteLine("Email All CElae Passes");
            }
            else
            {
                Console.WriteLine("Enter A Email Again");
            }
        }
    }
}

