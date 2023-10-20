using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.KondrakovAA.Sprint2.Task5.V5
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
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Кондраков Александр Артемович | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу, которая использует оператор switch         *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат. Условие: Игральным *");
            Console.WriteLine("* картам условно присвоены следующие порядковые номера в зависимости от   *");
            Console.WriteLine("* их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. *");
            Console.WriteLine("* Порядковые номера остальных карт соответствуют их названиям («шестерка» *");
            Console.WriteLine("* «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14)           *");
            Console.WriteLine("* определить достоинство соответствующей карты.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число x (порядковый номер карты)");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(resp.FindCardValue(x));
            Console.ReadKey();
        }
    }
}
