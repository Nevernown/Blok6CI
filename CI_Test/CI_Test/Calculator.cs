using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CI_Test
{
    public class Calculator
    {
        public int Add(int x, int y) 
        {
            return x + y;
        }

        public int Multiply(int x, int y) 
        {
            return x * y;
        }

        public int difference(int x, int y)
        {
            return Math.Abs(x - y);
        }
    }
}
