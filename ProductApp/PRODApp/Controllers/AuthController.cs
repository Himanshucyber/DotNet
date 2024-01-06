using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRODApp.Models;
using PRODApp.Repositories;
using PRODApp.Services;
using System.Collections.Generic;
namespace PRODApp.Controllers;


public class AuthController:Controller{

[HttpGet]
public IActionResult SignIn(){
    return View();
}

public IActionResult SignIn(String email,String passs){
    return View();
}

public IActionResult Register(User user){

return View();
}



}
