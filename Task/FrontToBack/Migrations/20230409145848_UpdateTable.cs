using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Access",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Customization",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "LiveChat",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "UserCount",
                table: "Offers",
                newName: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Offers",
                newName: "UserCount");

            migrationBuilder.AddColumn<string>(
                name: "Access",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customization",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiveChat",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
