using System;
using System.Collections.Generic;
using System.Text;

namespace TestBrushUp3Sem
{
    public class Teacher : Person
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary must be zero or greater");
                }
                _salary = value;
            }
        }
    }
}
