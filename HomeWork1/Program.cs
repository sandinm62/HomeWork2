using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
             // Задача 1
             //Сандин М.С.
             //1. Написать метод, возвращающий минимальное из трёх чисел.
    class Program
    {


        #region метод расчёта минимального числа из трёх
        static double Min(double z, double x, double c)
        {
            
            if (z < x && z < c)
            {
                return z;
            } 
            else if (x < z && x < c)
            {
                return x;
            } else 
            {
                return c;
            }

            
        }
        #endregion
        static void Main(string[] args)
        {
            

            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Минимально число: " + Min(a,b,c));
            Console.WriteLine("Для выхода из программы нажмите на любую клавишу.");
            Console.ReadKey();





        }
    }
}
