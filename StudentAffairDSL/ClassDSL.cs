using StudentAffairDSL.DSLInterfaces;
using StudentAffairRepo.Interfaces;
using StudentAffairTypes;
using System.Collections.Generic;

namespace StudentAffairDSL
{
    public class ClassDSL : IClassDSL
    {
        private readonly IClassRepo _classRepo;
        public ClassDSL(IClassRepo classRepo)
        {
            _classRepo = classRepo;
        }
        public bool Delete(CLass entity)
        {
            return _classRepo.Delete(entity);
        }

        public ICollection<CLass> GetAll()
        {
            return _classRepo.GetAll();
        }

        public CLass GetById(int ID)
        {
            return _classRepo.GetById(ID);
        }

        public void insert(CLass entity)
        {
            _classRepo.insert(entity);
        }

        public void Update(CLass entity)
        {
            _classRepo.Update(entity);
        }
    }
}
