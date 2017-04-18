using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAquarium.Models;

namespace EntityAquarium.DataContext
{
    class AquariumsContext :DbContext
    {
        public AquariumsContext():base()
        {
                
        }

        public DbSet<Aquarium> Aquariums { get; set; }
        public DbSet<AquaticLife> AquaticLife { get; set; }

    }
}
