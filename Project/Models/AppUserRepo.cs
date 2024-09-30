namespace Project.Models
{
    public class AppUserRepo
    {
        private readonly ApplicationDbContext _context;

        public AppUserRepo(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        private List<AppUser> _appUser;

        public List<AppUser> AppUser
        {
            get { return _appUser; }
            set { _appUser = value; }
        }


        public string GetUserName(string email)
        {
            var a = _context.Users.FirstOrDefault(u => u.Email == email); 

            if (a == null)
            {
                return string.Empty;
            }

            return a.Name;
        }

        public AppUser GetUser(string Name)
        {
            AppUser a = _context.Users.FirstOrDefault(u => u.Name == Name); 

            if (a == null)
            {
                return null;
            }

            return a;
        }
    }
}

