using Microsoft.EntityFrameworkCore;
using BackEnd.Interface.Domain;
using BackEnd.Provider;
using BackEnd.Entity;

namespace BackEnd.Service;

public class EmployeeService : IEmployee{

    private DataContext?         _context;

    public EmployeeService(DataContext context) => _context = context;

    public async Task<IEnumerable<EmployeeDTO>?> RetrieveAsync()
        => await _context!.Employees.Select(e => new EmployeeDTO() {
            Id = e.Id,
            Email = e.Email
        }).ToListAsync();
}
