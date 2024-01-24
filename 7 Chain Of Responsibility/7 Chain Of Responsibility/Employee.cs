using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Chain_Of_Responsibility
{
    public abstract class Employee
    {
        protected Employee Supervisor;

        public void SetSupervisor(Employee supervisor)
        {
            Supervisor = supervisor;
        }

        public void ApplyVacation(VacationRequest request)
        {
            if (GetMaxVacationDaysCanApprove() >= request.NumberOfWorkingDays)
            {
                ApproveVacation(request);
            }
            else if (Supervisor != null)
            {
                Supervisor.ApplyVacation(request);
            }
            else
            {
                Console.WriteLine("Request denied. Special approval needed.");
            }
        }

        protected abstract void ApproveVacation(VacationRequest request);

        protected abstract int GetMaxVacationDaysCanApprove();
    }
}
