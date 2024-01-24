using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Chain_Of_Responsibility
{
    public class TeamLeader : Employee
    {
        protected override void ApproveVacation(VacationRequest request)
        {
            Console.WriteLine($"Team Leader approved {request.NumberOfWorkingDays} days off.");
        }

        protected override int GetMaxVacationDaysCanApprove()
        {
            return 5;
        }
    }
}
