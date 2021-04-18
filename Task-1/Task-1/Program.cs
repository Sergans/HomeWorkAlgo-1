using System;

namespace Task_1
{
    class Program
    {
      public static void PrimeNomber(int nomber)
        {
            if (nomber > 0)
            {
                int d = 0;
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
            
            



        }
        static void Main(string[] args)
        {
            
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
