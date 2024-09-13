namespace Project.Models
{
    public static class Basket
    {
        public static List<Surfboard> RentedBoards { get; set; } = new List<Surfboard>();
        public static double TotalPrice { get; set; }

    }
}
