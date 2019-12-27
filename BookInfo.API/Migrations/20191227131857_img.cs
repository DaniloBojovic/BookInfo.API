using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookInfo.API.Migrations
{
    public partial class img : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "Img",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                column: "Img",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                column: "Img",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                column: "Img",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "Img",
                value: "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Books");
        }
    }
}
