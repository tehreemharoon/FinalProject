namespace FinalProject;

public class PatientAppointment
{
    public Patient patient { get; set; }
        public Appointment appointment { get; set; }

        public PatientAppointment(Patient p, Appointment a)
        {
            patient = p;
            appointment = a;
        }
}
