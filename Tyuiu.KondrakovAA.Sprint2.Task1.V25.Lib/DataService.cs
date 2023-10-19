using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KondrakovAA.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //  (True, False, True, False, True, False), при a = 247, b = 155, c = 325, d = 857
            bool[] response = new bool[6];
            response[0] = (a == b) | (c == d - 532);
            response[1] = d != 133 & c != 325;
            response[2] = b < a || d < c;
            response[3] = b > c && a > d;
            response[4] = !(a <= b);
            response[5] = (c >= d) ^ (b >= a + c);
            return response;
        }
    }
}
