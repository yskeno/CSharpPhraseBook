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

            // MyStruct is value type variable, so can't change member variable inside function.
            Console.WriteLine("from Main: MyClass X={0} Y={1}, MyStruct X={2} Y={3}", myClass.X, myClass.Y, myStruct.X, myStruct.Y);
            PrintObjects(myClass, myStruct);
        }

        static void PrintObjects(MyClass myClass, MyStruct myStruct)
        {
            Console.WriteLine("from Func: MyClass X={0} Y={1}, MyStruct X={2} Y={3}", myClass.X, myClass.Y, myStruct.X, myStruct.Y);

            myClass.X = myClass.X * 2;
            myClass.Y = myClass.Y * 2;
            myStruct.X = myStruct.X * 2;
            myStruct.Y = myStruct.Y * 2;

        }
    }
}