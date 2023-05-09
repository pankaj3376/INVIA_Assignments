using System;

namespace Task_04_05_2023
{
    class palindrome
    {
        public static void Main()
        {
            string str, strrev = "";
            Console.WriteLine("Please enter a String to check palindrome Or not");
            str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strrev = strrev + str[i];
            }

            if (strrev == str)
            {
                Console.WriteLine(str + " is palindrome.");
            }
            else
            {
                Console.WriteLine(str + " is not palindrome.");
            }
            Console.ReadKey();


        }
    }

}