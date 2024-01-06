using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRODApp.Models;
using PRODApp.Services;

namespace PRODApp.Controllers;


public class ProductController:Controller{

    private readonly IProductService _svc;

    public ProductController(IProductService _svc){
        this._svc=_svc;
    }

    [HttpGet]
    public IActionResult Index(){
        List<Product> products =_svc.GetAll();
        ViewData["Products"]=products;
        return View();
    }
}