using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsu.HackathonProblem.Contracts
{
    public record Wishlist(int EmployeeId, int[] DesiredEmployees);
}
