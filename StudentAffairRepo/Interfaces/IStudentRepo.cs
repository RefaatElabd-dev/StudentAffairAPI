using StudentAffairTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StudentAffairRepo.Interfaces
{
    public interface IStudentRepo : IRepository<Student, int>
    {
        ICollection<Student> GetAllWithFilter(Expression<Func<Student, bool>> selector, int skip, int take);
        ICollection<Subject> GetStudentSubjects(int studentId);

        void AddStudentSubject(StudentSubject studentSubject);
        void RemoveStudentSubject(StudentSubject studentSubject);
    }
}
