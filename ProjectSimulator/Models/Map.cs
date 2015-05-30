using System.ComponentModel.DataAnnotations;

namespace ProjectSimulator.Models
{
    public class Map
    {
        [Key]
        public string Isbn { get; set; }
        public string Terrain { get; set; }
        public string Type { get; set; }
        public int Scale { get; set; }
        public string State { get; set; }
    }
}
