using System;

namespace Sem5
{
    internal class HM31
    {
        internal static void Start()
        {
            int[] mass = Mass.CreateRandomArray(10, -100, 101);
            Mass.ShowArray(mass);
            int positive = 0;
            int negative = 0;
            foreach (var item in mass)
            {
                if (item < 0)
                {
                    negative += item;
                }
                if (item > 0)
                {
                    positive += item;
                }
            }
            Console.WriteLine($"Positive = {positive}/ Negative = {negative}");
        }
    }
}