using PRODApp.Models;

namespace PRODApp.Repositories;

public interface IUserService{


    public bool Register(User user);

    public bool login(String email, string password);


}