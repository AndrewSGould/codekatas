using System.ComponentModel.DataAnnotations;

namespace SharpKatas.Models
{
    public class Car
    {
        public long Id { get; set; }

        [Required]
        [Range(1900, 3000)]
        public short Year { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Make { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Model { get; set; }

        [Display(Name = "Body Style")]
        [StringLength(50)]
        public string BodyStyle { get; set; }

        [StringLength(50)]
        public string Class { get; set; }

        [StringLength(2)]
        public string Layout { get; set; }

        [StringLength(50)]
        public string Engine { get; set; }
    }
}
