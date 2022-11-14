using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFPracticaEnCapas
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nombre { get; set; }


        public List<Pelicula> Peliculas { get; set; }
    }
}
