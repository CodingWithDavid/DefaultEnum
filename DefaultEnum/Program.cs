/*########################################################
 *#  DefaultEnum.dll                                     #
 *#  Copyright 2018 by WesTex Enterprises                #
 *########################################################*/

using System;
using System.ComponentModel;
using System.Drawing;

namespace DefaultEnum
{
    internal static class Program
    {
        /// <summary>
        /// This is the main program we have built to demonstrant using the 
        /// "default" keyword with primitive types, object types and enums
        /// </summary>
        private static void Main()
        {
            WriteResults("Default string is", default(string));
            WriteResults("Default int is", default(int).ToString());
            WriteResults("Default sbyte is", default(sbyte).ToString());
            WriteResults("Default byte is", default(byte).ToString());
            WriteResults("Default uint is", default(uint).ToString());
            WriteResults("Default char is", default(char).ToString());
            WriteResults("Default bool is", default(bool).ToString());
            WriteResults("Default long is", default(long).ToString());
            WriteResults("Default double is", default(double).ToString());
            WriteResults("Default float is", default(float).ToString());
            WriteResults("Default decimal is", default(decimal).ToString());
            WriteResults("Default point is", default(Point).ToString());
            WritePersonResults("Default Person is");
            WriteEnumResults("Default Enum is");

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            WriteResults("Default Enum set by zero value is", default(DaysOfTheWeekSetByZeroValue).ToString());
            WriteResults("Default Enum set by zero value even with attribute set is", default(DOWSetByZeroValueWithDefaultValueAttribute).ToString());
            WriteResults("Default Enum set by default value attribute is", default(DefinedDOWSSetByDefaultValueAttribute).ToString());

            DefinedDOWSSetByDefaultValueAttribute o = GetDefaultValue<DefinedDOWSSetByDefaultValueAttribute>();
            WriteResults("Use attribute for value is", o.ToString());

            WriteResults("Default Enum set by zero value with a negitve value is", default(NextDOWSetByZeroValueWithANegitive).ToString());
            WriteResults("Default Enum set by order of items in enum is", default(ByOrderDOWS).ToString());
            WriteResults("Default Enum set by zero value with multiple zero values is", default(MultipleZeroDOW).ToString());

            Console.ReadLine();
        }

        /// <summary>
        /// Private method used to write out the message when using the 
        /// default keyword with the Enum object
        /// </summary>
        /// <param name="message">What is the message to log out</param>
        private static void WriteEnumResults(string message)
        {
            string result = "null";
            Console.Write($"{message} ");
            Console.BackgroundColor = ConsoleColor.Red;
            Enum p = default(Enum);
            if (p != null)
            {
                result = p.ToString();
            }
            Console.WriteLine(result);
            Console.ResetColor();
        }

        /// <summary>
        /// Private method used to write out the message when using the 
        /// default keyword with the Person object
        /// </summary>
        /// <param name="message">What is the message to log out</param>
        private static void WritePersonResults(string message)
        {
            string result = "null";
            Console.Write($"{message} ");
            Console.BackgroundColor = ConsoleColor.Red;
            Person p = default(Person);
            if (p != null)
            {
                result = p.ToString();
            }
            Console.WriteLine(result);
            Console.ResetColor();
        }

        /// <summary>
        /// Private method used to add some color to the output of the default 
        /// call
        /// </summary>
        /// <param name="message">What is the message to be log to the console</param>
        private static void WriteResults(string message, string result)
        {
            Console.Write($"{message} ");
            Console.BackgroundColor = ConsoleColor.Red;
            if(result == null)
            {
                result = "null";
            }
            Console.WriteLine(result);
            Console.ResetColor();
        }

        /// <summary>
        /// Private method to used to show how to use the default attriubute 
        /// with in enum
        /// </summary>
        /// <typeparam name="TEnum">Enum to lookup and get the "default" value </typeparam>
        /// <returns>Enum type</returns>
        private static TEnum GetDefaultValue<TEnum>() where TEnum : struct
        {
            Type t = typeof(TEnum);
            DefaultValueAttribute[] attributes = (DefaultValueAttribute[])t.GetCustomAttributes(typeof(DefaultValueAttribute), false);
            if (attributes?.Length > 0)
            {
                return (TEnum)attributes[0].Value;
            }
            else
            {
                return default(TEnum);
            }
        }
    }
}
