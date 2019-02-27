using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAPP.Migrations
{
    public partial class Student_Table_Email_Add_New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
