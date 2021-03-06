﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {   
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        public float Div(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Divisor cannot be 0");
            }

            return ((float)x / y);
        }

    }
}
