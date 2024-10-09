using System.Collections.Generic;

namespace Project.Models
{
    public class Cart
    {
        public List<Surfboard> Surfboards { get; set; } = new List<Surfboard>();

        public void AddSurfboard(Surfboard surfboard)
        {
            Surfboards.Add(surfboard);
        }

        // You can add other methods for removing, clearing the cart, etc.
    }
}
