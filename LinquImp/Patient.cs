using System;
using System.Collections.Generic;
using System.Text;

namespace LinquImp
{
    internal class Patient
    {
        public Patient() { }
        private string name;
        private int age;
        private string gender;
        private string city;

        public string PatientName {
            get { return name; }
            set { name = value; }
        }
        public int Age
        { get { return age; }
            set {  age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}