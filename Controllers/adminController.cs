using FoodOrdering.data;
using Microsoft.EntityFrameworkCore;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FoodOrdering.Models;
namespace foodOrdering.Controllers;

public class AdminController : Controller
{

 private ApplicationDbContext _db;
    
    public AdminController(ApplicationDbContext db){
        _db = db;
    }
   
    public IActionResult index()
    {var foods =_db.Foods.OrderByDescending(f => f.id) .ToList();
        return View(foods);
       
    }
     public IActionResult add(){
                return View();

     }

    //  add
    [HttpPost]
    public IActionResult add(Food food){
         if (ModelState.IsValid)
        {
            _db.Foods.Add(food);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        return View();
    }


[HttpGet]    
    public IActionResult delete (int id){
        if(id == 0){
            return RedirectToAction("index");
        }else{
        var food = _db.Foods.Find(id);

        if (food == null)
        {
                        return RedirectToAction("index");
        }
        _db.Foods.Remove(food);
        _db.SaveChanges();

        return RedirectToAction("index");
        }
    }

    //get ordes
    public IActionResult orders (){
       var order = _db.Orders.OrderByDescending(f => f.id) .ToList();
       return View(order);
    }
    
}
