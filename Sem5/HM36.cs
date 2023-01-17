//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;

namespace Sem5
{
    internal class HM36
    {
        internal static void Start()
        {
            int[] mass = Mass.CreateRandomArray(10,0,11);
            Mass.ShowArray(mass);
            Console.WriteLine("------------------------------------------------------");
            int summ = 0;
            for (int i = 1; i < mass.Length; i+=2)
            {
                summ+= mass[i];
            }
            Console.WriteLine(summ);
        }
    }
}