using System;

namespace Chapter1_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Id = 100,
                Name = "Taro Yamada",
                Birthday = new DateTime(1992, 4, 5),
                DivisionName = "Sales Division 1",
            };

            var student = new Student
            {
                Name = "John Yamada",
                Birthday = new DateTime(1985, 6, 4),
                Grade = 5,
                ClassNumber = 2,
            };
            Console.WriteLine(student.ToString());

            Person personFromStudent = student;

            Object objFromStudent = student;
        }
    }
}