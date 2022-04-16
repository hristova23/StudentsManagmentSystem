using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManagmentSystem.Data.Migrations
{
    public partial class ChangeYearType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Students",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Students",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);
        }
    }
}
