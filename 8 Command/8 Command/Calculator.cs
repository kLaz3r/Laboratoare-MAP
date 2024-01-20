using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Command
{
    public class Calculator
    {
        private double _currentValue;

        public double CurrentValue
        {
            get { return _currentValue; }
            set { _currentValue = value; }
        }

        public void DoOperation(char @operator, double operand)
        {
            switch (@operator)
            {
                case '+':
                    _currentValue += operand;
                    break;
                case '-':
                    _currentValue -= operand;
                    break;
                case '*':
                    _currentValue *= operand;
                    break;
                case '/':
                    if (operand != 0)
                    {
                        _currentValue /= operand;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            Console.WriteLine($"Result: {_currentValue}");
        }
    }
}
