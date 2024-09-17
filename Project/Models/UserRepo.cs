namespace Project.Models
{
    public class UserRepo
    {
        private UserRepo _instance;

        public UserRepo Instance
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


        private List<User> _user;

        public List<User> User
        {
            get { return _user; }
            set { _user = value; }
        }

    }
}

