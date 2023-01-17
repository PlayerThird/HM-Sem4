//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using System;

namespace Sem5
{
    internal class HM38
    {
        internal static void Start()
        {
            int [] mass = Mass.CreateArray();
            Mass.ShowArray(mass);
            MinMas(mass);
            void MinMas(int[] massfunc)
            {
                int min = massfunc[0];
                int max = massfunc[0];
                for (int i = 0; i < massfunc.Length; i++)
                {
                    if (massfunc[i] < min)
                    {
                        min = massfunc[i];
                    }
                    if (massfunc[i] > max)
                    {
                        max = massfunc[i];
                    }
                }
                Console.WriteLine($"Min = {min}, max = {max}, Разница = {max - min}");
            }
        }
    }
}