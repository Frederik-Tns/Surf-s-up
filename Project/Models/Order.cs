namespace Project.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Date { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Surfboard Surfboard { get; set; }
        public int SurfboardId { get; set; }

    }
}
