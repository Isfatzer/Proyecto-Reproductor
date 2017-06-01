using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Reproductor
{
    class Lectura_Canciones
    {
        string[] canciones;
        string[] rutaCanciones;

        public string[] Canciones
        {
            get
            {
                return canciones;
            }

            set
            {
                canciones = value;
            }
        }

        public string[] RutaCanciones
        {
            get
            {
                return rutaCanciones;
            }

            set
            {
                rutaCanciones = value;
            }
        }
    }
}
