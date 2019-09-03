using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBrushUp3Sem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestPerson
    {
        private Person person;

        [TestInitializeAttribute]
        public void Initialize()
        {
            person = new Person()
            {
                Address = "Et Sted i verden",
                GenderOfPerson = Gender.Female,
                Name = "Siri"
            };
        }

        [TestMethod]
        public void TestGender()
        {
            Assert.AreEqual(person.GenderOfPerson, Gender.Female);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Siri",person.Name);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestNameFail()
        {
            person.Name = "L";
        }

        [TestMethod]
        public void TestAddress()
        {
            Assert.AreEqual("Et Sted i verden", person.Address);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestAddressFail()
        {
            person.Address = "";
        }
    }
}
