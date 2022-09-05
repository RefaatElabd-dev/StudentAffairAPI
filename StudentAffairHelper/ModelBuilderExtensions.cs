using Microsoft.EntityFrameworkCore;
using StudentAffairTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairHelper
{
    public static class ModelBuilderExtensions
    {
        public static void mapTables(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubject>()
                .HasKey(ss => new { ss.StudentID, ss.SubjectID });

            modelBuilder.Entity<StudentSubject>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.studentSubjects)
                .HasForeignKey(s => s.StudentID);

            modelBuilder.Entity<StudentSubject>()
                .HasOne(ss => ss.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(s => s.SubjectID);
        }

        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(Mocks.GetSubjects());
            modelBuilder.Entity<CLass>().HasData(Mocks.GetCLasses());
            modelBuilder.Entity<Student>().HasData(Mocks.GetStudents());
            modelBuilder.Entity<StudentSubject>().HasData(Mocks.GetStudentSubjects());
        }
    }
}
