using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDBTest
{
    class Student
    {
        public int ID { get; private set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Student (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
