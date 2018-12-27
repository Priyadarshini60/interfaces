using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public virtual void Read()
        {
            Console.WriteLine("Enter name of person: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age of person: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Person"+"\n"+Name+"\n"+"Age is"+"\n"+Age);
        }
    }
}
