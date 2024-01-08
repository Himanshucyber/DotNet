using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRODApp.Models;
using PRODApp.Repositories;
using PRODApp.Services;
using System.Collections.Generic;
namespace PRODApp.Controllers;


public class AuthController:Controller{

 private readonly IUserService _svc;

 public AuthController(IUserService _svc){
   this._svc=_svc;
 } 

[HttpGet]
public IActionResult SignIn(){
    return View();
}
[HttpPost]
public IActionResult SignIn(String email,String passs){
    return 
    View();
}

[HttpGet]
public IActionResult Register(){
return View();
}

[HttpPost]
public IActionResult Register(String email,String fname,String lname,String psw){

    User newUser=new User{Email=email,FirstName=fname,LastName=lname,Password=psw};

    // _svc.Insert(newUser);
     Console.WriteLine(_svc.Insert(newUser));
       

return View();
}



}
