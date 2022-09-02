using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAffairDSL.DSLInterfaces;
using StudentAffairTypes;
using System.Collections.Generic;

namespace StudentAffairAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller, IStudentDSL
    {
        private readonly IStudentDSL _studentDSL;
        private readonly ILogger<StudentController> _logger;
        public StudentController(IStudentDSL studentDSL, ILogger<StudentController> logger)
        {
            _studentDSL = studentDSL;
            _logger = logger;
        }

        [HttpDelete]
        public bool Delete(Student entity)
        {
            return _studentDSL.Delete(entity);
        }

        [HttpGet("GetAllStudents")]
        public ICollection<Student> GetAll()
        {
            return _studentDSL.GetAll();
        }
        [HttpGet("GetStudentByID")]
        public Student GetById(int ID)
        {
            return _studentDSL.GetById(ID);
        }

        [HttpPost]
        public void insert(Student entity)
        {
            _studentDSL.insert(entity);
        }

        [HttpPatch]
        public void Update(Student entity)
        {
            _studentDSL.Update(entity);
        }
    }
}
