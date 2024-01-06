using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRODApp.Models;
using PRODApp.Repositories;
using PRODApp.Services;
using System.Collections.Generic;
namespace PRODApp.Controllers;


public class AuthController:Controller{

[HttpGet]
public IActionResult signIn(){
    return View();
}

public IActionResult signIn(String email,String passs){
    return View();
}



}
