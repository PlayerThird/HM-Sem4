//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using System;

namespace Sem5
{
    internal class HM34
    {
        internal static void Start()
        {
            int[] newmass = Mass.CreateRandomArray(123, 100, 1000);
            Mass.ShowArray(newmass);
            int chet = 0;
            Console.WriteLine("------------------------------------------------------");
            foreach (int item in newmass)
            {
                if (item%2 == 0) chet++;
            }
            Console.WriteLine($"Чётных чисел = {chet}");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}