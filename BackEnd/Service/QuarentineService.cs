using Microsoft.EntityFrameworkCore;
using BackEnd.Interface.Domain;
using BackEnd.Provider;
using BackEnd.Entity;

namespace BackEnd.Service;

public class QuarentineService : IQuarentine {

    private Employee?               _employee;
    private DataContext?            _context;
    private IEnumerable<string>?    _relatedTo;

    public QuarentineService(DataContext context) => _context = context;

    public void SetEmail(string email) => _employee = new Employee() { Email = email };

    public void SetEmailNotifications(IEnumerable<string> emails) => _relatedTo = emails;

    public bool IsValid() {
        if (_employee == null)
            return false;

        if (_employee.Email == null)
            return false;

        if (!FluentValidation.IsEmail(_employee.Email))
            return false;

        if (_relatedTo == null)
            return false;

        if (_relatedTo.Count() <= 0)
            return false;

        return true;
    }

    public async Task<bool> SaveAsync(){
        var res = false;
        if (IsValid())
            if (await SetEmployeeAsync()){
                foreach (var item in _relatedTo!)
                    await SetQuarentineAsync(item);
                res = await _context!.SaveChangesAsync() > 0;
            }
        return res;
    }

    private async Task<bool> SetEmployeeAsync() {

        if (_employee?.Id == 0)
            _employee = await _context!.Employees.SingleOrDefaultAsync(
                c => c.Email.Equals(_employee.Email)
           );

        if (_employee == null)
            return false;
        
        return _employee!.Id != 0;

    }

    private async Task SetQuarentineAsync(string relatedEmail) {        
        await _context!.Quarentines.AddAsync(new Quarentine() {
            CreatedAt = DateTime.Now,
            Employee = _employee!,
            RelatedEmail = relatedEmail
        });
    }

}
