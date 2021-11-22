using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXMachulaDZ3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Написать программу для нахождения суммы первых n чисел последовательности Фибоначчи, где значение n не превышает значение 45.Примечание.Числа(последовательность) Фибоначчи – это последовательность чисел, в которой каждое следующее число является суммой двух предыдущих: 0, 1, 1, 2, 3, 5, 8, 13... (F0 = 0, F1 = 1, F(n) = F(n - 1) + F(n - 2) для n > 1)");
            int n, res, F0, F1, next, step;
             n = Convert.ToInt32(Console.ReadLine());
             res = 0;
            F0 = 0;
            F1 = 1;
            for (step = 0; step < n; step++ )
            {
                res = res + F0;
                next = F0 + F1;
                F0 = F1;
                F1 = next;
            }
            Console.WriteLine($"Сумма первых указанных {n} чисел последовательности Фиббоначи = {res}");
         

        }
    }
}
