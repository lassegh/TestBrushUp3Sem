using System;
using System.Collections.Generic;
using System.Text;

namespace TestBrushUp3Sem
{
    /// <summary>
    /// Class for Students.
    /// Information like name, address, semester and gender are stored.
    /// </summary>
    public class Student : Person
    {
        private int _semester;
        private Gender _genderOfStudent;

        public Student()
        {

        }

        /// <summary>
        /// Student's semester. Must be 1-8.
        /// </summary>
        public int Semester
        {
            get { return _semester; }
            set
            {
                if (value < 1 || value > 8)
                {
                    throw new ArgumentOutOfRangeException("Semester skal være mellem 1 og 8");
                }
                _semester = value;
            }
        }
    }
}
