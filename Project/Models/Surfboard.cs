namespace Project.Models
{
    public class Surfboard
    {
        public string Name { get; set; } = string.Empty;
        public double Length { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; } = string.Empty;
        public double Price { get; set; }
        public List<Equipment> Equipment { get; set;} = new List<Equipment>();

      
    }
}
