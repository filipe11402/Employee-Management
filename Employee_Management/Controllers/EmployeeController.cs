using Employee_Management.Database;
using Employee_Management.Models;
using Employee_Management.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMediator _Mediator;

        public EmployeeController(IMediator mediator)
        {
            _Mediator = mediator;

        }

        public async Task<IActionResult> Index()
        {

            IEnumerable<Employee> employeeList = await _Mediator.Send(new GetEmployeeQuery());

            return await Task.FromResult(View(employeeList));
        }
    }
}
