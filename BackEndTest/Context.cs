using BackEnd.Provider;
using NUnit.Framework;
using BackEnd.Entity;
using System.Linq;

namespace BackEndTest;

public class Context {

    ActivityType? firstEntity;
    ActivityType? secondEntity;

    [SetUp]
    public void Setup() {
        using var context = new DataContext(CrossCutting.ConnectionString);
        firstEntity = context.ActivityTypes.SingleOrDefault(x => x.Id == CrossCutting.EntranceId);
        secondEntity = context.ActivityTypes.SingleOrDefault(x => x.Id == CrossCutting.ExitId);
    }

    [Test]
    public void IdOne_Should_NotBe_Null() => Assert.IsNotNull(firstEntity);

    [Test]
    public void IdTwo_Should_NotBe_Null() => Assert.IsNotNull(secondEntity);

    [Test]
    public void IdOne_Should_Be_In() => Assert.AreEqual(firstEntity.Name, CrossCutting.EntranceSlug);

    [Test]
    public void IdTwo_Should_Be_Out() => Assert.AreEqual(secondEntity.Name, CrossCutting.ExitSlug);

}
