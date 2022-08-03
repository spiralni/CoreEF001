namespace CoreEF001.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; } = default!;
        public string WebUrl { get; set; } = default!;
    }
}
