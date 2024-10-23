using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Cart? Cart { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Today + TimeSpan.FromDays(1);
    }

}

