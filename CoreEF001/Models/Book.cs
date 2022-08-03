namespace CoreEF001.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime PublishedOn { get; set; } = default!;
        public int AuthorId { get; set; }
        public Author Author { get; set; } = default!;
    }
}
