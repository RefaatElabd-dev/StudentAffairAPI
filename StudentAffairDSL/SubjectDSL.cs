using StudentAffairDSL.DSLInterfaces;
using StudentAffairRepo.Interfaces;
using StudentAffairTypes;
using System.Collections.Generic;

namespace StudentAffairDSL
{
    public class SubjectDSL : ISubjectDSL
    {
        private readonly ISubjectRepo _subjectRepo;
        public SubjectDSL(ISubjectRepo subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }
        public bool Delete(int index)
        {
            return _subjectRepo.Delete(index);
        }

        public ICollection<Subject> GetAll()
        {
            return _subjectRepo.GetAll();
        }

        public Subject GetById(int ID)
        {
            return _subjectRepo.GetById(ID);
        }

        public void insert(Subject entity)
        {
            _subjectRepo.insert(entity);
        }

        public void Update(Subject entity)
        {
            _subjectRepo.Update(entity);
        }
    }
}
