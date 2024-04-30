namespace FinalProject;

public class Physician
{
    private static int autoIncrement;
    public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string address {get; set;}
        public string phonenumber {get; set;}
        public string degree {get; set;}
        public string position {get; set;}

        public Physician(){
            autoIncrement++;
            Id = autoIncrement;
        }
}
