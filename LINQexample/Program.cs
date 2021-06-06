using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQexample
{
    class Program
    {
        static void Main(string[] args)
        {
            // seed data
            var s1 = new Student("김서울", 1, 80, 70, 90);
            var s2 = new Student("이박사", 1, 40, 40, 20);
            var s3 = new Student("신바람", 3, 82, 75, 46);
            var s4 = new Student("홍길동", 2, 73, 67, 20);
            var s5 = new Student("박사장", 2, 24, 55, 30);
            var s6 = new Student("신나래", 3, 100, 80, 95);
            var s7 = new Student("오병수", 1, 77, 67, 96);
            var s8 = new Student("황올갑", 2, 83, 91, 92);
            var s9 = new Student("전후제", 1, 80, 90, 100);
            var s10 = new Student("김수이", 1, 100, 50, 20);
            var s11 = new Student("백무원", 3, 10, 35, 43);
            var s12 = new Student("신교준", 1, 33, 45, 31);

            var t1 = new Teacher { Name = "김국어", SubjectInCharge = Subject.Korean };
            var t2 = new Teacher { Name = "이수학", SubjectInCharge = Subject.Math };
            var t3 = new Teacher { Name = "박영어", SubjectInCharge = Subject.English };
            var t4 = new Teacher { Name = "오모리", SubjectInCharge = Subject.Korean };

            var school1 = new School { Name = "욜로고" };
            var school2 = new School { Name = "오지고" };

            // relationship
            school1.Teachers = new List<Teacher> { t1, t2 };
            school2.Teachers = new List<Teacher> { t3, t4 };

            t1.Students = new List<Student> { s1, s2, s3 };
            t2.Students = new List<Student> { s4, s5, s6 };
            t3.Students = new List<Student> { s7, s8, s9 };
            t4.Students = new List<Student> { s10, s11, s12 };

            // schools
            var schools = new List<School> { school1, school2 };
            // teachers
            var teachers = new List<Teacher> { t1, t2, t3, t4 };
            // students
            var students = new List<Student> { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12 };

            // EXAMPLES

            // #1 Select()
            // use Select() to select element's property or project to other form (object of different class, anonymous object, value, list, ...)
            // #1-1 get the list of school names
            var schoolNames = schools
                .Select(x => x.Name)
                .ToList();

            // #1-2 project to anonymous object
            // get the list of each school's name & the number of teachers pair (anonymous object)
            var schoolNameAndStudentNums = schools
                .Select(x => new { x.Name, x.Teachers.Count }) // = new { Name = x.Name, Count = x.Teachers.Count }
                .ToList();

            // #1-3 create new object from element
            var studentBecomeTeacher = students
                .Select(x => new Teacher { Name = x.Name })
                .ToList();

            // #2 Where()
            // use Where() to filter elements by condition (boolean expression)
            // #2-1 get the list of 3rd grade students
            var thirdGrades = students
                .Where(x => x.Grade == 3)
                .ToList();

            // #2-2 combine Where() and Select() to get the list of 3rd grade students' name
            var thirdGradeNames = students
                .Where(x => x.Grade == 3)
                .Select(x => x.Name)
                .ToList();

            // #2-3 use method and external variable in query
            var familyName = "김";
            var kimStudentNames = students
                .Where(x => x.Name.StartsWith(familyName))
                .Select(x => x.Name)
                .ToList();

            // #3 OrderBy(), ThenBy()
            // use OrderBy() or OrderByDescending() to sort elements
            // use ThenBy() to set secondary sort condition
            // #3-1 get the list of students sorted by their name
            var sortedStudentNames = students
                .OrderBy(x => x.Name)
                .ToList();

            // #3-2 combine Where(), OrderBy() and Select()
            var thirdGradeSortedNames = students
                .Where(x => x.Grade == 3)
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList();
            // almost every LINQ query can have multiple forms that return the same result.
            var thirdGradeSortedNames2 = students
                .Where(x => x.Grade == 3)
                .Select(x => x.Name)
                .OrderBy(x => x)
                .ToList();

            // #3-3 sort by grade and then by name
            var sortThen = students
                .OrderBy(x => x.Grade)
                .ThenBy(x => x.Name)
                .ToList();

            // #4 return a single element
            // use First(), Last(), ElementAt(), Single() to return a single element of specific position and condition.
            // #4-1 get the first student of the sorted list of students
            var firstStudent = students
                .OrderBy(x => x.Name)
                .First();

            // #4-2 get the third ~
            var thirdStudent = students
                .OrderBy(x => x.Name)
                .ElementAt(2); // always remember that index start from zero

            // #4-3 get the list of teachers in "욜로고"
            // use First() with a lambda expression that defines condition
            var yoloSchool = schools
                .First(x => x.Name == "욜로고");
            // if there is no matching element, First() throws an error
            // alternatively, FirstOrDefault() returns the default value of the element's type.
            // also LastOrDefault(), ElementAtOrDefault(), SingleOrDefault()
            // since School is a class, the default value is null
            var firstOrDefault = schools
                .FirstOrDefault(x => x.Name == "없어요");
            // Adv) to prevent NullReferenceException, use null-conditional operators "?." and "?[]"
            var nullConditional = schools
                .FirstOrDefault(x => x.Name == "없어요")
                ?.Teachers;

            // tip
            // in fact, you don't have to use ElementAt if you get the result as List by ToList
            var sortedByName = students
                .OrderBy(x => x.Name)
                .ToList();
            var theThird = sortedByName[2];
            // also, if you don't want to check the singularity of the element, use First, not Single
            // usage ranking in real code
            // FirstOrDefault >>>>>> (many gaps) >>>>>> LastOrDefault >= First >= Last >>>>>>>> (ultra gap) >>>>>>> ElementAt >>>>>>>>> Single 

            // #5 GroupBy()
            // use GroupBy() to group elements
            // #5-1 group students by their grade
            var gradeGroup = students
                .GroupBy(x => x.Grade)
                .ToList();
            // GroupBy() return IGrouping<T1, T2> object
            foreach (var item in gradeGroup)
            {
                var key = item.Key; // for this, key is Grade
                var studentsInGroup = item.ToList(); // get the elements in IGrouping
            }

            // #5-2 get the list of the number of students in each grade
            var gradeCounts = students
                .GroupBy(x => x.Grade)
                .Select(x => x.Count())
                .ToList();
            // PROBLEM: what does gradeCounts[0] mean? is it always the number of first grade students?
            // use Select() can help
            var gradeCountPairs = students
                .GroupBy(x => x.Grade)
                .Select(x => new { grade = x.Key, count = x.Count() })
                .ToList();

            // #6 ToDictionary(), ToLookUp()
            // use ToDictionary() to return query result as a dictionary
            // ToLookUp is almost the same as ToDictionary when its type is Dictionary<T1, List<T2>>
            // ToDictionary() doesn't allow duplicated keys, ToLookUp() naturally supports duplication.
            // but prefer to use ToDictionary(). Dictionary is faster and used widely.
            // #6-1 grade as key and list of students as value
            var studentGradeDict = students
                .GroupBy(x => x.Grade)
                .ToDictionary(x => x.Key, x => x.ToList());
            // Unlike ToList(), ToDictionary() needs two selector (lambda expression)
            // first for key, second for value
            // this GroupBy() and ToDictionary(x => x.Key, x => x.ToList()) syntax is frequently used.

            // #6-2 use ToLookUp()
            var studentGradeLookUp = students
                .ToLookup(x => x.Grade);
            for (int i = 1; i < 4; i++)
            {
                var iGradeStudents = studentGradeDict[i];
                var iGradeStudentsFromLookUp = studentGradeLookUp[i].ToList();
            }

            // #7 SelectMany()
            // use SelectMany() to flatten nested list (list in list)
            // don't confuse. you only need SelectMany() when you need to flatten something
            // it doesn't matter you need to select many things from elements or not
            // #7-1 get all teachers from schools
            var flattendTeachers = schools
                .SelectMany(x => x.Teachers)
                .ToList();

            // #7-2 get all students from schools
            var flattendStudents = schools
                .SelectMany(x => x.Teachers)
                .SelectMany(x => x.Students)
                .ToList();
            // Q. why don't we just use students? we already have List<Student> that contains all students
            // sometimes you don't have the list of children and the direct access to them
            // also, to filter children by their parents' property, you need to start from parents
            var studentsOfMathTeacher = schools
                .SelectMany(x => x.Teachers)
                .Where(x => x.SubjectInCharge == Subject.Math)
                .SelectMany(x => x.Students)
                .ToList();

            // #8 Unique
            // if you need unique set of values from elements, use Distinct
            // ToHashSet can also produce the collection of unique elements from the source collection
            // but constructing HashSet has many overhead cost, so don't use it without proper reason.
            var numbers = new List<int> { 1, 1, 2, 3, 1, 3, 4, 3, 2, 0, 1, 2, 3, 4, 3 };
            var uniqueNumbers = numbers
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            var numberHashSet = numbers
                .OrderBy(x => x)
                .ToHashSet();
            // because HashSet is a set (has no index), you can only enumerate it
            foreach (var item in numberHashSet)
            {
                var num = item;
            }
            // but you can convert HashSet to List
            var numberList = numberHashSet.ToList();

            // #9 Take(), Skip()
            // use Take() and/or Skip() if you want N elements or 3rd~7th elements or so
            // ElementAt   
            var top3Students = students
                .OrderBy(x => x.Name)
                .Take(3) // don't confuse! this is not index, it is number
                .ToList();
            var top5to7students = students
                .OrderBy(x => x.Name)
                .Skip(4) // skip 1, 2, 3, 4
                .Take(3) // take 5, 6, 7
                .ToList();

            // #10 nested query
            // you can use LINQ query in lambda experssion of another LINQ query
            // the scope of variable is important in this situation
            // try to give semantic and distinguishable name other than x
            // what you want is like: 김서울 / 2회 / 욜로고 / 1학년 / 담임교사 김국어 
            var volunteerList = new List<string> { "김서울", "이박사", "신바람", "홍길동", "김서울", "신바람", "홍길동" };
            var volunteerDict = volunteerList
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());
            var volunteerResult = schools
                .Select(school => school.Teachers
                    .Select(teacher => teacher.Students
                        .Select(student => new { 
                            name = student.Name, 
                            count = volunteerDict.TryGetValue(student.Name, out int volunteerCount) ? volunteerCount : 0, 
                            school = school.Name, 
                            grade = student.Grade, 
                            teacher = teacher.Name 
                        })))
                .ToList();
            // too complex LINQ query isn't fun
            // avoid it, but sometimes you might feel LINQ is better than other solution (foreach loops, ...)

            // #11 To... What()?
            // you might wonder why we always use ToList() (or ToDictionary)
            // if you don't use ToList(), the return type is IEnumerable<T>
            // as its name stands, you can enumerate (i.e. foreach) the IEnumerable<T>
            var enumerableStudentNames = students
                .Select(x => x.Name);
            foreach (var item in enumerableStudentNames)
            {
                var name = item;
            }
            // but it is NOT List<T>
            // ex) var firstOne = enumerableStudentNames[0]; is impossible
            // but you can continue query on it like List
            var orderedEnumerableStudentNames = enumerableStudentNames
                .OrderBy(x => x);
            // Q. why we need IEnumerable? isn't it just a half-functioning List?
            // Lazy load
            // Q. What?
            // basically, LINQ query isn't executed immediately
            // i.e. it doesn't really do filtering/sorting task when it meets Where()/OrderBy()
            // it delays the execution as much as possible
            // so it is lazy, and that is lazy load
            // Q. but when I am debugging, I can see the result from any part of query.
            // when doing so, you see "Results View = Expanding the Results View will enumerate the IEnumerable"
            // it means the IEnumberable isn't yet enumerated even if you're debugging that line.
            // enumerating the IEnumerable = "foreach" the IEnumerable  
            // but when you use ToList(), ToDicionary() or Count() ...
            // since enumeration is inevitable to return the result, query is executed
            // also, IEnumerable is read-only and immutalbe, unlike List
            // practically, use ToList() as a default and forget the IEumerable

            // PRACTICE

            // P1 application of where
            var mode = "1-Korean"; // some external parameter that decide the flow of query
            // possible form of mode: "Korean", "1", "2-Math", ...
            var splitted = mode.Split('-');
            var filterGrade = false;
            var gradeToChoose = 0;
            var filterSubject = false;
            var subjectToChoose = Subject.Korean;
            if (splitted.Count() == 1)
            {
                // TryParse return true when parse is done, the parsed value is written to the "out" paramter
                if (int.TryParse(mode, out gradeToChoose))
                {
                    filterGrade = true;
                }
                else
                {
                    filterSubject = true;
                    subjectToChoose = Enum.Parse<Subject>(mode);
                }
            }
            else
            {
                filterGrade = true;
                filterSubject = true;
                gradeToChoose = int.Parse(splitted[0]);
                subjectToChoose = Enum.Parse<Subject>(splitted[1]);
            }
            var result = teachers
                .Where(x => filterSubject || x.SubjectInCharge == subjectToChoose)
                .SelectMany(x => x.Students)
                .Where(x => filterGrade || x.Grade == gradeToChoose)
                .ToList();

            // P2 order by avg score
            var studentsSortedByAvgScore = students
                .OrderByDescending(x => x.ScoreDict.Average(score => score.Value))
                .ToList();

            // P2-1 by max score
            var studentsSortedByMaxScore = students
                .OrderByDescending(x => x.ScoreDict.Max(score => score.Value))
                .ToList();

            // P3 by the score of their teacher's subject in charge
            var p3 = teachers
                .SelectMany(x => x.Students
                    .OrderByDescending(s => s.ScoreDict[x.SubjectInCharge])
                    .ToList())
                .ToList();

            // P4 get each school's teacher whose students' avg score is the lowest
            var p4 = schools
                .Select(x => x.Teachers
                    .OrderBy(t => t.Students
                        .Select(s => s.ScoreDict
                            .Average(d => d.Value))
                        .Average())
                    .First())
                .ToList();

            // P5 get avg score of each subject and sort
            var p5 = students
                .SelectMany(x => x.ScoreDict)
                .GroupBy(x => x.Key)
                .Select(x => new { name = x.Key.ToString(), avg = x.Average(s => s.Value) })
                .OrderByDescending(x => x.avg)
                .ToList();

            // P6 get each school's 학년수석
            var p6 = schools
                .Select(x => x.Teachers
                    .SelectMany(t => t.Students)
                        .GroupBy(s => s.Grade)
                        .OrderBy(g => g
                            .Select(s => s.ScoreDict.Average(d => d.Value))
                        .First()))
                .ToList();

            // P7 get avg Korean score of students in a specific school (decided by a parameter)
            var p7SchoolName = "욜로고";
            var p7 = schools
                .First(x => x.Name == p7SchoolName)
                .Teachers
                .SelectMany(x => x.Students)
                .Average(x => x.ScoreDict[Subject.Korean]);
        }
    }
}
