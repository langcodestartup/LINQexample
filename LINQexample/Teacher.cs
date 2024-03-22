using System;
using System.Collections.Generic;
using System.Text;

namespace LINQexample
{
    internal class Teacher
    {
        public string Name { get; set; }
        public Subject SubjectInCharge { get; set; }
        public List<Student> Students { get; set; }
    }
}
