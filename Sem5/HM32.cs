using System;

namespace Sem5
{
    internal class HM32
    {
        internal static void Start()
        {
            int[] mass = Mass.CreateRandomArray(10, -100, 101);
            Mass.ShowArray(mass);
            int i = 0;
            foreach (var item in mass)
            {
                if (item < 0)
                {
                    mass[i] = Math.Abs(mass[i]);
                }
                if (item > 0)
                {
                    mass[i] *= -1;
                }
                i++;
            }
            Mass.ShowArray(mass);
        }
    }
}