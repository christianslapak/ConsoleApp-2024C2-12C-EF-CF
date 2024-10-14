using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp_2024C2_12C_EF_CF.Migrations
{
    /// <inheritdoc />
    public partial class emailalumno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Estudiantes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Estudiantes");
        }
    }
}
