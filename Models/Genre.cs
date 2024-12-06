namespace ISE413Project.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Non-nullable default value
        public ICollection<Book> Books { get; set; } = new List<Book>(); // Non-nullable default value
    }
}