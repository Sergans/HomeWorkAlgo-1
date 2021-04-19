using System;

namespace Task_1
{
    class Program
    {
        public class TestCase
        {
            public int nomberd { get; set; }
            public int testnomber { get; set; }
        }

       static void TestReturn(TestCase testCase)
        {
            if (testCase.nomberd == PrimeNomber(testCase.testnomber))
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");

            }

        }

      public static int PrimeNomber(int nomber)
        {
            int d = 0;
            if (nomber > 0)
            {

                for (int i = 2; i < nomber; i++)
                {
                    for (; nomber % i == 0; i++)
                    {
                        d++;
                    }

                }
                if (d == 0)
                {
                    Console.WriteLine($"{nomber} - Простое число");
                }
                else
                {
                    Console.WriteLine($"{nomber} - Не проcтое число");
                }

            }
            else
            {
                Console.WriteLine("Введенное число меньше или равно 0");
            }

            return d; 



        }
        static void Main(string[] args)
        {
            var testCase1 = new TestCase() { nomberd = 0, testnomber = 3 };
            var testCase2 = new TestCase() { nomberd = 1, testnomber = 4 };
            TestReturn(testCase1);
            TestReturn(testCase2);



            Console.WriteLine("Введите целое положительное число");
            try
            {
                PrimeNomber(Convert.ToInt32(Console.ReadLine()));

            }
            catch
            {
                Console.WriteLine("Ошибка: Введеное значение не является целым или не являтся числом");
            }


            

            
        }
    }
}
