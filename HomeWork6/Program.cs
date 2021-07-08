using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
            // Задача 6
            //Сандин М.С.
            //* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
            //000. «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать
            //подсчёт времени выполнения программы, используя структуру DateTime.
    class Program
    {
        #region проверка числа
        static int summ (int a)
        {   
            
            int summ = 0;
            do
            {   

                summ = summ + a % 10;
                a = a /10;

            }
            while (a != 0);

            return summ;
        }
        #endregion

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                             
                if (i % summ(i ) == 0)
                count++;             
            }

            Console.WriteLine(count + "хороших чисел");
           
            DateTime finish = DateTime.Now;
            Console.WriteLine("Время выполнения программы " + (finish - start));
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
