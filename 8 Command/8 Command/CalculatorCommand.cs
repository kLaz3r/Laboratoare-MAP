using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Command
{
    public class CalculatorCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly char _operator;
        private readonly double _operand;
        private double _previousValue;

        public CalculatorCommand(Calculator calculator, char @operator, double operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public void Execute()
        {
            _previousValue = _calculator.CurrentValue;
            _calculator.DoOperation(_operator, _operand);
        }

    }
}
