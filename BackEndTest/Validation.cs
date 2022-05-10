using BackEnd.Provider;
using NUnit.Framework;

namespace BackEndTest;

public class Validation {

    [Test]
    public void WhenValidEmail()
        => Assert.IsTrue(FluentValidation.IsEmail(CrossCutting.Gmail));

    [Test]
    public void WhenInvalidEmail()
        => Assert.IsFalse(FluentValidation.IsEmail("worldcellos"));

}
