using System;
using System.Threading;

namespace Chapter3_Section1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // 3.1 汎用性のないCountメソッド
        public int Count(int num)
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            int count = 0;
            foreach (var n in numbers)
            {
                if (n == num)
                    count++;
            }
            return count;
        }

        // 3.2 配列を引数に受け取るCountメソッド
        public int Count(int[] numbers, int num)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (n == num)
                    count++;
            }
            return count;
        }

        // 3.3 デリゲートを受け取るCountメソッド
        public delegate bool Judgement(int value);
        public int Count(int[] numbers, Judgement judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                    count++;
            }
            return count;
        }

        // 3.4 デリゲートを受け取るCountメソッドの利用例(1)
        public void Do1()
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            Judgement judge = IsEven;   // set IsEven() as argument for Count()
            var count = Count(numbers, judge);  // IsEven() is called in Count()
            Console.WriteLine(count);
        }

        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        // 3.5 デリゲートを受け取るCountメソッドの利用例(2)
        public void Do2()
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var count = Count(numbers, IsEven);
            Console.WriteLine(count);
        }

        // 3.6 匿名メソッドを利用した例
        public int Count3(int[] numbers, Predicate<int> judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                    count++;
            }
            return count;
        }

        public void Do3()
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var count = Count3(numbers, delegate (int n) { return n % 2 == 0; });
            Console.WriteLine(count);
        }

        // Chapter 3.2 Lambda
        // Step 0 (最も冗長なコード)
        public void Lambda0()
        {
            Predicate<int> judge =
                (int n) =>
                {
                    if (n % 2 == 0)
                        return true;
                    else
                        return false;
                };
        }

        // Step 1
        public void Lambda1(int[] numbers)
        {
            var count = Count(numbers,
                (int n) =>
                {
                    if (n % 2 == 0)
                        return true;
                    else
                        return false;
                });
        }

        // Step 2 if文をなくす
        // ・returnの右側には式を書くことが出来る
        // ・"n%2==0"は式でありbool型の値(式が成り立てばtrue/そうでなければfalse)を持つ
        public void Lambda2(int[] numbers)
        {
            var count = Count(numbers, (int n) => { return n % 2 == 0; });
        }

        // Step 3 Lambda式の中が1つの文の場合は{}とreturnを省略できる
        public void Lambda3(int[] numbers)
        {
            var count = Count(numbers, (int n) => n % 2 == 0);
        }

        // Step 4 Lambda式では引数の型を省略できる
        public void Lambda4(int[] numbers)
        {
            var count = Count(numbers, (n) => n % 2 == 0);
        }

        // Step 5 引数が1つの場合は()を省略できる
        public void Lambda5(int[] numbers)
        {
            var count = Count(numbers, n => n % 2 == 0);
        }
    }
}