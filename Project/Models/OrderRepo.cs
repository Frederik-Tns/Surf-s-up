namespace Project.Models
{
    public class OrderRepo
    {
        private OrderRepo _instance;

        public OrderRepo Instance
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


        private List<Order> _order;

		public List<Order> Order
		{
			get { return _order; }
			set { _order = value; }
		}

	}
}
