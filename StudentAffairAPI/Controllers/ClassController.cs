using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAffairDSL.DSLInterfaces;
using StudentAffairTypes;
using System.Collections.Generic;

namespace StudentAffairAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassController : Controller, IClassDSL
    {
        private readonly IClassDSL _classDSL;
        private readonly ILogger<ClassController> _logger;

        public ClassController(IClassDSL classDSL, ILogger<ClassController> logger)
        {
            _classDSL = classDSL;
            _logger = logger;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _classDSL.Delete(id);
        }

        [HttpGet("GetAllClasses")]
        public ICollection<CLass> GetAll()
        {
            return _classDSL.GetAll();
        }

        [HttpGet("GetClassByID")]
        public CLass GetById(int ID)
        {
            return _classDSL.GetById(ID);
        }

        [HttpPost]
        public void insert(CLass entity)
        {
            _classDSL.insert(entity);
        }

        [HttpPatch]
        public void Update(CLass entity)
        {
            _classDSL.Update(entity);
        }
    }
}
