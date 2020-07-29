﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OPAC.Migrations
{
    public partial class bookPreviewedPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreviewedPages",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreviewedPages",
                table: "Books");
        }
    }
}
