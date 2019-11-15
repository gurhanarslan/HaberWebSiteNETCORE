using Microsoft.EntityFrameworkCore.Migrations;

namespace HaberWebSite.Migrations.ApplicationDb
{
    public partial class CategoryName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "News");
        }
    }
}
