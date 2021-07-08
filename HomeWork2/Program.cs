using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
   // Задача 2
   // Сандин М.С.
   // 2. Написать метод подсчета количества цифр числа.
    class Program
    {

        static int Count( int b)
        {
            int i = 0;
            while ( b != 0)
            {
                b = b / 10;
                i++;
            }
            return i;
        }


    static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int  a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Количество цифр в числе равно = " + Count(a));
            Console.ReadKey();



        }
    }
}
