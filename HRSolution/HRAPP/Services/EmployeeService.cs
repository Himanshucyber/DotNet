using HRAPP.Entities;
using HRAPP.Repositories;
namespace HRAPP.Services;

public class EmployeeService:IEmployeeService{
   List<Employee> employees=new List<Employee>();
    RepositoryManager mgr=new RepositoryManager();
     string fileName=@"C:\Users\HP\Desktop\DotNet\Day4\HRSolution\employees.json";


    public List<Employee> GetAll(){
       employees=mgr.DeSerialize(fileName);
       return employees;
    }

    public void GetById(int id){
       Employee getEmp = null;
      foreach(Employee e in employees){
       if(e.Id == id){

         getEmp=e;
       }
     }
     if(getEmp != null){
       Console.WriteLine("ID = "+ getEmp.Id + "Name = "+ getEmp.Name);
     }
     else{
       Console.WriteLine("Employee Not Found !");
     }
    

    }

    public bool Insert(Employee emp){
     List <Employee> empList =mgr.DeSerialize(fileName);

     foreach(Employee e in empList){
       if(e.Id == emp.Id){
         return false;
       }
     }

     empList.Add(emp);
     mgr.Serialize(empList,fileName);
     return true;


    }

     public void Update(Employee emp){}

     public bool Delete(int id){
      Console.WriteLine("In Delete method");
    for(int i=0;i<employees.Count;i++){

      if(employees[i].Id == id){
        employees.Remove(employees[i]);
        mgr.Serialize(employees,fileName);
        Console.WriteLine("Employee removed ! ");
        return true;
      }
    }
    return false;

     }

}