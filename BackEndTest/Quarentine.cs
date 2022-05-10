using BackEnd.Provider;
using BackEnd.Service;
using NUnit.Framework;

namespace BackEndTest;

public class Quarentine{

    QuarentineService? quarentineService;
    DataContext? context;

    [SetUp]
    public void Setup() {
        context = new DataContext(CrossCutting.ConnectionString);
        quarentineService = new QuarentineService(context);
    }

    [Test]
    public void ValidEmployee_NoRelated_Emails() {
        quarentineService!.SetEmail(CrossCutting.Gmail);
        Assert.That(quarentineService.SaveAsync, Is.False);
    }

    [Test]
    public void ValidEmployee_Related_Emails() {
        quarentineService!.SetEmail(CrossCutting.Gmail);
        quarentineService!.SetEmailNotifications(new[] {
            "one@provider.com.br",
            "two@provider.com.br",
            "three@provider.com.br"
        });
        Assert.That(quarentineService.SaveAsync, Is.True);
    }

    [Test]
    public void InvalidEmployee_Related_Emails() {
        quarentineService!.SetEmail("carlos@eduardo.com.br");        
        quarentineService!.SetEmailNotifications(new[] {
            "one@provider.com.br",
            "two@provider.com.br",
            "three@provider.com.br"
        });
        Assert.That(quarentineService.SaveAsync, Is.False);
    }

    [Test]
    public void InvalidEmployee_NoRelated_Emails() {
        quarentineService!.SetEmail("carlos@eduardo.com.br");
        Assert.That(quarentineService.SaveAsync, Is.False);
    }
}
