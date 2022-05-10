using Microsoft.EntityFrameworkCore;
using BackEnd.Interface.Domain;
using BackEnd.Provider;
using BackEnd.Entity;

namespace BackEnd.Service;

public class ActivityService : IActivity{

    private ActivityType?        _activityType;
    private Employee?            _employee;
    private DataContext?         _context;

    public ActivityService(DataContext context) => _context = context;

    public void SetEmail(string email) => _employee = new Employee() { Email = email };

    public void SetEntrance()
        => _activityType = _context?.ActivityTypes.SingleOrDefault(c => c.Name.Equals("In"));

    public void SetExit()
        => _activityType = _context?.ActivityTypes.SingleOrDefault(c => c.Name.Equals("Out"));

    public bool IsValid() {
        if (_employee == null)
            return false;

        if (_employee.Email == null)
            return false;

        if (!FluentValidation.IsEmail(_employee.Email))
            return false;
        
        return true;
    }

    public async Task<IEnumerable<EmployeeActivityDTO>?> RetrieveAsync() {
        IEnumerable<EmployeeActivityDTO>? res = null;

        if (IsValid())
            res = await _context!.EmployeeActivities.Where(
                e => e.Employee.Email.Equals(_employee!.Email)
            ).Select(ea => new EmployeeActivityDTO() {
                Id = ea.Id,
                Email = ea.Employee.Email,
                Period = ea.CreatedAt,
                Action = ea.ActivityType.Name
            }).ToListAsync();

        return res;
    }

    public async Task<bool> SaveAsync(){
        var res = false;
        if (IsValid()){
            if(await SetEmployeeAsync())
                res = await SetEmployeeActivityAsync();
        }
        return res;
    }

    private async Task<bool> SetEmployeeAsync() {
        if (_employee?.Id == 0) {
            string email = _employee.Email;
            _employee = await _context!.Employees.SingleOrDefaultAsync(c => c.Email.Equals(email));
            if(_employee == null) {
                _employee = new Employee() { Email = email };
                await _context!.Employees.AddAsync(_employee);
                await _context.SaveChangesAsync();
            }
        }
        return _employee!.Id != 0;
    }

    private async Task<bool> SetEmployeeActivityAsync() {
        await _context!.EmployeeActivities.AddAsync(new EmployeeActivity() {
            ActivityType = _activityType!,
            CreatedAt = DateTime.Now,
            Employee = _employee!
        });
        return await _context.SaveChangesAsync() > 0;
    }

}
