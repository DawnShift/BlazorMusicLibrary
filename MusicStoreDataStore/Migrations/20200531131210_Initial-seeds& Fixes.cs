using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStoreDataStore.Migrations
{
    public partial class InitialseedsFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MSArtist",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "MSArtist",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "MSArtist",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MSArtist",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MSArtist",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MSArtist",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlbumArt",
                table: "MSAlbum",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "MSAlbum",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MSAlbum",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "MSAlbum",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MSAlbum",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MSAlbum",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MSAlbum",
                nullable: true);

            migrationBuilder.InsertData(
                table: "MSAlbum",
                columns: new[] { "Id", "AlbumArt", "ArtistId", "CreatedDate", "Date", "ModifiedDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "images/albumArt.jpg", 1, new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(1369), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(1758), null, "Castle Of Glass", null },
                    { 2, "images/albumArt.jpg", 1, new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2407), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2559), null, "Evolution", null },
                    { 3, "images/albumArt.jpg", 2, new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2577), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2579), null, "Thunder", null },
                    { 4, "images/albumArt.jpg", 2, new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2580), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2582), null, "Deamons", null },
                    { 5, "images/albumArt.jpg", 3, new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2583), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2584), null, "The A-Team", null },
                    { 6, "images/albumArt.jpg", 3, new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2585), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2587), null, "Divide", null }
                });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "LastName", "Name" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 462, DateTimeKind.Local).AddTicks(4230), new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8425), "Park", "Linkin" });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "LastName", "Name" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8907), new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8937), "Dragons", "Imagine" });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "LastName", "Name" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8948), new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8949), "Sheren", "Ed" });

            migrationBuilder.CreateIndex(
                name: "IX_MSAlbum_ArtistId",
                table: "MSAlbum",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_MSAlbum_MSArtist_ArtistId",
                table: "MSAlbum",
                column: "ArtistId",
                principalTable: "MSArtist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSAlbum_MSArtist_ArtistId",
                table: "MSAlbum");

            migrationBuilder.DropIndex(
                name: "IX_MSAlbum_ArtistId",
                table: "MSAlbum");

            migrationBuilder.DeleteData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MSArtist");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "MSArtist");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "MSArtist");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MSArtist");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MSArtist");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MSArtist");

            migrationBuilder.DropColumn(
                name: "AlbumArt",
                table: "MSAlbum");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "MSAlbum");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MSAlbum");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "MSAlbum");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MSAlbum");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MSAlbum");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MSAlbum");
        }
    }
}
