﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Seician_Aurel_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }
       
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        public int? AuthorID { get; set; }

        public Author? Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Borrowing Borrowing { get; set; }

        public Publisher? Publisher { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
