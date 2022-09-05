using Microsoft.EntityFrameworkCore;
using StudentAffairDAL;
using StudentAffairRepo.Interfaces;
using StudentAffairTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairRepo
{
    public class StudentRepo: IStudentRepo
    {
        private readonly ApplicationDBContext _context;

        public StudentRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public bool Delete(int index)
        {
            var entity = GetById(index);
            if (entity == null) return false;
            else
            {
                _context.Students.Remove(entity);
                _context.SaveChanges();
                return true;
            }
        }

        public ICollection<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public ICollection<Student> GetAllWithFilter(Expression<Func<Student, bool>> selector, int skip, int take)
        {
            return _context.Students.Include(s => s.studentSubjects).Where(selector).OrderBy(S => S.Name).Skip(skip).Take(take).ToList();
        }

        public Student GetById(int ID)
        {
            return _context.Students.Include(s=>s.studentSubjects).FirstOrDefault(S => S.ID == ID);
        }

        public ICollection<Subject> GetStudentSubjects(int studentId)
        {
            return _context.StudentSubjects.Include(ss=> ss.Subject).Where(ss => ss.StudentID == studentId).Select(s=> s.Subject).ToList();
        }

        public void insert(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();

        }

        public void Update(Student entity)
        {
            _context.Students.Update(entity);
            _context.SaveChanges();
        }

        public void AddStudentSubject(StudentSubject studentSubject)
        {
            _context.StudentSubjects.Add(studentSubject);
            _context.SaveChanges();
        }

        public void RemoveStudentSubject(StudentSubject studentSubject)
        {
            _context.StudentSubjects.Remove(studentSubject);
            _context.SaveChanges();
        }
    }
}
