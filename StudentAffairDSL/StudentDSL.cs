using StudentAffairDSL.DSLInterfaces;
using StudentAffairRepo.Interfaces;
using StudentAffairTypes;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public bool Delete(Student entity)
        {
            return _studentRepo.Delete(entity);
        }

        public ICollection<Student> GetAll()
        {
            return _studentRepo.GetAll();
        }

        public Student GetById(int ID)
        {
            return _studentRepo.GetById(ID);
        }

        public void insert(Student entity)
        {
            _studentRepo.insert(entity);
        }

        public void Update(Student entity)
        {
            _studentRepo.Update(entity);
        }
    }
}
