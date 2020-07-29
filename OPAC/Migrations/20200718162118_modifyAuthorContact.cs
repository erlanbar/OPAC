using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class modifyAuthorContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Author",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherContact",
                table: "Author",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Author",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "OtherContact",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Author");
        }
    }
}
