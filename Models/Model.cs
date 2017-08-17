using System.ComponentModel.DataAnnotations;

namespace vega.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public Make Make { get; set; }

        public int MakeId { get; set; }
    }
}