using System;
using GreetingKata;
using NUnit.Framework;

namespace GreetingKataTests
{

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void  Greeter_hould_Return_String_Of_Hello_Plus_Input()
        {
            var name = "Some Name";
            var greeter = new Greeter();
            var result = greeter.Greet(name);

            Assert.AreEqual("Hello, " + name, result);
        }

        [Test]
        public void Gretter_Should_Return_My_Friend_When_Name_Is_Null()
        {
            var g = new Greeter();
            var result = g.Greet(null);

            Assert.AreEqual("Hello, My Friend", result);
        }

        [Test]
        public void Greeter_Should_Yell_Back_When_Name_Is_All_Caps()
        {
            var name = "DANNY BOY";
            var g = new Greeter();
            var result = g.Greet(name);

            Assert.AreEqual($"HELLO {name}!", result);
        }
    }
}
