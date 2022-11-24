using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp1
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        //public string FullName()
        //{
        //    return $"{LastName}, {FirstName}";
        //}

        public Student()
        {
            FirstName = "";
            LastName = "";
            IdNumber = 200012345;
        }

        public Student(string firstName, string lastName, int idNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdNumber = idNumber;
        }   
    }
}
