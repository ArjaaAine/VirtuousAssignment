using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Virtuous.Web.Migrations
{
    public partial class FixingErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donation_CreditCard_CardInfoId",
                table: "Donation");

            migrationBuilder.RenameColumn(
                name: "CardInfoId",
                table: "Donation",
                newName: "CreditCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Donation_CardInfoId",
                table: "Donation",
                newName: "IX_Donation_CreditCardId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CreditCard",
                newName: "CreditCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_CreditCard_CreditCardId",
                table: "Donation",
                column: "CreditCardId",
                principalTable: "CreditCard",
                principalColumn: "CreditCardId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donation_CreditCard_CreditCardId",
                table: "Donation");

            migrationBuilder.RenameColumn(
                name: "CreditCardId",
                table: "Donation",
                newName: "CardInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Donation_CreditCardId",
                table: "Donation",
                newName: "IX_Donation_CardInfoId");

            migrationBuilder.RenameColumn(
                name: "CreditCardId",
                table: "CreditCard",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_CreditCard_CardInfoId",
                table: "Donation",
                column: "CardInfoId",
                principalTable: "CreditCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
