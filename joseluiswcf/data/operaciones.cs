using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace joseluiswcf.data
{
    public class operaciones
    {
        public Peliculas agregar() {
            Peliculas dato = new Peliculas();
            dato.ID_pelicula = 0;
            dato.Nombre = "interestelar";
            dato.Descripcion = "la humanidad tiene que encontrar...";
            dato.Clasificacion = "accion";
            return dato;
        }
        public Peliculas consultar(Peliculas peli) {
            return peli;
        }
    }
}