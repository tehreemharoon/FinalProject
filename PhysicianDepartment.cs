namespace FinalProject
{
    public class PhysicianDepartment
    {
        public Physician Physician { get; set; }
        public Department Department { get; set; }

        public PhysicianDepartment(Physician physician, Department department)
        {
            Physician = physician;
            Department = department;
        }
    }
}