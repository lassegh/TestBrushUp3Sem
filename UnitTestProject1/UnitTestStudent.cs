using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBrushUp3Sem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStudent
    {
        private Student student;

        [TestInitialize]
        public void Initialize()
        {
            student = new Student()
            {
                Name = "Lasse",
                Address = "Skolevej 1",
                GenderOfPerson = Gender.Male,
                Semester = 3
            };
        }

        [TestMethod]
        public void TestSemester()
        {
            Assert.AreEqual(3, student.Semester);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSemesterAbove()
        {
            student.Semester = 9;
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSemesterBelow()
        {
            student.Semester = 0;
        }
    }
}
