using System.Threading.Tasks;
using BackEnd.Provider;
using NUnit.Framework;
using BackEnd.Service;
using System.Linq;

namespace BackEndTest;

public class Employee {

    DataContext context;
    EmployeeService employeeService;

    [SetUp]
    public void Setup() {
        context = new DataContext(CrossCutting.ConnectionString);
        employeeService = new EmployeeService(context);
    }

    [Test]
    public async Task NotNull_Employees() {
        var result = await employeeService.RetrieveAsync();
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task MoreThan_Two_Employees() {
        var result = await employeeService.RetrieveAsync();
        Assert.GreaterOrEqual(result.Count(), 2);
    }

}
