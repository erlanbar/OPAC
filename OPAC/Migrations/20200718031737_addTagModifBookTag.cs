using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class addTagModifBookTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "BookTags");

            migrationBuilder.AddColumn<int>(
                name: "TagID",
                table: "BookTags",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagID",
                table: "BookTags");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BookTags",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
