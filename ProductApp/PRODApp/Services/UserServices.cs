using PRODApp.Services;
using PRODApp.Models;
using PRODApp.Services;
using PRODApp.Repositories;

public class UserServices:IUserService{

List<User> usersData= new List<User>();

UserRepositoryManager usermgr = new UserRepositoryManager();

String userFile =@"C:\Users\HP\Desktop\Projects\DotNet\ProductApp\usersList.json";

public List<User> GetAll(){
    //get users list from json file
    usersData=usermgr.DeSerialize(userFile);
    //return users List
    return usersData;
}

public bool Insert(User user){

  usersData=usermgr.DeSerialize(userFile);

  usersData.Add(user);
//   usermgr.Serialize(usersData,userFile);
 bool result=usermgr.Serialize(usersData,userFile);

//   return true;
return result;

}

public bool Update(){
return true;
}

public bool Delete(){
return true;
}

}