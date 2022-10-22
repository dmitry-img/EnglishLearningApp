using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishLearning.Migrations
{
    public partial class UpdatedCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Users",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "CourseShareCode",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseShareCode",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Login");
        }
    }
}
