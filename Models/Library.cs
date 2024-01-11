namespace Library.Models
{
    public class Library
    {
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
    }
}
