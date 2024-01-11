namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
}
