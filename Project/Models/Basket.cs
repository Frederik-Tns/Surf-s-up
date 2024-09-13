namespace Project.Models
{
    public static class Basket
    {
        public static List<Surfboard> BoardsInBasket { get; set; } = new List<Surfboard>();
        public static double TotalPrice { get; set; }

    }
}
