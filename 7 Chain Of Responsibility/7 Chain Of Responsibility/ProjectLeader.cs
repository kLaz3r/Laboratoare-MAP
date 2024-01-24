using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Chain_Of_Responsibility
{
    public class ProjectLeader : Employee
    {
        protected override void ApproveVacation(VacationRequest request)
        {
            Console.WriteLine($"Project Leader approved {request.NumberOfWorkingDays} days off.");
        }

        protected override int GetMaxVacationDaysCanApprove()
        {
            return 10;
        }
    }
}
