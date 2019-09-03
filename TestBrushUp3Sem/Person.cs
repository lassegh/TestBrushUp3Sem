using System;
using System.Collections.Generic;
using System.Text;

namespace TestBrushUp3Sem
{
    public class Person
    {
        private string _name;
        private string _address;
        private Gender _genderOfPerson;

        /// <summary>
        /// Name of student. Throws exception if name is too short.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Navn er for kort");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Student's address. Throws exception if address is not entered.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Indtast en adresse");
                }
                _address = value;
            }
        }

        /// <summary>
        /// Gender of student.
        /// </summary>
        public Gender GenderOfPerson
        {
            get { return _genderOfPerson; }
            set { _genderOfPerson = value; }
        }
    }
}
