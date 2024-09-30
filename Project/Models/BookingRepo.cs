using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class BookingRepo
    {
        private readonly ApplicationDbContext _context;
        private List<Booking> _bookings;

        
        public BookingRepo(ApplicationDbContext context)
        {
            _context = context;
            LoadBookings(); 
        }

        public List<Booking> Bookings => _bookings;

        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            _bookings.Add(booking);
        }

        private void LoadBookings()
        {
            _bookings = _context.Bookings
                .Include(b => b.User)
                .Include(b => b.Surfboards)
                .ToList();
        }

    }
}
