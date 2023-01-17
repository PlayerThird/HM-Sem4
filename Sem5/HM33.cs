//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданние число в массиве
using System;

namespace Sem5
{
    internal class HM33
    {
        internal static void Start()
        {
            int[] mass = Mass.CreateRandomArray(10, -100, 101);
            Mass.ShowArray(mass);
            Console.WriteLine("Введите искаемое число");
            int x = Convert.ToInt32(Console.ReadLine());
            bool est = false;
            foreach (var item in mass)
            {
                if (x == item)
                {
                    est = true;
                }
            }
            if (est == true)
            {
                Console.WriteLine("Есть!");
            }
            else
            {
                Console.WriteLine("Ну, видимо такого числа нет :/");
            }
        }
    }
}