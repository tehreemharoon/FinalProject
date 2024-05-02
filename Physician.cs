namespace FinalProject;

public class Physician
{
    private static int autoIncrement;
    public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {get; set;}
        public string Phonenumber {get; set;}
        public string Degree {get; set;}
        public string Position {get; set;}
        public string Training {get; set;}

        public Physician(){
            autoIncrement++;
            Id = autoIncrement;
        }
    public string Name { get; set; }

    public Physician(string name)
    {
        Name = name;
    }
}
