using Microsoft.EntityFrameworkCore.Migrations;

namespace HaberWebSite.Migrations.ApplicationDb
{
    public partial class SliderName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SliderName",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderName",
                table: "News");
        }
    }
}
