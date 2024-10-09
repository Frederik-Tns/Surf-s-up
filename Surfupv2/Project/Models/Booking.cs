using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int? SurfboardId { get; set; }

        public Surfboard? Surfboard { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Today + TimeSpan.FromDays(1);


        [NotMapped] // Gør den ikke bliver gemt i db 
        public decimal TotalPrice
        {
            get
            {
                if (Surfboard == null)
                    return 0;

                // Beregn antallet af dage mellem start og slutdato
                var days = (EndDate - StartDate).Days;

                // Sørg for at antallet af dage minimum er 1 (så det ikke bliver 0, hvis det er samme dag)
                if (days < 1) days = 1;

                // Returner prisen gange med antal dage
                return days * Surfboard.Price;
            }
        }
    }

}
