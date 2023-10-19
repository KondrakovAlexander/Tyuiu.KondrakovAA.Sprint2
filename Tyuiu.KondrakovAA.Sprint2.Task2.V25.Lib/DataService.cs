using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KondrakovAA.Sprint2.Task2.V25.Lib
{
    public class DataService : ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool[,] map = new bool[15, 15]{ 
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                { false, false, true, true, true, false, false, false, true, true, true, true, false, false, false},
                { false, false, true, true, true, false, false, false, true, true, true, true, false, false, false},
                { true, true, true, true,true, true, true, true,true, true, true, true, false, false, false},
                { true, true, true, true,true, true, true, true,true, true, true, true,true, false, false},
                { false, false, true, true, true, true,true, true, true, true,true, true, true, false, false},
                { false, false, false, false, false, true, true, true, true,true, true, true, true, false, false},
                { false, false, false, false, false, true, true, false, false, true, true, false, false, false, false},
                { false, false, false, false, false, true, true, false, false, true, true, false, false, false, false},
                { false, false, true, true, true, true, true, false, false, true, true, false, false, false, false},
                { false, false, false, false, false, false, true, false, false, true, false, false, false, false, false},
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
            };

            if (map[x, y] == true)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
