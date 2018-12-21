using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}