using Classes;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Read();
            emp.Display();


           



            IDepartment dept = new Department();                //Idepartment interface variable nd department class constructor is callled
            Console.WriteLine(dept.DepartmentName = "IT");

            IEmployee emps = new Department();                //IEmployee interface variable nd Department class Constructor is called
            Console.WriteLine(emps.Designation ="Lead");

            IPerson person = new Department();           //IPerson interface variable nd Department class Constructor is called
            Console.WriteLine(person.Name = "PQR");
            Console.WriteLine(person.Age = 18);

            

            Console.ReadLine();
            Console.WriteLine(emp.Designation = "Tech Lead");
            Console.ReadLine();
        }
    }
}
