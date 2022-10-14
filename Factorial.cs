using System;
using System.Collections.Generic;
using System.Text;

namespace Create_Class
{
    class Factorial
    {
        public int CalculateTheFactorial(int num)
        {
            int mult = 1;
            for (int i = 1; i <= num; i++)
            {
                mult *= i;
            }
            return mult;
        }
    }
}
