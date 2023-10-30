using FoodOrdering.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FoodOrdering.Models;

namespace foodOrdering.Controllers;

public class FoodController : Controller
{
    private ApplicationDbContext _db;

    public FoodController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var foods = _db.Foods.OrderByDescending(f => f.id).ToList();
        return View(foods);
    }

    [HttpGet]
    public IActionResult Order(int food_id)
    {
        if (food_id == 0)
        {
            return View("~/Views/Home/Index.cshtml");
        }
        else
        {
            return View();
        }
    }

    [HttpPost]
    public IActionResult Order(int food_id, Order order)
    {
        if (food_id == 0)
        {
            return View("~/Views/Home/Index.cshtml");
        }
        else
        {
            var food = _db.Foods.FirstOrDefault(f => f.id == food_id);
            if (food == null)
            {
                return View();
            }
            if (ModelState.IsValid)
            {

                order.date = DateTime.Now;
                _db.Orders.Add(order);

                _db.SaveChanges();
                return View("Complete");
            }

            return View();
        }
    }
}
