using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodly.Migrations
{
    public partial class AddIsHighRatedToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHighRated",
                table: "Movie",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHighRated",
                table: "Movie");
        }
    }
}
