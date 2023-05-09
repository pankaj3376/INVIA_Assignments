using System;

namespace staticvariable
{
    class staticVar
    {
        public static int a;
        public static int b;
        public static void Main(string[] args)
        {
            staticVar.a = 20;
            staticVar.b = 12;
            Console.WriteLine("Addition of var a & b is: " + (a+b));
        }
    }
}