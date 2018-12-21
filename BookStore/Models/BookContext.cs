using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
                   : base("name=ConnectionString")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
     
    }
}