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
        public void AddToBasket(int surfboardId, int quantity, DateTime startDate, DateTime endDate)
        {
            var surfboard = _repo.GetSurfBoardById(surfboardId); // Fetch surfboard by ID
            surfboard.BookingStartDate = startDate;
            surfboard.BookingEndDate = endDate;



            if (surfboard != null)
            {
                if (Basket.BoardsInBasket == null)
                {
                    Basket.BoardsInBasket = new List<Surfboard>();
                }

                // Add the surfboard to the basket 'quantity' times
                for (int i = 0; i < quantity; i++)
                {
                    Basket.BoardsInBasket.Add(surfboard);
                }

                CalculateTotalPrice(startDate, endDate); // Update the total price of the basket
            }
        }

        // Calculate the total price of all items in the basket
        private void CalculateTotalPrice(DateTime startDate, DateTime endDate)
        {
            DateTime timeToday = DateTime.Today;
            
            int daysBetween = (endDate - startDate).Days > 0 ? (endDate - startDate).Days : (endDate - startDate).Days + 1;

            if (daysBetween <= 0)
            {
                daysBetween = 1;
            }

            if (startDate.DayOfYear < timeToday.DayOfYear)
            {
                daysBetween = 0;
            }


            Basket.TotalPrice = Basket.BoardsInBasket?.Sum(s => s.Price * daysBetween) ?? 0;
        }

        // Optionally, a method to get a surfboard by ID (or reuse the repository)
        public Surfboard GetSurfBoardById(int surfboardId)
        {
            return _repo.GetSurfBoardById(surfboardId);
        }
        // Remove from basket (returns true if removed, false if not)
        public bool RemoveFromBasket(int surfboardId, DateTime startDate, DateTime endDate)
        {
            var surfboard = Basket.BoardsInBasket?.FirstOrDefault(b => b.SurfboardId == surfboardId);
            if (surfboard != null)
            {
                Basket.BoardsInBasket.Remove(surfboard);
                CalculateTotalPrice(startDate, endDate);
                return true;
            }
            return false;
        }
    }
}


