namespace Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public UserAddress Address { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public List<Author>? PreferedAuthors { get; set; }
        public List<Genre>? PreferedGenres { get; set; }
        public List<Book>? PreferedBooks { get; set; }
        public List<Book>? ReservedBooks { get; set; }
        public List<Book>? CurrentlyReadingBooks { get; set; }
        public Role Role { get; set; }
    }
}
