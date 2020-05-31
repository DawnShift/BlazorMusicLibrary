using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStoreDataStore.Migrations
{
    public partial class Initialseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MSArtist",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "MSArtist",
                column: "Id",
                value: 2);

            migrationBuilder.InsertData(
                table: "MSArtist",
                column: "Id",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
