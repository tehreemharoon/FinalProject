using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace FinalProject;

class Program
{
    private static Patients patients;
        private static List<Appointment> appointments;
        private static List<PatientAppointment> patientAppointments;
        private static Patient authenticatedPatient;
        private static Physician authenticatedPhysician;
        private static Physicians physicians;

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
                Password = "1234",
                PatientPhone = "1231231234",
                gender = "male",
                PatientAddress = "4321 MyHouse",
                PatientEmail = "KSaffari@email.com",
                PatientAge = 37,
            };
            var c2 = new Patient
            {
                FirstName = "Trina",
                LastName = "Ow",
                Username = "Trina",
                Password = "2345",
                PatientPhone = "3213214321",
                gender = "female",
                PatientAddress = "5678 House",
                PatientEmail = "Tbae@email.com",
                PatientAge = 23,
            };
            
            var p1 = new Physician{
                FirstName = "Fisher",
                LastName = "Man",
                Username = "fishman",
                Password = "fish",
                Address = "1234 Home",
                Phonenumber = "1234567890",
                Degree = "Doctorate",
                Position = "Doctor",
            };

            var a1 = new Appointment();
            var a2 = new Appointment();
            var a3 = new Appointment();

            var ca1 = new PatientAppointment(c1, a1, p1);
            var ca2 = new PatientAppointment(c1, a2, p1);
            var ca3 = new PatientAppointment(c2, a3, p1);

            physicians = new Physicians();
            physicians.physicians.Add(p1);

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
                Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- Appointments: 4 --- Clear Screen: 5 --- Make Appointment: 6 --- Print Out Physician: c --- Quit: q ---");
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
                    case "5":
                        AddAppointment();
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
        {   System.Console.WriteLine("Are you a patient or physician?");
            string user = Console.ReadLine();
            if(user == "patient"){
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
            if(user == "physician"){
                if(authenticatedPhysician == null)
                {
                    Console.Write("Enter your username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();
                    authenticatedPhysician = physicians.Authenticate(username, password);
                    if (authenticatedPhysician != null)
                    {
                        Console.WriteLine($"Welcome {authenticatedPhysician.FirstName}");
                    }
                    else
                    {
                        Console.WriteLine("invalid username or password");
                    }
                }
                else
                {
                    Console.WriteLine($"You are already logged in as {authenticatedPhysician.Username}");
                }
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
        Physician ph1 = new Physician ("Dr. Steiner");
        Physician p2 = new Physician("Dr. Saffari");
        Physician p3 = new Physician ("Dr. Lee");


        Department d1 = new Department ("Dermetology");
        Department d2 = new Department("CVICU");
        Department d3 = new Department ("Ancology");


        d1.AddPhysician(ph1);
        d2.AddPhysician(p2);
        d3.AddPhysician(p3);
        d1.AddPhysician(p1);
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
=======

        static void AddAppointment(){
            if(authenticatedPatient == null){
                Console.WriteLine("You must be logged in to make an appointment");
                return;
            }
            if(authenticatedPhysician != null){
                Console.WriteLine("Physicians can not make appointments.");
                return;
            }
            System.Console.WriteLine("Who would you like to make an appointment with!");
            if(physicians.physicians.Count() == 0){
                System.Console.WriteLine("There are currently no physicians available.");
            }
            else
            {
                System.Console.WriteLine("Available physicians:");
                foreach(var physician in physicians.physicians){
                    System.Console.WriteLine($"Dr. {physician.LastName}");
                }
                System.Console.WriteLine("Enter the last name of the physician you want to make an appointment with.");
                string chosenphysician = Console.ReadLine();
                var cp = physicians.physicians.FirstOrDefault(o => o.LastName == chosenphysician);
                if(chosenphysician != null){
                    var na1 = new Appointment();
                    appointments.Add(na1);
                    var newPatienAppointment = new PatientAppointment(authenticatedPatient, na1, cp);
                    patientAppointments.Add(newPatienAppointment);
                    System.Console.WriteLine($"Appointment with Dr. {chosenphysician} has been made.");
                } else {
                    System.Console.WriteLine($"Physician with the last name {chosenphysician} not found");
                }
            }
        }
}
