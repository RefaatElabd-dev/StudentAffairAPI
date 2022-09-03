using StudentAffairTypes;
using StudentAffairTypes.DTOs;
using System.Collections.Generic;

namespace StudentAffairDSL.DSLInterfaces
{
    public interface IStudentDSL : ICRUDDataService<Student, int>
    {
        ICollection<Student> GetPage(searchDTO search);
    }
}
