namespace Project.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public string ImageURL { get; set; }


    }
}
