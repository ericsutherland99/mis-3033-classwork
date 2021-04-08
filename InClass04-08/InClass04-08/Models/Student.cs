using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InClass04_08.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName {get; set;}

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}
