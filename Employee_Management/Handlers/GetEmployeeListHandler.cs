using Employee_Management.Database;
using Employee_Management.Models;
using Employee_Management.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Employee_Management.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeQuery, IEnumerable<Employee>>
    {
        private readonly IApplicationDbContext _EmployeeDb;

        public GetEmployeeListHandler(IApplicationDbContext employeeDb)
        {
            _EmployeeDb = employeeDb;
        }

        public async Task<IEnumerable<Employee>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Employee> employeeList = _EmployeeDb.Employees;

            return await Task.FromResult(employeeList);
        }
    }
}
