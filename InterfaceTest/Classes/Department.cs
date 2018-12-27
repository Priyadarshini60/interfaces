using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Department : Employee,IDepartment,IEmployee,IPerson
    {
        public string DepartmentName { get; set; }



        public override void Read()
        {
            base.Read();
            Console.WriteLine("Enter Department");
            DepartmentName = Console.ReadLine();

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Department is"+"\n" + DepartmentName);
        }

    }
}
