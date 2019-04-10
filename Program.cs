using System;

namespace NumberAtEndOfString
{
    public class Program
    {
        /// <summary>
        /// Move all digit to and of string
        /// </summary>
        /// <param name="str">Input string</param>
        public static void NumberAtEndString(string str)
        {
            ///check basic case (trivial)
            if ((str == null) || (str.Length <= 1))
            {
                Console.Write(str);
            }
            else
            { 
              ///if char is digit print use inverse recursion
              ///else print on direct recursion
              if (char.IsDigit(str[str.Length - 1]))
                {
                    NumberAtEndString(str.Substring(0, str.Length - 1));
                    Console.Write(str[str.Length - 1]);
                }
                else
                {
                    Console.Write(str[str.Length - 1]);
                    NumberAtEndString(str.Substring(0, str.Length - 1));
                }
            }
        }
        /**/

        private static void Main(string[] args)
        {
            string str = "12AbcdIf34Gh";

            Console.WriteLine($"Original string is : {str}");
            Console.Write("With number at end string: ");

            NumberAtEndString(str);

            Console.WriteLine("\n\nPress any key to continue..");
            Console.ReadLine();
        }
    }
}
