using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Command
{
    internal class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            CalculatorInvoker calculatorInvoker = new CalculatorInvoker();

            ICommand addCommand = new CalculatorCommand(calculator, '+', 5);
            calculatorInvoker.SetCommand(addCommand);
            calculatorInvoker.Compute('+', 5);

            ICommand multiplyCommand = new CalculatorCommand(calculator, '*', 3);
            calculatorInvoker.SetCommand(multiplyCommand);
            calculatorInvoker.Compute('*', 3);

            ICommand divideCommand = new CalculatorCommand(calculator, '/', 2);
            calculatorInvoker.SetCommand(divideCommand);
            calculatorInvoker.Compute('/', 2);

            ICommand subtractCommand = new CalculatorCommand(calculator, '-', 4);
            calculatorInvoker.SetCommand(subtractCommand);
            calculatorInvoker.Compute('-', 4);
        }
    }
}
