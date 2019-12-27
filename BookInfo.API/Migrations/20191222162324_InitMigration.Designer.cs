﻿// <auto-generated />
using System;
using Books.Api.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookInfo.API.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20191222162324_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Books.Api.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .HasMaxLength(150);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            Author = "Yuval Noah Harari",
                            Title = "Sapiens: A Brief History of Humankind"
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Author = "K. Anders Ericsson",
                            Title = "Peak: Secrets from the New Science of Expertise"
                        },
                        new
                        {
                            Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Author = " Cal Newport",
                            Title = "So Good They Can't Ignore You"
                        },
                        new
                        {
                            Id = new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                            Author = "Josh Waitzkin",
                            Title = "The Art of Learning: A Journey in the Pursuit of Excellence"
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            Author = "Andy Hunt",
                            Title = "Pragmatic Thinking and Learning: Refactor Your Wetware"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
