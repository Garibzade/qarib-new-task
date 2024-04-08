using HomeTaskStudent.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent.Models
{
    internal class Student
    {
        public static int Count=0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name,string surname) 
        {
            Name = name.Capitalize();
          Surname = surname.Capitalize();
            Id = ++Count;
        } 
        public void GetInfo()
        {
            Console.WriteLine($"Id:{Id}\nName:{Name}\nSurname:{Surname}");
        }
    }
}
