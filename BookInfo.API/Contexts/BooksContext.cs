using Books.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Api.Contexts
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                    Title = "Sapiens: A Brief History of Humankind",
                    Author = "Yuval Noah Harari",
                    Description = "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.",
                    Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg"
                },
                new Book
                {
                    Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                    Title = "Peak: Secrets from the New Science of Expertise",
                    Author = "K. Anders Ericsson",
                    Description = "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research",
                    Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg"
                },
                new Book
                {
                    Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                    Title = "So Good They Can't Ignore You",
                    Author = " Cal Newport",
                    Description = "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.",
                    Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg"

                },
                new Book
                {
                    Id = Guid.Parse("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                    Title = "The Art of Learning: A Journey in the Pursuit of Excellence",
                    Author = "Josh Waitzkin",
                    Description = "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.",
                    Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg"
                },
                new Book
                {
                    Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                    Title = "Pragmatic Thinking and Learning: Refactor Your Wetware",
                    Author = "Andy Hunt",
                    Description = "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.",
                    Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg"

                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}