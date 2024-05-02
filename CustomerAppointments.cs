namespace FinalProject;

public class PatientAppointment
{
    public Patient patient { get; set; }
        public Appointment appointment { get; set; }

        public Physician physician{ get; set; }

        public PatientAppointment(Patient p, Appointment a, Physician ph)
        {
            patient = p;
            appointment = a;
            physician = ph;
        }
}
