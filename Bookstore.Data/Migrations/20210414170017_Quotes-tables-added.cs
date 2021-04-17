using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Data.Migrations
{
    public partial class Quotestablesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tags = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "050a0df6-0737-4902-b9df-75c0ecfd2d98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "51ab7fac-9d2d-4437-b43d-b4e9a88fa0d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "aecbf9ae-5d7c-475c-8cdb-d482dfab0468");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELLYbTyDZaPt++FNsvP6BM0aeFMK25A1QYvRa9Qf41Ghrr8tPmFUjt2Ly4plQOuXTQ==");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 225, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 19, 0, 15, 228, DateTimeKind.Local).AddTicks(6043));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "060c7e92-3d78-44b0-bbb7-0b36396677b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "53b2b063-559d-44c3-8a5e-50dfd1720aa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "c36f1a11-a679-4499-93a8-c6a4a2b59db9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFduJircUOIvPoCuAS2cez9ZhZsnO4oPGGuVcEGOwmzmU2kXXDCMHvuwL9dWkUmEiw==");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 348, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 14, 9, 30, 350, DateTimeKind.Local).AddTicks(9957));
        }
    }
}
