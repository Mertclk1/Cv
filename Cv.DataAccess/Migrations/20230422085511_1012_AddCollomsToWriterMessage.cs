using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cv.DataAccess.Migrations
{
    public partial class _1012_AddCollomsToWriterMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceverName",
                table: "writerMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "writerMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceverName",
                table: "writerMessages");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "writerMessages");
        }
    }
}
