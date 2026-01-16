using System.ComponentModel.DataAnnotations;

namespace Villa_API.Models
{
    public class Villa
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        public string? Details { get; set; }
        public int Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
