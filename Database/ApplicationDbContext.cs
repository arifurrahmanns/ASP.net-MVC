namespace FoodOrdering.data;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.Models;

public class ApplicationDbContext : DbContext{

public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){

}
 public DbSet<Food> Foods { get; set; }
 public DbSet<Order> Orders { get; set; }
}