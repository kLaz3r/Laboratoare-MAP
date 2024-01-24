using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Chain_Of_Responsibility
{
    class Program
    {
        static void Main()
        {
            Employee teamLeader = new TeamLeader();
            Employee projectLeader = new ProjectLeader();
            Employee departmentDirector = new DepartmentDirector();

            teamLeader.SetSupervisor(projectLeader);
            projectLeader.SetSupervisor(departmentDirector);

            VacationRequest request1 = new VacationRequest(7);
            VacationRequest request2 = new VacationRequest(12);
            VacationRequest request3 = new VacationRequest(20);

            teamLeader.ApplyVacation(request1);
            teamLeader.ApplyVacation(request2);
            teamLeader.ApplyVacation(request3);
        }
    }
}
