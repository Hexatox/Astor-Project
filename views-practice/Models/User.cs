namespace views_practice.Models
{
    public class User
    {

        public int       Id { get; set; }
        public string    FirstName { get; set; }
        public string    LastName { get; set; }
        public string    Email { get; set; }
        public string    Password { get; set; }
        public DateOnly  DateOfCreation  { get; set; }
        public bool      PasswordConfirmed { get; set; }
        public DateOnly  BirthDay { get; set; }
        public bool      isVerified { get; set; }    
        public IEnumerable<Article> Articles { get; set; }

    }
}
