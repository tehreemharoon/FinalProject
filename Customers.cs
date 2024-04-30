namespace FinalProject;

public class Patients
{
    public List<Patient> patients { get; set; }

        public Patients()
        {
            patients = new List<Patient>();
        }

        public Patient Authenticate(string username, string password)
        {
            var c = patients.Where(o => (o.Username == username) && (o.Password == password));

            if(c.Count() > 0)
            {
                return c.First();
            }
            else
            {
                return null;
            }
        }
}
