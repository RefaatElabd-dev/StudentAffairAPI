using StudentAffairTypes;
using StudentAffairTypes.DTOs;
using System.Collections.Generic;

namespace StudentAffairDSL.DSLInterfaces
{
    public interface IStudentDSL : ICRUDDataService<Student, int>
    {
        ICollection<Student> GetPage(searchDTO search);
        ICollection<Subject> GetStudentSubjects(int studentId);

        void AddStudentSubject(StudentSubject studentSubject);
        void RemoveStudentSubject(StudentSubject studentSubject);
    }
}
