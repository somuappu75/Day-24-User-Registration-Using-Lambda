﻿using System;

namespace User_Registration_Using_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------User Registration Problem Using Regular Expression-----------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            //uc-4 phone number validated
            //Uc-5 validating password -Rule-1 added
            //Uc-6 validating password -Rule-2 added
            //uc-7 validating password rule -3 atlest one digit added
            //uc-8 rule 4 added-one speacial character
            //uc-9 all clear Email Samples Are added
            UserRegex user = new UserRegex();
            user.ValidatingAllFields();
            
        }
    }
}
