using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Chain_Of_Responsibility
{
    public class VacationRequest
    {
        public int NumberOfWorkingDays { get; set; }

        public VacationRequest(int numberOfWorkingDays)
        {
            NumberOfWorkingDays = numberOfWorkingDays;
        }
    }
}
