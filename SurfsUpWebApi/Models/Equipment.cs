using System.ComponentModel.DataAnnotations;

namespace SurfsUpWebApi.Models
{
    public class Equipment
    {

        [Required]
        public int EquipmentId { get; set; }
        [Required]
        public string? Name { get; set; } 
    }
}
