using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentAffairHelper;
using StudentAffairTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairDAL
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public ApplicationDBContext() : base()
        {

        }
        public IConfiguration Configuration { get; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.mapTables();
            modelBuilder.seed();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<CLass> CLasses { get; set; }
    }
}
