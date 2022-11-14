using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsEFPracticaEnCapas
{
    public class PracticaContext:DbContext
    {

        public PracticaContext() : base("keyDbPractica") { }

        //por cada modelo una propiedad DBSET

        public DbSet<Clasificacion> Clasificaciones { get; set; }

        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
