using Employee_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management.Database
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}