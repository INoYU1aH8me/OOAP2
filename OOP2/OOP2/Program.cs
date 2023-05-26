using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student badStudent = new BadStudent() { name = "Двоечник" };
            Student goodStudent = new GoodStudent() { name= "Отличник" };

            ShowDay(badStudent);
            ShowDay(goodStudent);

        }
        public static void ShowDay(Student student)
        {
            Console.WriteLine(student.name +":");
            student.SpendDay();
            Console.WriteLine();
        }
    }
    
}
