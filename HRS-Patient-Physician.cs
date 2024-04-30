namespace FinalProject;

public class HRS_Patient_Physician
{
public Patient patient { get; set; }
public Physician physician { get; set; }
public HealthRecordSystem healthrecordsystem { get; set; }

        public HRS_Patient_Physician(Patient pt, Physician phys, HealthRecordSystem hrs)
        {
            patient = pt;
            physician = phys;
            healthrecordsystem = hrs;
        }
}
