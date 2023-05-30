using System.ComponentModel.DataAnnotations;

namespace BurgerRestaurant.Models;

public class Burger
{
    public int ID { get; set; }

    [Required]
    public string? Name { get; set; }
    public BurgerSide Side { get; set; }
    public bool IsVegetarian { get; set; }

    [Range(0.01, 99.99)]
    public decimal Price { get; set; }
}

public enum BurgerSide { Fries, Salad, None }