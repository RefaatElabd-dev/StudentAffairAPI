using StudentAffairDAL;
using StudentAffairRepo.Interfaces;
using StudentAffairTypes;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Delete(Student entity)
        {
             _context.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public ICollection<Student> GetAll()
        {
            return _context.Students.ToList();
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
