using HRAPP.Entities;
using HRAPP.Services;
namespace HRAPP.Controllers;
public class EmployeesController{
    private IEmployeeService _svc;
    public EmployeesController(IEmployeeService svc){
        this._svc=svc;
    }
    //Action Listeners
    //Action Methods
    public List<Employee> GetAll(){
        return this._svc.GetAll();
    }
    public void GetById(int id){
        this._svc.GetById(id);
    }

    public bool Insert(Employee emp){
       return this._svc.Insert(emp);
    }
    public void Update(Employee emp){
          this._svc.Update(emp);
    }

    public bool Delete(int id){
       return _svc.Delete(id);
    }
}