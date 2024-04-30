namespace FinalProject;

public class PhysicianDepartment
{
    public Physician physician{get; set;}
    public Department department {get; set;}

    public PhysicianDepartment(Physician physician, Department department);
    {
        Physician = physician;
        Department = Department;
    }



}
