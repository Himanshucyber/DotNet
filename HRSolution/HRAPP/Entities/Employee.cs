
namespace HRAPP.Entities;

[Serializable]
public class Employee{
  

   

    public int Id{get;set;}
    public string Name{get;set;}

    public Employee(int Id,string Name){
        this.Id=Id;
        this.Name=Name;
    }
    // Employee newEploye= new Employee{Id=3,Name="gdhsgd"};

}
