using System;
using Katas;
using NUnit.Framework;

namespace GreetingKataTests
{

    [TestFixture]
    public class UnitTest1
    {

        private Greeter _greeter;

        [SetUp]
        public void Setup()
        {
            _greeter = new Greeter();
        }

        [Test]
        public void Greeter_hould_Return_String_Of_Hello_Plus_Input()
        {
            var name = "Some Name";
            var result = _greeter.Greet(name);

            Assert.AreEqual("Hello, " + name, result);
        }

        [Test]
        public void Gretter_Should_Return_My_Friend_When_Name_Is_Null()
        {
            var result = _greeter.Greet(null);

            Assert.AreEqual("Hello, My Friend", result);
        }

        [Test]
        public void Greeter_Should_Yell_Back_When_Name_Is_All_Caps()
        {
            var name = "DANNY BOY";
            var result = _greeter.Greet(name);

            Assert.AreEqual($"HELLO {name}!", result);
        }

        [Test]
        public void Greeter_Should_Greet_Multiple_Names()
        {
            var name1 = "test1";
            var name2 = "test2";
            var result = _greeter.Greet(name1, name2);
            Assert.AreEqual($"Hello, {name1} and {name2}", result);
        }

        [Test]
        public void Greeter_Should_Greet_Mixed_All_Caps_And_Normal_Results_First()
        {
            var name1 = "test1";
            var name2 = "test2";
            var name = "DANNY BOY";

            var result =_greeter.Greet(name1, name2, name);

            Assert.AreEqual($"Hello, {name1} and {name2}. HELLO {name}!", result);
        }
    }
}
