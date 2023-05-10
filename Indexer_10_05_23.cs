using System;

class Employee
{
    object[] Emp = new object[4];

    public object this[int i]
    {
        get
        {
            return Emp[i];
        }
        set
        {
            Emp[i] = value;
        }
    }
}

class empDetails
{
    public static void Main(string[] args)
    {
        Employee obj = new Employee();
        obj[0] = 101;
        obj[1] = "Pankaj";
        obj[2] = 27;
        obj[3] = 50000;
        Console.WriteLine(" ID: " + obj[0] + "\n Name: " + obj[1] + "\n Age: " + obj[2] + "\n Salary: " + obj[3]);
    }
}