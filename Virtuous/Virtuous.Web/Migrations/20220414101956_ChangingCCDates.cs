using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Virtuous.Web.Migrations
{
    public partial class ChangingCCDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiryMonth",
                table: "CreditCard");

            migrationBuilder.RenameColumn(
                name: "ExpiryYear",
                table: "CreditCard",
                newName: "ExpirationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "CreditCard",
                newName: "ExpiryYear");

            migrationBuilder.AddColumn<string>(
                name: "ExpiryMonth",
                table: "CreditCard",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
