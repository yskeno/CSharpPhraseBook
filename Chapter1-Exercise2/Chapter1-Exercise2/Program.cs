using System;

namespace Chapter1_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass { X = 1, Y = 2 };
            var myStruct = new MyStruct { X = 3, Y = 4 };

            PrintObjects(myClass, myStruct);
        }

        static void PrintObjects(MyClass myClass, MyStruct myStruct)
        {
            Console.WriteLine("MyClass X={0} Y={1}, MyStruct X={2} Y={3}", myClass.X, myClass.Y, myStruct.X, myStruct.Y);
        }
    }
}
