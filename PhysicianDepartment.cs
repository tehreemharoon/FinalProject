namespace FinalProject
{

    public class PhysicianDepartment
    {
        
      public Physician physician{get; set;}
      public Department department {get; set;}

      public PhysicianDepartment(Physician ph, Department d)
      {
          physician = ph;
          department = d;
    }
}