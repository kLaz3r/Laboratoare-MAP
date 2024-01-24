using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Chain_Of_Responsibility
{
    public class DepartmentDirector : Employee
    {
        protected override void ApproveVacation(VacationRequest request)
        {
            Console.WriteLine($"Department Director approved {request.NumberOfWorkingDays} days off.");
        }

        protected override int GetMaxVacationDaysCanApprove()
        {
            return 15;
        }
    }
}
