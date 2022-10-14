using System;
using System.Collections.Generic;
using System.Text;

namespace Create_Class
{
    class Calculator
    {
        public void Calculation(float num1, char ope, float num2)
        {
            switch (ope)
            {
                case '+':
                    Console.WriteLine("Addition = " + (num1 + num2)); 
                    break;
                case '-':
                    Console.WriteLine("Subtraction = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Please enter a correct operator.");
                    break;
            }
        }
    }
}
