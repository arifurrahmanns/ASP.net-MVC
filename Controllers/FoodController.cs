using FoodOrdering.data;
using Microsoft.EntityFrameworkCore;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FoodOrdering.Models;

namespace foodOrdering.Controllers;

public class FoodController : Controller{
    private ApplicationDbContext _db;
    
    public FoodController(ApplicationDbContext db){
        _db = db;

    }
    public IActionResult Index(){
        var foods = _db.Foods.OrderByDescending(f => f.id) .ToList();
        return View(foods);
    }

[HttpGet]

 public IActionResult Order(int id){
    
    if(id == 0){
         return View("~/Views/Home/Index.cshtml");
    }else{    
                var food = _db.Foods.FirstOrDefault(f => f.id == id);
        var order = new Order{
            name = food.name,
            food_id =food.id,
            date = DateTime.Now
        };
      _db.Orders.Add(order);
    _db.SaveChanges();
     return View(id);
    }
 
    }
    
}
