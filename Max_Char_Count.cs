using System;

namespace Max_Char_Count
{
    public class MaxChar
    {
        public static void Main()
        {
            String str;
            Console.WriteLine("Enter your name");
            str = (Console.ReadLine());
            int[] charCount = new int[256]; //shows all the characters in the ASCII table.
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                charCount[str[i]]++;
            }
            int maxCount = 0;
            char character = ' ';
            for (int i = 0; i < length-1; i++)
            {
                if (maxCount < charCount[str[i]])
                {
                    maxCount = charCount[str[i]];
                    character = str[i];
                }
            }
            Console.WriteLine("Max occurring character in"+" "+str +"is: " + character);
            Console.WriteLine("Number of times " +character+" occurs: " + maxCount);
        }
    }
}