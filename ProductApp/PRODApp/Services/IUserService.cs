using PRODApp.Models;

namespace PRODApp.Services;

public interface IUserService{




     public List<User> GetAll();

     public bool Insert(User user);

     public bool Update();

     public bool Delete();




}