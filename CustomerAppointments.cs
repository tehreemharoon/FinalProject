namespace FinalProject;

public class CustomerAppointment
{
    public Customer customer { get; set; }
        public Appointment appointment { get; set; }

        public CustomerAppointment(Customer c, Appointment a)
        {
            customer = c;
            appointment = a;
        }
}
