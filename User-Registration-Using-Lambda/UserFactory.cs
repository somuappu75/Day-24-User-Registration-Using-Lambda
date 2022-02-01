﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Using_Lambda
{
    public class UserFactory
    {

        public class UserRegistrationFactory
        {
            //Using Reflection to get method and constructor
            public object CreateObjectForRegexSample(string className, string constructor)
            {
                string p = @"." + constructor + "$";
                Match result = Regex.Match(className, p);
                if (result.Success)
                {
                    try
                    {
                        //assembly class object
                        Assembly assembly = Assembly.GetExecutingAssembly();
                        Type regexSampleType = assembly.GetType(className);
                        var res = Activator.CreateInstance(regexSampleType);
                        return res;
                    }
                    catch (Exception)
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No class found");
                    }
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
                }
            }
            public object CreateParameterizedConstructor(string classname, string constructorname, string message)
            {
                Type type = typeof(UserRegex);
                if (type.Name.Equals(classname) || type.FullName.Equals(classname))
                {
                    if (type.Name.Equals(constructorname))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        object objectConstructor = constructorInfo.Invoke(new object[] { message });
                        return objectConstructor;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No constructor found");
                    }
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No class found");
                }

            }
        }

        public object Test_Method_Parameteized_Constructor(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}