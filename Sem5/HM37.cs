//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6]-> 36 21
using System;

namespace Sem5
{
    internal class HM37
    {
        internal static void Start()
        {
            int[] GetDivineArray(int[] array)
            {
                int size = (array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1);
                int[] newArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    if (i != array.Length - i - 1)
                        newArray[i] = array[i] * array[array.Length - i - 1];
                    else newArray[i] = array[i];
                }
                return newArray;
            }

        }
    }
}