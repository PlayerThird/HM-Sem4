//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
using System;

namespace Sem5
{
    internal class HM35
    {
        internal static void Start()
        {
            int[] newmass = Mass.CreateRandomArray(123, 0, 1000);
            Mass.ShowArray(newmass);
            Console.WriteLine("------------------------------------------------------");
            foreach (int item in newmass)
            {
                if (item > 10 && item < 99) Console.WriteLine($"Попадает в предел от 10 до 99 = {item} ");
            }
            Console.WriteLine("------------------------------------------------------");
        }
    }
}