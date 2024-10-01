using System.ComponentModel.DataAnnotations;

namespace SurfsUpWebApi.Models
{
    public class Surfboard
    {
        [Required, Key]
        public int SurfboardId { get; set; }

        [Required]
        public string? Name { get; set; } 

        [Required]
        public double Length { get; set; }

        [Required]
        public double Width { get; set; }

        [Required]
        public double Thickness { get; set; }

        [Required]
        public double Volume { get; set; }

        [Required]
        public double Price { get; set; }

        [Url]
        public string? ImageURL { get; set; } 

        [Required]
        Types Types { get; set; }

        public List<Equipment>? Equipment { get; set; } = new List<Equipment>();
    }
}
