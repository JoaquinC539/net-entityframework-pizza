

namespace ContosoPizza.Models;

public class PizzaDto
{
    public string? Name { get; set; }

    public int? SauceId { get; set; }

    public ICollection<int>? ToppingsIds { get; set; }
}