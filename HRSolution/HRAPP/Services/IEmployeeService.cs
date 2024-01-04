using HRAPP.Entities;

namespace HRAPP.Services;

public interface IEmployeeService{
    public List<Employee> GetAll();
    public void GetById(int id);
    public bool Insert(Employee emp);
     public void Update(Employee emp);
     public bool Delete(int id);
}