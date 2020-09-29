using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class bookInlistID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InlistID",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InlistID",
                table: "Books");
        }
    }
}
