using System.ComponentModel.DataAnnotations;

namespace Surf_s_up.Models
{
    public class Surfboard
    {
        public Surfboard(int surfboardId, string name, double length, double width, double thickness, double volume, string type, double price, string imageURL, Types types, List<Equipment>? equipment)
        {
            SurfboardId = surfboardId;
            Name = name;
            Length = length;
            Width = width;
            Thickness = thickness;
            Volume = volume;
            Type = type;
            Price = price;
            ImageURL = imageURL;
            Types = types;
            Equipment = equipment;
        }
        /* Example of constructor chaining
        public Surfboard(int surfboardId, string name, double length, double width, double thickness, double volume, string type, double price, string imageURL, List<Equipment>? equipment)
     : this(surfboardId, name, length, width, thickness, volume, type, price, imageURL, default, equipment)
        {
            // Assuming 'default' is a valid placeholder for the 'Types' parameter
        }*/

        [Required]
        public int SurfboardId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public double Length { get; set; }

        [Required]
        public double Width { get; set; }

        [Required]
        public double Thickness { get; set; }

        [Required]
        public double Volume { get; set; }

        [Required]
        public string Type { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        [Url]
        public string ImageURL { get; set; }

        [Required]
        Types Types { get; set; }

        public List<Equipment>? Equipment { get; set; } = new List<Equipment>();


    }
}
