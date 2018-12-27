using Interfaces;
using System;

namespace Classes
{
    public class Employee : Person, IEmployee,IPerson
    {
        public string Designation { get ; set; }

       
       
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Enter Designation of person: ");
            Designation = Console.ReadLine();
           
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Designation is"+"\n"+Designation);
        }

    }
}
