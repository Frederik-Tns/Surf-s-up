namespace Project.Models
{
    public class EquipmentRepocs
    {
        private EquipmentRepocs _instance;

        public EquipmentRepocs Instance
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

        private List<Equipment> _equipment;

        public List<Equipment> Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }

    }
}
