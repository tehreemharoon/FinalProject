namespace FinalProject;

public class Patient
{
    private static int autoIncreament;
        public int PatientID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatientPhone { get; set; }
        public string gender { get; set; }
        public int PatientInsuranceNumber { get; set; }
        public string PatientEmail {get; set;}
        public string PatientAddress { get; set; }
        public int PatientAge { get; set; }


        public Patient()
        {
            autoIncreament++;
            PatientID = autoIncreament;
            
            autoIncreament++;
            PatientInsuranceNumber = autoIncreament;
        }
}
