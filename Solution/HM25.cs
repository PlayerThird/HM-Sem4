//Напишите цикл, который принимает на вход два числа(А и В)
//И возводит число А в натуральную степень В
using Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class HM25
    {
        internal static void Start()
        {
            Console.WriteLine("Введите число, которое нужно возвести в степень");
            double A = Convert.ToDouble(Console.ReadLine());
           
            int B = Checker.CheckInput<int>(x => x <= 0, "Введите степень выше нуля", "ВЫШЕ НУЛЯ!");
            double C = Math.Pow(A,B);
            Console.WriteLine($"Итоговое значение = {C}");
        }
    }
}
