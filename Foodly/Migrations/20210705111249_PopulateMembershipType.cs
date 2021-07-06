using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodly.Migrations
{
    public partial class PopulateMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "SubscriptionType", "SignUpFee", "Discount"},
                values: new object[] { 1, "Monthly", 30, 10 });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
