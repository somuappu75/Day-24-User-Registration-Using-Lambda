using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Using_Lambda
{
    public class UserRegex
    {
        string pattern = "^[A-Za-z]{3,}$";

        public void ValidatingAllFields()
        {
            Console.WriteLine("-----------## Validating all Fielsds##---------------");
            Regex regex = new Regex(pattern);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The First Name");
            Console.WriteLine("Enter the first name : ");
            string Firststname1 = Console.ReadLine();
            ValidateFirstName(Firststname1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Last Name");
            Console.WriteLine("Enter the last name : ");
            string Lastname1 = Console.ReadLine();
            ValidateLastName(Lastname1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string Email1 = Console.ReadLine();
            ValidateEmail(Email1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Phone Number");
            Console.WriteLine("Enter the phone number");
            string number = Console.ReadLine();
            ValidatePhoneNum(number);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Password");
            Console.WriteLine("Enter the password");
            string Pass= Console.ReadLine();
            ValidatePassWord(Pass);

        }


        //uc-1 Validate First Name
        public static string ValidateFirstName(string firstName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            bool res = regex.IsMatch(firstName);
            if (res)
            {
                Console.WriteLine("First Name Valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("First Name Invalid");
            }
            return default;
        }
        //uc-2 Validate Last Name
        public static string ValidateLastName(string lastName)
        {
            string pattern = "^[A-Z][a-z]{2,}$";
            Regex regex = new Regex(pattern);
            bool res1 = regex.IsMatch(lastName);
            if (res1)
            {
                Console.WriteLine("Last Name Valid");
                return lastName;
            }
            else
            {
                Console.WriteLine(" alst Name Invalid");
            }
            return default;

        }
        //uc-3 Validate Email Address
        public static string ValidateEmail(string email)
        {

            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
           
            bool result = regex.IsMatch(email);
            if (result)
            {
                Console.WriteLine(email + " -----> Email Is Valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + " ----->Please Enter EMail Adderess Again!!!!");
            }

            return default;
        }

        //uc-4 Validate Phone Number
        public static string ValidatePhoneNum(string phoneNum)
        {
           
            string phoneNumEx = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumEx);

            bool result = regex.IsMatch(phoneNum);
            if (result)
            {
                Console.WriteLine("Phone Number VAlidated");
                return phoneNum;
            }
            else
            {
                Console.WriteLine(phoneNum + " -----> Please Enter with Country Code --InValid");
            }
            return default;
        }

        //Uc-5 validating password -Rule-1
        //uc-6 Rule-2 validated
        //uc-7 rule -3 one digit
        //uc-8 Rule -4 one special character 
        public static string ValidatePassWord(string password)
        {
            // string passwordEx = @"[a-z,A-Z,0-9]{8,}$";
            //string passwordEx = @"^(?=.*[A-Z]).{8,}$";
            // string passwordEx = @"^[0-9]+[\s]+[0-9]{10}$";
          
            string passwordPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";

            Regex regex = new Regex(passwordPattern);

            bool result = regex.IsMatch(password);
            if (result)
            {
                Console.WriteLine("Password IS VAlid ");
                return password;
            }
            else
            {
                Console.WriteLine("Password Is --InValid");
            }

            return default;
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

