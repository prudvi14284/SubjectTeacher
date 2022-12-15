using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SubjectTeacher.Migrations
{
    public partial class addMigrationToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SunbjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectCredits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherAge = table.Column<int>(type: "int", nullable: false),
                    TeacherSubjectsSubjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teacher_Subject_TeacherSubjectsSubjectId",
                        column: x => x.TeacherSubjectsSubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_TeacherSubjectsSubjectId",
                table: "Teacher",
                column: "TeacherSubjectsSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
