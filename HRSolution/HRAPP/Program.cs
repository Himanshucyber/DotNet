using HRAPP.Entities;
using HRAPP.Services;
using HRAPP.Controllers;
using HRAPP.Views;

IEmployeeService svc=new EmployeeService();
EmployeesController controller=new EmployeesController(svc);
List<Employee> model=controller.GetAll();
ListView view=new ListView(model);
Employee newEmployee= new Employee(43,"Himanshu");
Console.WriteLine(controller.Insert(newEmployee));
Console.WriteLine(controller.Insert(new Employee(44,"Rahul")));

Console.WriteLine(controller.Delete(17));
controller.GetById(43);

view.Render();
Console.WriteLine("Welcome to MVC in C#");
