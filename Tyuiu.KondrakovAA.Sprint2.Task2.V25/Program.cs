using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint2.Task2.V25.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            DataService resp = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Кондраков А.А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу на, которая запрашивает целые значения с    *");
            Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y в          *");
            Console.WriteLine("* заштрихованной области.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(resp.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
