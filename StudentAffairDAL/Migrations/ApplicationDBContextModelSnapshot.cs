﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAffairDAL;

namespace StudentAffairDAL.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("StudentAffairTypes.CLass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID")
                        .IsUnique();

                    b.ToTable("CLasses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "CS 1",
                            SubjectID = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "CS 2",
                            SubjectID = 2
                        },
                        new
                        {
                            ID = 3,
                            Name = "CS 3",
                            SubjectID = 3
                        },
                        new
                        {
                            ID = 4,
                            Name = "CS 4",
                            SubjectID = 4
                        },
                        new
                        {
                            ID = 5,
                            Name = "CS 5",
                            SubjectID = 5
                        },
                        new
                        {
                            ID = 6,
                            Name = "CS 6",
                            SubjectID = 6
                        },
                        new
                        {
                            ID = 7,
                            Name = "CS 7",
                            SubjectID = 7
                        });
                });

            modelBuilder.Entity("StudentAffairTypes.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Alex",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 291, DateTimeKind.Local).AddTicks(9732),
                            EmailAddress = "Refaat@gmail.con",
                            Name = "Refaat"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Cairo",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(960),
                            EmailAddress = "Samir@gmail.con",
                            Name = "Samir"
                        },
                        new
                        {
                            ID = 3,
                            Address = "Fayoum",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(979),
                            EmailAddress = "Zyad@gmail.con",
                            Name = "Zyad"
                        },
                        new
                        {
                            ID = 4,
                            Address = "Cairo",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(983),
                            EmailAddress = "Mohab@gmail.con",
                            Name = "Mohab"
                        },
                        new
                        {
                            ID = 5,
                            Address = "Fayoum",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(985),
                            EmailAddress = "Ehab@gmail.con",
                            Name = "Ehab"
                        },
                        new
                        {
                            ID = 6,
                            Address = "Cairo",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(991),
                            EmailAddress = "Hebab@gmail.con",
                            Name = "Hebab"
                        },
                        new
                        {
                            ID = 7,
                            Address = "Alex",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(993),
                            EmailAddress = "Shimaa@gmail.con",
                            Name = "Shimaa"
                        },
                        new
                        {
                            ID = 8,
                            Address = "Alex",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(995),
                            EmailAddress = "Shawky@gmail.con",
                            Name = "Shawky"
                        },
                        new
                        {
                            ID = 9,
                            Address = "Cairo",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(998),
                            EmailAddress = "Donia@gmail.con",
                            Name = "Donia"
                        },
                        new
                        {
                            ID = 10,
                            Address = "Alex",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(1002),
                            EmailAddress = "Ayman@gmail.con",
                            Name = "Ayman"
                        },
                        new
                        {
                            ID = 11,
                            Address = "US",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(1004),
                            EmailAddress = "Marzouk@gmail.con",
                            Name = "Marzouk"
                        },
                        new
                        {
                            ID = 12,
                            Address = "Alex",
                            BirthDate = new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(1006),
                            EmailAddress = "Ahmed@gmail.con",
                            Name = "Ahmed"
                        });
                });

            modelBuilder.Entity("StudentAffairTypes.StudentSubject", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "SubjectID");

                    b.HasIndex("SubjectID");

                    b.ToTable("StudentSubjects");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            SubjectID = 1
                        },
                        new
                        {
                            StudentID = 1,
                            SubjectID = 5
                        },
                        new
                        {
                            StudentID = 2,
                            SubjectID = 1
                        },
                        new
                        {
                            StudentID = 2,
                            SubjectID = 7
                        },
                        new
                        {
                            StudentID = 2,
                            SubjectID = 4
                        },
                        new
                        {
                            StudentID = 3,
                            SubjectID = 1
                        },
                        new
                        {
                            StudentID = 4,
                            SubjectID = 4
                        },
                        new
                        {
                            StudentID = 5,
                            SubjectID = 6
                        },
                        new
                        {
                            StudentID = 6,
                            SubjectID = 2
                        },
                        new
                        {
                            StudentID = 7,
                            SubjectID = 7
                        },
                        new
                        {
                            StudentID = 7,
                            SubjectID = 4
                        },
                        new
                        {
                            StudentID = 8,
                            SubjectID = 5
                        },
                        new
                        {
                            StudentID = 8,
                            SubjectID = 3
                        },
                        new
                        {
                            StudentID = 9,
                            SubjectID = 3
                        },
                        new
                        {
                            StudentID = 9,
                            SubjectID = 7
                        },
                        new
                        {
                            StudentID = 9,
                            SubjectID = 1
                        },
                        new
                        {
                            StudentID = 10,
                            SubjectID = 1
                        },
                        new
                        {
                            StudentID = 11,
                            SubjectID = 1
                        },
                        new
                        {
                            StudentID = 11,
                            SubjectID = 3
                        },
                        new
                        {
                            StudentID = 11,
                            SubjectID = 5
                        },
                        new
                        {
                            StudentID = 11,
                            SubjectID = 6
                        },
                        new
                        {
                            StudentID = 11,
                            SubjectID = 2
                        },
                        new
                        {
                            StudentID = 12,
                            SubjectID = 1
                        });
                });

            modelBuilder.Entity("StudentAffairTypes.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Algebra"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Computer Science"
                        },
                        new
                        {
                            ID = 3,
                            Name = "History"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Machine Learning"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Statistics"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Propability"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Algorithms"
                        });
                });

            modelBuilder.Entity("StudentAffairTypes.CLass", b =>
                {
                    b.HasOne("StudentAffairTypes.Subject", null)
                        .WithOne("SubjectClass")
                        .HasForeignKey("StudentAffairTypes.CLass", "SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentAffairTypes.StudentSubject", b =>
                {
                    b.HasOne("StudentAffairTypes.Student", "Student")
                        .WithMany("studentSubjects")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentAffairTypes.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("StudentAffairTypes.Student", b =>
                {
                    b.Navigation("studentSubjects");
                });

            modelBuilder.Entity("StudentAffairTypes.Subject", b =>
                {
                    b.Navigation("StudentSubjects");

                    b.Navigation("SubjectClass");
                });
#pragma warning restore 612, 618
        }
    }
}
