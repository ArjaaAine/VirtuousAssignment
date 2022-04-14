using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Virtuous.Web.Migrations
{
    public partial class AddingNewProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCostCovered",
                table: "Donation",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCostCovered",
                table: "Donation");
        }
    }
}
