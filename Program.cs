namespace FinalProject;

class Program
{
    private static Patients patients;
        private static List<Appointment> appointments;
        private static List<PatientAppointment> patientAppointments;
        private static Patient authenticatedPatient;

        private static Patient patient;
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");
            Initialize(); // Create and initialize all objects ...
            Menu();
        }

        static void Initialize()
        {
            var c1 = new Patient
            {
                FirstName = "Kambiz",
                LastName = "Saffari",
                Username = "kambiz",
                Password = "1234"
            };
            var c2 = new Patient
            {
                FirstName = "Terence",
                LastName = "Ow",
                Username = "terence",
                Password = "2345"
            };
            var a1 = new Appointment();
            var a2 = new Appointment();
            var a3 = new Appointment();

            var ca1 = new PatientAppointment(c1, a1);
            var ca2 = new PatientAppointment(c1, a2);
            var ca3 = new PatientAppointment(c2, a3);

            patients = new Patients();
            patients.patients.Add(c1);
            patients.patients.Add(c2);

            appointments = new List<Appointment>();
            appointments.Add(a1);
            appointments.Add(a2);
            appointments.Add(a3);

            patientAppointments = new List<PatientAppointment>();
            patientAppointments.Add(ca1);
            patientAppointments.Add(ca2);
            patientAppointments.Add(ca3);


        }

        static void Menu()
        {
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- Appointments: 4 --- Clear Screen: c --- Quit: q ---Physician:p---");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        LogoutMenu();
                        break;
                    case "3":
                        SignUpMenu();
                        break;
                    case "4":
                        GetCurrentAppointmentsMenu();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    case "q":
                        done = true;
                        break;
                    case "p":
                        physiciandepartment();
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

            }

        }


        static void LoginMenu()
        {
            if(authenticatedPatient == null)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                authenticatedPatient = patients.Authenticate(username, password);
                if (authenticatedPatient != null)
                {
                    Console.WriteLine($"Welcome {authenticatedPatient.FirstName}");
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }
            }
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedPatient.Username}");
            }
        }

        static void LogoutMenu()
        {
            authenticatedPatient = null;
            Console.WriteLine("Logged out!");
        }

        static void SignUpMenu()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            var newPatient = new Patient
            {
                FirstName = firstName,
                LastName = LastName,
                Username = username,
                Password = password
            };

            patients.patients.Add(newPatient);

            Console.WriteLine("Profile created!");

        }


        static void GetCurrentAppointmentsMenu()
        {
            if(authenticatedPatient == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }


            var appointmentList = patientAppointments.Where(o => o.patient.Username == authenticatedPatient.Username);

            if(appointmentList.Count() == 0)
            {
                Console.WriteLine("0 appointment found.");
            }
            else
            {
                foreach(var appointmnet in appointmentList)
                {
                    Console.WriteLine(appointmnet.appointment.date);
                }
            }
        }
    static void physiciandepartment()
    {
        Physician p1 = new Physician ("Dr. Steiner");
        Physician p2 = new Physician("Dr. Saffari");
        Physician p3 = new Physician ("Dr. Lee");


        Department d1 = new Department ("Dermetology");
        Department d2 = new Department("CVICU");
        Department d3 = new Department ("Ancology");


        d1.AddPhysician(p1);
        d2.AddPhysician(p2);
        d3.AddPhysician(p3);
Console.WriteLine("Physicians in Dermetology Department:");
    foreach (var physician in d1.Physicians)
    {
    Console.WriteLine(physician.Name);
    }


    Console.WriteLine("Physicians in CVICU Department:");
    foreach (var physician in d2.Physicians)
{
Console.WriteLine(physician.Name);
}
    Console.WriteLine("Physicians in Oncology Department:");
    foreach (var physician in d3.Physicians)
    {
    Console.WriteLine(physician.Name);
    }
}
}
