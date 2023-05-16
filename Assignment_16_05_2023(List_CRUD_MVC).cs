

 //=================================== Model =====================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Genric2_16_05_2023.Model
{
    internal class Employee
    {
        public int EID { get; set; }
        public string Ename { get; set; }
        public int Age { get; set; } = 0;
    }
}



//====================================== Services =======================================

//using System;

using Day8_Genric2_16_05_2023.Model;

namespace Day8_Genric2_16_05_2023.Services
{
    internal class EmpServices
    {
        List<Employee> empList = new List<Employee>();
        public int addEmployee(Employee _emp)
        {
            empList.Add(_emp);
            return empList.Count;
        }
        public List<Employee> listOfEmployee()
        {
            foreach (var _emp in empList)
            {
                Console.WriteLine(_emp.EID + " " + _emp.Ename + " " + _emp.Age);
            }
            return empList;
        }

        /*public Employee getEmployee(int id)
        {
            Employee emp = empList[id];
            return emp;
        }*/
        public Employee getEmployeeById(int id)
        {
            foreach (var _emp in empList)
            {
                if(_emp.EID == id)
                {
                    return empList[id];
                }
            }
            return empList[id];
        }
        /*public Employee getEmployeeByName(string name)
        {
            Employee emp = empList[name];
            return emp;
        }*/
        public int removeEmployee(int id)
        {
            foreach (Employee emp in empList)
            {
               if(emp.EID == id)
               {
                    empList.Remove(emp);
               }
            }
            return empList.Count;
        }
        /*public Employee updateEmpById(int id,string name)
        {
            foreach(Employee emp in empList)
            {
                if (emp.EID == id)
                {
                    empList.i
                    //emp.Ename = name;
                }
            }
        }*/
        
    }
}

//========================================= UI ===================================================

using System;
using System.Collections.Generic;

using Day8_Genric2_16_05_2023.Model;
using Day8_Genric2_16_05_2023.Services;

namespace Day8_Genric2_16_05_2023.UI
{
    internal class MainApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("press 1 for insert\n2 for list\n3 for search\n4 for remove employee.\n");
            int caseNum =Convert.ToInt32(Console.ReadLine());
            Employee obj = new Employee();
            EmpServices obj1 = new EmpServices();
            switch (caseNum)
            {
                case 1:
                    Console.WriteLine("Enter your id");
                    int eid =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your name..");
                    string ename = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter your Age..");
                    int eage = Convert.ToInt32(Console.ReadLine());
                    obj.EID = eid;
                    obj.Ename = ename;
                    obj.Age = eage;
                    obj1.addEmployee(obj);
                    break;
                case 2:
                    Console.WriteLine("The List of Employee Is: \n");
                    //List<Employee> objList =
                        obj1.listOfEmployee();
                    /*foreach (var _emp in objList)
                    {
                        Console.WriteLine(_emp.EID + " " + _emp.Ename + " " + _emp.Age);
                    }*/
                    break;
                case 3:
                    Console.WriteLine("Enter The Employee Id for search");
                    int sid = Convert.ToInt32(Console.ReadLine());
                    obj1.getEmployeeById(sid);
                    break;


                default: Console.WriteLine("Something went wrong");
                    return;

            }
        }
    }
}



