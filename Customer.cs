namespace FinalProject;

public class Customer
{
    private static int autoIncreament;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer()
        {
            autoIncreament++;
            Id = autoIncreament;
        }
}
