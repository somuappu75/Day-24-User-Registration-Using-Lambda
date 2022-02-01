using System;

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
            UserRegex user = new UserRegex();
            user.ValidatingAllFields();
            
        }
    }
}
