using Project.Models;

namespace Project.Services
{
    public class BasketService
    {
        private readonly SurfboardRepo _repo;

        public BasketService(SurfboardRepo repo)
        {
            _repo = repo;
        }

        // Add surfboards to the basket with a specified quantity
        public void AddToBasket(int surfboardId, int quantity)
        {
            var surfboard = _repo.GetSurfBoardById(surfboardId); // Fetch surfboard by ID

            if (surfboard != null)
            {
                if (Basket.RentedBoards == null)
                {
                    Basket.RentedBoards = new List<Surfboard>();
                }

                // Add the surfboard to the basket 'quantity' times
                for (int i = 0; i < quantity; i++)
                {
                    Basket.RentedBoards.Add(surfboard);
                }

                CalculateTotalPrice(); // Update the total price of the basket
            }
        }

        // Calculate the total price of all items in the basket
        private void CalculateTotalPrice()
        {
            Basket.TotalPrice = Basket.RentedBoards?.Sum(s => s.Price) ?? 0;
        }

        // Optionally, a method to get a surfboard by ID (or reuse the repository)
        public Surfboard GetSurfBoardById(int surfboardId)
        {
            return _repo.GetSurfBoardById(surfboardId);
        }
        // Remove from basket (returns true if removed, false if not)
        public bool RemoveFromBasket(int surfboardId)
        {
            var surfboard = Basket.BoardsInBasket?.FirstOrDefault(b => b.SurfboardId == surfboardId);
            if (surfboard != null)
            {
                Basket.BoardsInBasket.Remove(surfboard);
                CalculateTotalPrice();
                return true;
            }
            return false;
        }
    }
}


