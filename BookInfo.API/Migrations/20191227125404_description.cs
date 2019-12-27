using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookInfo.API.Migrations
{
    public partial class description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "Description",
                value: "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                column: "Description",
                value: "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                column: "Description",
                value: "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                column: "Description",
                value: "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "Description",
                value: "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");
        }
    }
}
