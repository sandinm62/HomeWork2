using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
        //Задача 4
        //Сандин М.С.
        //Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На
        //выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
        //GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
        //вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
        //цикла do while ограничить ввод пароля тремя попытками.
    class Program
    {
        

        static bool verification(string log, string pass)
        {
                    return (log == "root" && pass == "GeekBrains");
        }
        static void Main(string[] args)
        {
            int count = 1;
            do
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(((verification(login, password)) ? "Данные введены верно" : "Данные введены неверно" ));
            Console.WriteLine("========================");
            Console.WriteLine("Попыток осталось: " + (3-count));

                if (verification(login, password) == true)             
                    break;


            count++;
                
            


         } while (count <= 3);

            Console.ReadKey();




        }
    }
}
