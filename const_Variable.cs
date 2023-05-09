
using System;

namespace const_Variable
{
    class constVar
    {
        const int Value1 = 1;
        const string Value2 = "Pankaj";
        public static void Main(string[] args)
        {
            constVar obj = new constVar();
            //obj.Value1 = 5; we can't change the value of constnt.
            Console.WriteLine(Value1 +"  "+Value2);
        }
    }
}