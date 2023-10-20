using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KondrakovAA.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int x)
        {
            switch (x){
                case 6: return "шестерка";
                case 7: return "семерка";
                case 8: return "восьмерка";
                case 9: return "девятка";
                case 10: return "десятка";
                case 11: return "валет";
                case 12: return "дама";
                case 13: return "король";
                case 14: return "туз";
            }
            return "";
        }
    }
}
