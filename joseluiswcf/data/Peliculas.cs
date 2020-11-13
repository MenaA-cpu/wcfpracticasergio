using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace joseluiswcf.data
{
    public class Peliculas
    {
        int id;
        string nombre;
        string descripcion;
        string clasificacion;

        public int ID_pelicula {
            get { return id; }
            set { id = value; }
        }
        
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion {
            get { return descripcion;  }
            set { descripcion = value; }
        }
        public string Clasificacion {
            get { return clasificacion; }
            set { clasificacion = value; }
        
        }

    }
}