﻿namespace Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public List<string> PreferedAuthtors { get; set; }
        public List<string> PreferedGenres { get; set; }
        public List<string> PreferedBooks { get; set; }
        public Role Role { get; set; }
    }
}
