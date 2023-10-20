using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            DataService resp = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Кондраков А.А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет требуемое значение       *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит значение *");
            Console.WriteLine("* x, y с клавиатуры, если x < y -1, то z = y + (y-1)/(x+2) иначе          *");
            Console.WriteLine("* x+2y(1/(y+3))                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(resp.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
