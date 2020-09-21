using System;

namespace Chapter1_Exercise3
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }
    }

    public class Employee : Person
    {
        public int Id { get; set; }
        public string DivisionName { get; set; }
    }

    public class Student : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }
    }
}