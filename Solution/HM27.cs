//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
using System;

namespace Solution
{
    internal class HM27
    {
        internal static void Start()
        {
            Console.WriteLine("Введте число");
            string chis = Console.ReadLine();

            int sum = 0;
            foreach (var item in chis)
            {
                if (char.IsDigit(item))
                {
                    int per = item - '0';
                    sum = sum + per;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
//int -124
//per = ?