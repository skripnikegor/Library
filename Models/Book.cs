namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int TotalQuantity { get; set; }
        public int ReservedQuantity { get; set; }
        public int InReadingQuantity { get; set; }
        public int FreeQuantity { get; set; }
        public BookStatus Status { get; set; }
    }
}
