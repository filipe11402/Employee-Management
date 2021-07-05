using Employee_Management.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Queries
{
    public class GetEmployeeQuery : IRequest<IEnumerable<Employee>>
    {
    }
}
