using System;

namespace staticReadonly
{
    class readonlyVar
    {
        readonly static int pid;
        readonly static string name;
        static readonlyVar()
        {
            pid = 1;
            name = "Pankaj";
            Console.WriteLine(pid+" "+name);
        }

        public static void Main(string[] args)
        {
          readonlyVar obj= new readonlyVar();
          Console.ReadKey();
        }

    }
}