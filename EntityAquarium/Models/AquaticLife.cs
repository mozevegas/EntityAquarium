using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAquarium.Models
{
    class AquaticLife
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public bool InQuarantine { get; set; }

        public int? AquariumId { get; set; }
        public Aquarium CityLives { get; set; }

        public virtual ICollection<Aquarium> Aquarium { get; set; }
    }
}
