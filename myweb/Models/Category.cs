using System.ComponentModel.DataAnnotations;

namespace myweb.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(7)] // #RRGGBB
        public string ColorHex { get; set; } = "#667eea";

        [Required]
        [StringLength(50)]
        public string IconClass { get; set; } = "fas fa-tag"; // FontAwesome class

        // Navigation property
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
