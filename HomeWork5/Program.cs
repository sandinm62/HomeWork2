using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
        
        //Задача 5
        //Сандин М.С.
        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
        //массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш вес в вилограммах?");
            string mass = Console.ReadLine();

            double m = Convert.ToDouble(mass);
            Console.WriteLine("Ваш рост в метрах?");

            string height = Console.ReadLine();
            double h = Convert.ToDouble(height);

            double i = m / (h * h);
            Console.WriteLine("Индекс массы тела: " + i);
            if (i <= 18.5)
            {
                double a = 18.5 * h * h;
                double kg = a - m;
                Console.WriteLine("Нужно набрать вес на " + kg + "килограмм");

            } else if (i > 24.99)
            {
                double a = 24.9 * h * h;
                double kg = m - a;
                Console.WriteLine("Нужно сбросить вес на " + kg + "килограмм") ;
            } else
            {
                Console.WriteLine("Вы в отличной форме");
            }


            Console.ReadKey();

        }
    }
}
