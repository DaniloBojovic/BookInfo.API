using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookInfo.API.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Author = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Title" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), "Yuval Noah Harari", "Sapiens: A Brief History of Humankind" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "K. Anders Ericsson", "Peak: Secrets from the New Science of Expertise" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), " Cal Newport", "So Good They Can't Ignore You" },
                    { new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"), "Josh Waitzkin", "The Art of Learning: A Journey in the Pursuit of Excellence" },
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), "Andy Hunt", "Pragmatic Thinking and Learning: Refactor Your Wetware" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
