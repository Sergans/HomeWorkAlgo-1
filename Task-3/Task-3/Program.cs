using System;

namespace Task_3
{
    class Program
    {
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
            Console.WriteLine("Введите значение последовательности Фибонначи,чтобы получить число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число из последовательности:{Fibbo(n)}");

        }
    }
}
