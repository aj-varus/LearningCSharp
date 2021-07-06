using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodly.Migrations
{
    public partial class AddedMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "MembershipTypeId",
                table: "Movie",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    SubscriptionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignUpFee = table.Column<short>(type: "smallint", nullable: false),
                    Discount = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MembershipTypeId",
                table: "Movie",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MembershipType_MembershipTypeId",
                table: "Movie",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MembershipType_MembershipTypeId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "MembershipType");

            migrationBuilder.DropIndex(
                name: "IX_Movie_MembershipTypeId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "Movie");
        }
    }
}
