using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint2.Task6.V3.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService resp = new DataService();
            int x;

            Console.Title = "Спринт #2 | Выполнил: Кондраков А.А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу, которая использует сокращенную форму       *");
            Console.WriteLine("* записи оператора switch вычисляет требуемое значение и возвращает       *");
            Console.WriteLine("* результат. Условие: Составить программу, которая в зависимости от       *");
            Console.WriteLine("* порядкового номера дня недели (1, 2, …, 7) выводит на экран его         *");
            Console.WriteLine("* название (понедельник, вторник, …, воскресенье).                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число x (порядковый номер дня)");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(resp.FindDayName(x));
            Console.ReadKey();
        }
    }
}
