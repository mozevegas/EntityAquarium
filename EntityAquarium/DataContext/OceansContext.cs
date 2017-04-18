using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAquarium.Models;

namespace EntityAquarium.DataContext
{
    class OceansContext: DbContext
    {
        public OceansContext():base()
        {

        }
        public DbSet<Ocean> Oceans { get; set; }

    }
}
