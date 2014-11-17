using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CI_Test
{
    public class Calculator
    {
        public bool change = true;

        public int Add(int x, int y) 
        {
            return x + y;
        }

        public int Multiply(int x, int y) 
        {
            return x * y;
        }

        public int Difference(int x, int y)
        {
            return Math.Abs(x - y);
        }
    }
}
