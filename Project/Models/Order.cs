namespace Project.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User? User { get; set; }
        public int? UserId { get; set; }
        public List<Surfboard>? Surfboards { get; set; }
        public int? SurfboardId { get; set; }

    }
}
