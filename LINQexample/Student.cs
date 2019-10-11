using System;
using System.Collections.Generic;
using System.Text;

namespace LINQexample
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Dictionary<Subject, int> ScoreDict { get; set; }

        public Student(string name, int grade, int koreanScore, int mathScore, int englishScore)
        {
            Name = name;
            Grade = grade;
            ScoreDict = new Dictionary<Subject, int> {
                { Subject.Korean, koreanScore },
                { Subject.Math, mathScore },
                { Subject.English, englishScore }
            };
        }
    }
}
