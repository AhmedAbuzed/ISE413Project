using System.ComponentModel.DataAnnotations;

namespace ISE413Project.Models
{
    public class Book
    {
        public int Id { get; set; } // Primary key

        [Required]
        public string Name { get; set; } // Book name

        public int NumberOfPages { get; set; } // Number of pages

        [Required]
        public decimal Price { get; set; } // Price

        public int GenreId { get; set; } // Foreign key
        public Genre Genre { get; set; } // Navigation property
    }
}