namespace PRODApp.Repositories;

using PRODApp.Models;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class UserRepositoryManager{

 public bool Serialize(List<User> users,string fileName){

        // var options = new JsonSerializerOptions{IncludeFields=true};
        // var usersJson=JsonSerializer.Serialize<List<User>>(users,options);
        // File.WriteAllText(fileName,usersJson);


         try
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        var usersJson = JsonSerializer.Serialize<List<User>>(users, options);
        File.WriteAllText(fileName, usersJson);
        return true; // Return true to indicate successful serialization
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error during serialization: {ex.Message}");
        return false; // Return false to indicate failed serialization
    }
       
    }
    public List<User> DeSerialize(string fileName){
        string jsonString = File.ReadAllText(fileName);
        List<User> jsonUsers=JsonSerializer.Deserialize<List<User>>(jsonString);
        return jsonUsers;
    }


}