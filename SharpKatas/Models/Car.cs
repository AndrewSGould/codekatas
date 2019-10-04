using System.ComponentModel.DataAnnotations;

namespace SharpKatas.Models
{
    public class Car
    {
        public long Id { get; set; }
        public short Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        [Display(Name = "Body Style")]
        public string BodyStyle { get; set; }
        public string Class { get; set; }
        public string Layout { get; set; }
    }
}
