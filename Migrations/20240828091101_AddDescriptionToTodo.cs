using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Testing.Migrations
{
    public partial class AddDescriptionToTodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desription",
                table: "Todos",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Todos",
                newName: "Desription");
        }
    }
}
