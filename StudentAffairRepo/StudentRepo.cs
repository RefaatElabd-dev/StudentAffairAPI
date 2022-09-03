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
            return _context.Students.Where(selector).Skip(skip).Take(take).OrderBy(S => S.Name).ToList();
        }

        public Student GetById(int ID)
        {
            return _context.Students.FirstOrDefault(S => S.ID == ID);
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
    }
}
