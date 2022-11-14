using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFPracticaEnCapas
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public string Nombre { get; set; }    
        public int ClasificacionId { get; set; }
        public DateTime FechaEstreno { get; set; }  
        public int CantidadMinutos { get; set; }
        public string GeneroId { get; set; }
        public string Idioma { get; set; }
        public string Sinopsis { get; set; }

        public Genero Genero { get; set; }

        public Clasificacion Clasificacion { get; set; }    
    }
}
