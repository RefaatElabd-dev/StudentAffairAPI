using StudentAffairTypes;
using System;
using System.Collections.Generic;

namespace StudentAffairHelper
{
    internal class Mocks
    {
        public static IEnumerable<Subject> GetSubjects()
        {
            return new List<Subject>()
            {
                new Subject() {ID = 1, Name = "Algebra"},
                new Subject() {ID = 2, Name = "Computer Science"},
                new Subject() {ID = 3, Name = "History"},
                new Subject() {ID = 4, Name = "Machine Learning"},
                new Subject() {ID = 5, Name = "Statistics"},
                new Subject() {ID = 6, Name = "Propability"},
                new Subject() {ID = 7, Name = "Algorithms"}
            };
        }
        public static IEnumerable<CLass> GetCLasses()
        {
            return new List<CLass>()
            {
                new CLass() {ID = 1, Name = "CS 1", SubjectID = 1},
                new CLass() {ID = 2, Name = "CS 2", SubjectID = 2},
                new CLass() {ID = 3, Name = "CS 3", SubjectID = 3},
                new CLass() {ID = 4, Name = "CS 4", SubjectID = 4},
                new CLass() {ID = 5, Name = "CS 5", SubjectID = 5},
                new CLass() {ID = 6, Name = "CS 6", SubjectID = 6},
                new CLass() {ID = 7, Name = "CS 7", SubjectID = 7}
            };
        }

        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student() {ID = 1, Name = "Refaat", Address = "Alex", EmailAddress= "Refaat@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 2, Name = "Samir", Address = "Cairo", EmailAddress= "Samir@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 3, Name = "Zyad", Address = "Fayoum", EmailAddress= "Zyad@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 4, Name = "Mohab", Address = "Cairo", EmailAddress= "Mohab@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 5, Name = "Ehab", Address = "Fayoum", EmailAddress= "Ehab@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 6, Name = "Hebab", Address = "Cairo", EmailAddress= "Hebab@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 7, Name = "Shimaa", Address = "Alex", EmailAddress= "Shimaa@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 8, Name = "Shawky", Address = "Alex", EmailAddress= "Shawky@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 9, Name = "Donia", Address = "Cairo", EmailAddress= "Donia@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 10, Name = "Ayman", Address = "Alex", EmailAddress= "Ayman@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 11, Name = "Marzouk", Address = "US", EmailAddress= "Marzouk@gmail.con", BirthDate= DateTime.Now},
                new Student() {ID = 12, Name = "Ahmed", Address = "Alex", EmailAddress= "Ahmed@gmail.con", BirthDate= DateTime.Now}
            };
        }

        public static IEnumerable<StudentSubject> GetStudentSubjects()
        {
            return new List<StudentSubject>()
            {
                new StudentSubject(){ StudentID = 1, SubjectID = 1},
                new StudentSubject(){ StudentID = 1, SubjectID = 5},
                new StudentSubject(){ StudentID = 2, SubjectID = 1},
                new StudentSubject(){ StudentID = 2, SubjectID = 7},
                new StudentSubject(){ StudentID = 2, SubjectID = 4},
                new StudentSubject(){ StudentID = 3, SubjectID = 1},
                new StudentSubject(){ StudentID = 4, SubjectID = 4},
                new StudentSubject(){ StudentID = 5, SubjectID = 6},
                new StudentSubject(){ StudentID = 6, SubjectID = 2},
                new StudentSubject(){ StudentID = 7, SubjectID = 7},
                new StudentSubject(){ StudentID = 7, SubjectID = 4},
                new StudentSubject(){ StudentID = 8, SubjectID = 5},
                new StudentSubject(){ StudentID = 8, SubjectID = 3},
                new StudentSubject(){ StudentID = 9, SubjectID = 3},
                new StudentSubject(){ StudentID = 9, SubjectID = 7},
                new StudentSubject(){ StudentID = 9, SubjectID = 1},
                new StudentSubject(){ StudentID = 10, SubjectID = 1},
                new StudentSubject(){ StudentID = 11, SubjectID = 1},
                new StudentSubject(){ StudentID = 11, SubjectID = 3},
                new StudentSubject(){ StudentID = 11, SubjectID = 5},
                new StudentSubject(){ StudentID = 11, SubjectID = 6},
                new StudentSubject(){ StudentID = 11, SubjectID = 2},
                new StudentSubject(){ StudentID = 12, SubjectID = 1}
            };
        }
    }
}
