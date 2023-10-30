namespace FoodOrdering.Models;
public class Order
{
    public int id { get; set; }
    public string name { get; set; }
    public int food_id { get; set; }
    public DateTime? date { get; set; }
}

