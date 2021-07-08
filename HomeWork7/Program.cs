using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    //Задача 7
    //Сандин М.С.
    //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    //б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
    class Program
    {

        static void Loop (int a, int b)
        {
            
            Console.Write("{0,3}",a);
            
            if (a < b)
                Loop(a + 1, b);

           
        }
        static int Summ (int a, int b, int sum)
        {

            
            if (a <= b)
            {
                sum = sum + a;
                return Summ(a + 1, b, sum);
            }
            return sum;






        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 10;
            int sum = 0;
            Loop(a, b);
            
            Console.WriteLine("\nСумма чисел равна: " + Summ(a, b, sum));
            
            Console.ReadKey();
        }
    }
}
