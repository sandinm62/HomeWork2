using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
            
            //Задача 3
            //Сандин М.С.
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
            //положительных чисел.



    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int i;

            Console.WriteLine("Введите несколько цифр, когда захотите узнать результат введите 0");
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 != 0 && i > 0) 
                       count = count + i;
                
                
            }
            while (i != 0);

            Console.WriteLine("Сумма нечетных чисел равна: " + count);
            Console.ReadKey();
            



        }
    }
}
