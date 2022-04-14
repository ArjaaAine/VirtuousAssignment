using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Virtuous.Web.Migrations
{
    public partial class ChangingDonationObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountDecimal",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "AmountWhole",
                table: "Donation");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Donation",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Donation");

            migrationBuilder.AddColumn<int>(
                name: "AmountDecimal",
                table: "Donation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AmountWhole",
                table: "Donation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
