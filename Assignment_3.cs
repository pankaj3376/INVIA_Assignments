using System;

class studet
{
    int ID;
    string Name;
    int Amount;

    studentDetails obj = new studentDetails();

    public int SID { get; set; }
    public string SNAME { get; set; }
    //public int SAMOUNT { get; set; }
    public int SAMOUNT
    {
        get
        {
            return (int)this.Amount;
        }
        set
        {
            this.Amount = value;
            if (value < 10000)
            {
                obj.notGoForShopping();
            }
            else
            {
                obj.goForShopping();
            }
        }
    }
}

class studentDetails
{
    public void goForShopping()
    {
        Console.WriteLine("You can go for shopping");
    }
    public void notGoForShopping()
    {
        Console.WriteLine("You can't go for shopping");
    }

    public void stdDetaild()
    {
        studet std = new studet();
        std.SID = 101;
        std.SNAME = "Pankaj Priyadarshi";
        std.SAMOUNT = 20000;
        Console.WriteLine(std.SID+" "+ std.SNAME+" "+ std.SAMOUNT);
    }
}

class result
{
    public static void Main(string[] args)
    {
        studentDetails std = new studentDetails();
        std.stdDetaild();
    }
}