using System;


class Assignment_08_05_2023
{
    public static void Main()
    {
        
        bool flag = true;
        while (flag)
        {
            int num;
            Console.WriteLine("Enter 1 for factorial.");
            Console.WriteLine("Enter 2 for fibonacci series.");
            Console.WriteLine("Enter 3 to check prime number.");
            Console.WriteLine("Enter the  number from above.");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    int fact;
                    int factriol;
                    factriol = 1;
                    Console.WriteLine("Enter number for factorial");
                    fact = Convert.ToInt32(Console.ReadLine());
                    for (int i = fact; i > 0; i--)
                    {
                        factriol *= i;
                        //Console.WriteLine(factriol);
                    }
                    Console.WriteLine("Factorial of " + fact + " is: " + factriol);
                    break;

                case 2:
                    int num1 = 0, num2 = 1, num3, number;
                    Console.WriteLine("Enter a number for fibonacci series");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("fibonacci series of " + number + " is: " + num1 + " " + num2 + " ");
                    
                    for (int i = 2; i < number; ++i)
                    {
                        num3 = num1 + num2;
                        Console.Write(num3 + " ");

                        num1 = num2;
                        num2 = num3;
                    }
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.WriteLine("Enter a number is to check it's prime or not.");
                    int pnum = Convert.ToInt32(Console.ReadLine());
                    bool Isprime = true;

                    for (int i = 2; i < pnum / 2; ++i)
                    {
                        if (pnum % i == 0)
                        {
                            Isprime = false;
                            break;
                        }

                    }
                    if (Isprime)
                    {
                        Console.WriteLine("{0} is a prime number.", pnum);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a prime number.", pnum);
                    }
                    break;

                default:

                    if (num > 3 || num <= 0)
                    {
                        Console.WriteLine("Please Enter valid case number");
                    }
                    else
                    {
                        Console.WriteLine("NOT FOUND !!");
                    }
                    break;



            }

            Console.WriteLine("do you want to continue.press Y for yes and N for no.");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch!='Y' && ch!='y')
            {
                flag= false;
            }
            

        }
    }
}