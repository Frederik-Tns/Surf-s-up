namespace Project.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public AppUser? User { get; set; }
        public List<Surfboard>? Surfboards { get; set; }

    }
}
