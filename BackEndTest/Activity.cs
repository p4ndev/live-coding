using System.Threading.Tasks;
using BackEnd.Provider;
using BackEnd.Service;
using NUnit.Framework;
using System.Linq;

namespace BackEndTest;

public class Activity{

    ActivityService? activityService;
    DataContext? context;

    [SetUp]
    public void Setup() {
        context = new DataContext(CrossCutting.ConnectionString);
        activityService = new ActivityService(context);
    }

    [Test]
    public void EmailEntrance_Validation() {
        activityService.SetEmail(CrossCutting.Gmail);
        activityService.SetEntrance();
        Assert.IsTrue(activityService.IsValid());
    }

    [Test]
    public void EmailExit_Validation() {
        activityService.SetEmail(CrossCutting.Gmail);
        activityService.SetEntrance();
        Assert.IsTrue(activityService.IsValid());
    }

    [Test]
    public async Task Register_Activity_In() {
        activityService.SetEmail(CrossCutting.Gmail);
        activityService.SetEntrance();
        var result = await activityService.SaveAsync();
        Assert.IsTrue(result);
    }

    [Test]
    public async Task Register_Activity_Out() {
        activityService.SetEmail(CrossCutting.Hotmail);
        activityService.SetExit();
        var result = await activityService.SaveAsync();
        Assert.IsTrue(result);
    }

    [Test]
    public async Task Activities_FromValid_Employee() {
        activityService.SetEmail(CrossCutting.Gmail);
        var result = await activityService.RetrieveAsync();
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task Activities_FromEmpty_Employee(){
        activityService.SetEmail("marcos@uol.com.br");
        var result = await activityService.RetrieveAsync();
        Assert.IsEmpty(result);
    }

    [Test]
    public async Task Activities_FromInvalid_EmployeeEmail(){
        activityService.SetEmail("marcos");
        var result = await activityService.RetrieveAsync();
        Assert.IsNull(result);
    }

    [Test]
    public async Task Activities_GreatherThan_Three(){
        activityService.SetEmail(CrossCutting.Hotmail);
        var result = await activityService.RetrieveAsync();
        Assert.GreaterOrEqual(result.Count(), 3);
    }

}
