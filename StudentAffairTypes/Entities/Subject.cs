using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairTypes
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<StudentSubject> StudentSubjects { get; set; }
        public virtual CLass Class { get; set; }
    }
}
