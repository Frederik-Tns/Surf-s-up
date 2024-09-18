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

        
        public void AddToBasket(int surfboardId, int quantity, DateTime startDate, DateTime endDate)
        {
            var surfboard = _repo.GetSurfBoardById(surfboardId);
            surfboard.BookingStartDate = startDate;
            surfboard.BookingEndDate = endDate;



            if (surfboard != null)
            {
                if (Basket.BoardsInBasket == null)
                {
                    Basket.BoardsInBasket = new List<Surfboard>();
                }

                
                for (int i = 0; i < quantity; i++)
                {
                    Basket.BoardsInBasket.Add(surfboard);
                }

                CalculateTotalPrice(startDate, endDate);
            }
        }

        
        private void CalculateTotalPrice(DateTime startDate, DateTime endDate)
        {
            DateTime timeToday = DateTime.Today;
            
            int daysBetween = (endDate - startDate).Days > 0 ? (endDate - startDate).Days : 1;


            Basket.TotalPrice = Basket.BoardsInBasket?.Sum(s => s.Price * daysBetween) ?? 0;
        }

        
        public Surfboard GetSurfBoardById(int surfboardId)
        {
            return _repo.GetSurfBoardById(surfboardId);
        }
        
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


