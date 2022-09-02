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
    public class ClassRepo : IClassRepo
    {
        private readonly ApplicationDBContext _context;

        public ClassRepo(ApplicationDBContext context)
        {
            _context = context;
        }
        public bool Delete(CLass entity)
        {
            _context.CLasses.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public ICollection<CLass> GetAll()
        {
            return _context.CLasses.ToList();
        }

        public CLass GetById(int ID)
        {
            return _context.CLasses.FirstOrDefault(c => c.ID == ID);
        }

        public void insert(CLass entity)
        {
            _context.CLasses.Add(entity);
            _context.SaveChanges();
        }

        public void Update(CLass entity)
        {
            _context.CLasses.Update(entity);
            _context.SaveChanges();
        }
    }
}
