using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStoreDataStore.Migrations
{
    public partial class Fixingissues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(7794), new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8667), new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8693), new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8696), new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8698), new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8701), new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 886, DateTimeKind.Local).AddTicks(1297), new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5017), new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5059), new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5060) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(1369), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2407), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2577), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2580), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2583), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "MSAlbum",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2585), new DateTime(2020, 5, 31, 18, 42, 10, 465, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 462, DateTimeKind.Local).AddTicks(4230), new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8907), new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "MSArtist",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8948), new DateTime(2020, 5, 31, 18, 42, 10, 463, DateTimeKind.Local).AddTicks(8949) });
        }
    }
}
