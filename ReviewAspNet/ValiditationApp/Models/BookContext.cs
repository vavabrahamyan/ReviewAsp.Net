using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValiditationApp.Models
{
    public class BookContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
    public class BookDbInitilaizer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            context.Books.Add(new Book { Name = "Book_1", Author = "Author_1", Year = 2011 });
            context.Books.Add(new Book { Name = "Book_2", Author = "Author_2", Year = 2012 });
            context.Books.Add(new Book { Name = "Book_3", Author = "Author_3", Year = 2013 });

            base.Seed(context);
        }
    }
}