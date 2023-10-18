using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KondrakovAA.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] response = new bool[6];
            response[0] = (a == b) | (c == d);
            response[1] = d != 133 & c != 174;
            response[2] = b < a || d < c;
            response[3] = b > c && a > d;
            response[4] = !(a <= 1083 - b);
            response[5] = (c >= d) ^ (b >= a - 746);
            return response;
        }
    }
}
