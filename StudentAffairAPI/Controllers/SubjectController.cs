using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAffairDSL.DSLInterfaces;
using StudentAffairTypes;
using System.Collections.Generic;

namespace StudentAffairAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : Controller, ISubjectDSL
    {
        private readonly ISubjectDSL _subjectDSL;
        private readonly ILogger<SubjectController> _logger;
        public SubjectController(ISubjectDSL subjectDSL, ILogger<SubjectController> logger)
        {
            _subjectDSL = subjectDSL;
            _logger = logger;
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            return _subjectDSL.Delete(id);
        }

        [HttpGet("GetAllSubjects")]
        public ICollection<Subject> GetAll()
        {
            return _subjectDSL.GetAll();
        }
        [HttpGet("GetSubjectByID")]
        public Subject GetById(int ID)
        {
            return _subjectDSL.GetById(ID);
        }

        [HttpPost]
        public void insert(Subject entity)
        {
            _subjectDSL.insert(entity);
        }

        [HttpPatch]
        public void Update(Subject entity)
        {
            _subjectDSL.Update(entity);
        }
    }
}
