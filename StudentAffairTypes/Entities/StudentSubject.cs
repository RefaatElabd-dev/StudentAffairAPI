using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentAffairTypes
{
    public class StudentSubject
    {
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        [JsonIgnore]
        public virtual Student Student { get; set; }
        [JsonIgnore]
        public virtual Subject Subject { get; set; }
    }
}
