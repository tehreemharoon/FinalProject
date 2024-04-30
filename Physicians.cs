namespace FinalProject;

public class Physicians
{
    public List<Physician> physicians { get; set; }

        public Physicians()
        {
            physicians = new List<Physician>();
        }

        public Physician Authenticate(string username, string password)
        {
            var p = physicians.Where(o => (o.Username == username) && (o.Password == password));

            if(p.Count() > 0)
            {
                return p.First();
            }
            else
            {
                return null;
            }
}
}
