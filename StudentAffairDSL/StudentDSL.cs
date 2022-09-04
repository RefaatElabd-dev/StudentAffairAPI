using StudentAffairDSL.DSLInterfaces;
using StudentAffairRepo.Interfaces;
using StudentAffairTypes;
using StudentAffairTypes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairDSL
{
    public class StudenttDSL : IStudentDSL
    {
        private readonly IStudentRepo _studentRepo;
        public StudenttDSL(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public void AddStudentSubject(StudentSubject studentSubject)
        {
            _studentRepo.AddStudentSubject(studentSubject);
        }

        public bool Delete(int index)
        {
            return _studentRepo.Delete(index);
        }

        public ICollection<Student> GetAll()
        {
            return _studentRepo.GetAll();
        }

        public Student GetById(int ID)
        {
            return _studentRepo.GetById(ID);
        }

        public ICollection<Student> GetPage(searchDTO search)
        {
            Expression<Func<Student, bool>> selector = S => S.ID > 0;
            return _studentRepo.GetAllWithFilter(selector, search.Skip, search.Take);
        }

        public ICollection<Subject> GetStudentSubjects(int studentId)
        {
            return _studentRepo.GetStudentSubjects(studentId);
        }

        public void insert(Student entity)
        {
            _studentRepo.insert(entity);
        }

        public void RemoveStudentSubject(StudentSubject studentSubject)
        {
            _studentRepo.RemoveStudentSubject(studentSubject);
        }

        public void Update(Student entity)
        {
            _studentRepo.Update(entity);
        }
    }
}
