namespace Project.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public User? User { get; set; }
        public int? UserId { get; set; }
        public List<Surfboard>? Surfboards { get; set; } = new List<Surfboard>();
        public int? SurfboardId { get; set; }

    }
}
