﻿using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace FinalProject;

public class Department
{
    public int DepartmentID {get; set;}
    public string Name{get; set;}
    public string Description {get;set;}

    public Department (int departmentID, string name,string description)
    {
        DepartmentID = ++ departmentID;


        
    }

   



}