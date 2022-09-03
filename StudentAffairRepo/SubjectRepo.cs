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
    public class SubjectRepo: ISubjectRepo
    {
        private readonly ApplicationDBContext _context;

        public SubjectRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public bool Delete(int index)
        {
            var entity = GetById(index);
            if (entity == null) return false;
            else
            {
                _context.Subjects.Remove(entity);
                _context.SaveChanges();
                return true;
            }
        }

        public ICollection<Subject> GetAll()
        {
            return _context.Subjects.ToList();
        }

        public Subject GetById(int ID)
        {
            return _context.Subjects.FirstOrDefault(S => S.ID == ID);
        }

        public void insert(Subject entity)
        {
            _context.Subjects.Add(entity);
            _context.SaveChanges();

        }

        public void Update(Subject entity)
        {
            _context.Subjects.Update(entity);
            _context.SaveChanges();
        }
    }
}
