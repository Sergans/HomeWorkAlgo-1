using System;

namespace Task_3
{
    class Program
    {
       public class TestCase
        {
            public int nomberposition { get; set; }
            public int sum { get; set; }
        }
        static void Test(TestCase testCase)
        {
            if (testCase.sum == Fibbo(testCase.nomberposition) && testCase.sum == FiboArray(testCase.nomberposition))
            {
                Console.WriteLine("VALID TEST");

            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }


        static int FiboArray(int n)
        {
            int f1 =0;
            int f2 =1;
            int f3 = 0;
            if (n ==0)
            {
                n = 0;
                return n;
            }
            else if (n == 1)
            {
                n = 1;
                return n;
            }

            for (int i = 1; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;

        }
        static int Fibbo(int n)
        {
            if (n == 0)
            {
                n = 0;
                return n;
            }
            else if (n == 1)
            {
                n = 1;
                return n;
            }
            return n = Fibbo(n - 1) + Fibbo(n - 2);
        }
        static void Main(string[] args)
        {
            var testcase1 = new TestCase() { nomberposition = 1, sum = 1 };
            var testcase2 = new TestCase() { nomberposition = 10, sum = 55 };
            var testcase3 = new TestCase() { nomberposition = 22, sum = 17711 };
            Test(testcase1);
            Test(testcase2);
            Test(testcase3);
            Console.WriteLine("Введите значение последовательности Фибонначи,чтобы получить число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число из последовательности:{Fibbo(n)}");
            Console.WriteLine($"Число из последовательности:{FiboArray(n)}");
        }
    }
}
