namespace Project.Models
{
    public class BookingRepo
    {
        private ApplicationDbContext _context;
        private BookingRepo _instance;

        public BookingRepo Instance
        {
            get { return _instance; }

            set
            {
                if (_instance == null)
                {
                    _instance = value;
                }

            }
        }

        private List<Booking> _booking;

		public List<Booking> Booking
		{
			get { return _booking; }
			set { _booking = value; }
		}

        public BookingRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddBooking(Booking booking) 
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

    }
}
