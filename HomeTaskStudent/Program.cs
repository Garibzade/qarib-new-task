using HomeTaskStudent.Models;

namespace HomeTaskStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("SalLA", "AZs");
            student.GetInfo();
        }
    }
}