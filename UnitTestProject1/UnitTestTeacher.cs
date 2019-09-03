using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBrushUp3Sem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestTeacher
    {
        private Teacher teacher;

        [TestInitialize]
        public void Initialize()
        {
            teacher = new Teacher()
            {
                Address = "TeacherRoad 1",
                GenderOfPerson = Gender.Female,
                Name = "Hr. Olsen",
                Salary = 7000
            };
        }

        [TestMethod]
        public void TestSalary()
        {
            Assert.AreEqual(teacher.Salary,7000,0.0001);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSalaryFail()
        {
            teacher.Salary = -1;
        }
    }
}
