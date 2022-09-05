using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAffairDAL.Migrations
{
    public partial class CreateSchemawithseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CLasses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLasses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CLasses_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => new { x.StudentID, x.SubjectID });
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Address", "BirthDate", "EmailAddress", "Name" },
                values: new object[,]
                {
                    { 1, "Alex", new DateTime(2022, 9, 5, 4, 9, 5, 291, DateTimeKind.Local).AddTicks(9732), "Refaat@gmail.con", "Refaat" },
                    { 12, "Alex", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(1006), "Ahmed@gmail.con", "Ahmed" },
                    { 11, "US", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(1004), "Marzouk@gmail.con", "Marzouk" },
                    { 9, "Cairo", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(998), "Donia@gmail.con", "Donia" },
                    { 8, "Alex", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(995), "Shawky@gmail.con", "Shawky" },
                    { 7, "Alex", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(993), "Shimaa@gmail.con", "Shimaa" },
                    { 10, "Alex", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(1002), "Ayman@gmail.con", "Ayman" },
                    { 5, "Fayoum", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(985), "Ehab@gmail.con", "Ehab" },
                    { 4, "Cairo", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(983), "Mohab@gmail.con", "Mohab" },
                    { 3, "Fayoum", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(979), "Zyad@gmail.con", "Zyad" },
                    { 2, "Cairo", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(960), "Samir@gmail.con", "Samir" },
                    { 6, "Cairo", new DateTime(2022, 9, 5, 4, 9, 5, 293, DateTimeKind.Local).AddTicks(991), "Hebab@gmail.con", "Hebab" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 6, "Propability" },
                    { 1, "Algebra" },
                    { 2, "Computer Science" },
                    { 3, "History" },
                    { 4, "Machine Learning" },
                    { 5, "Statistics" },
                    { 7, "Algorithms" }
                });

            migrationBuilder.InsertData(
                table: "CLasses",
                columns: new[] { "ID", "Name", "SubjectID" },
                values: new object[,]
                {
                    { 1, "CS 1", 1 },
                    { 7, "CS 7", 7 },
                    { 6, "CS 6", 6 },
                    { 2, "CS 2", 2 },
                    { 5, "CS 5", 5 },
                    { 3, "CS 3", 3 },
                    { 4, "CS 4", 4 }
                });

            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "StudentID", "SubjectID" },
                values: new object[,]
                {
                    { 2, 7 },
                    { 11, 6 },
                    { 5, 6 },
                    { 11, 5 },
                    { 8, 5 },
                    { 1, 5 },
                    { 7, 4 },
                    { 4, 4 },
                    { 2, 4 },
                    { 11, 3 },
                    { 9, 3 },
                    { 8, 3 },
                    { 11, 2 },
                    { 6, 2 },
                    { 12, 1 },
                    { 11, 1 },
                    { 10, 1 },
                    { 9, 1 },
                    { 3, 1 },
                    { 2, 1 },
                    { 1, 1 },
                    { 7, 7 },
                    { 9, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLasses_SubjectID",
                table: "CLasses",
                column: "SubjectID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectID",
                table: "StudentSubjects",
                column: "SubjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLasses");

            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
