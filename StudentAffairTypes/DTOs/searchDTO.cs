using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairTypes.DTOs
{
    public class searchDTO
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public int SubjectId { get; set; }
        public string StudentName { get; set; }
    }
}
