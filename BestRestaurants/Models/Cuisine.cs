using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.JoinEntities = new HashSet<RestaurantCuisine>();
    }

    public int CuisineId { get; set; }
    public string CuisineName { get; set; }
    public virtual ICollection<RestaurantCuisine> JoinEntities { get; set; }
  }
}