//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
using Standart;
using System;

namespace Solution
{
    internal class HM29
    {
        internal static void Start()
        {
            void PrintMass(string text, int[] mass)
            {
                Console.Write(text + " ");
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write($"{mass[i]} ");
                }
                Console.WriteLine();
            }
            Console.Clear();
            int[] mass = new int[8];
            for (int i = 0; i < 8; i++)
            {
                mass[i] = new Random().Next(-40, 41);
            }
            PrintMass("Введённый массив =", mass);
        }
    }
}