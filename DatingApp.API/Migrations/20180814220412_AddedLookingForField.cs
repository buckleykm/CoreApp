using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.AI.Migrations
{
    public partial class AddedLookingForField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "Users");
        }
    }
}
