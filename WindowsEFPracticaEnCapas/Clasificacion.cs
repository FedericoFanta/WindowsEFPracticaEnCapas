using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFPracticaEnCapas
{
    public class Clasificacion
    {
        public int ClasificacionId { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public List <Pelicula> Peliculas { get; set; } 
    }
}
