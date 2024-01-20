using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Command
{
    public class CalculatorInvoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Compute(char @operator, double operand)
        {
            _command.Execute();
        }
    }
}
