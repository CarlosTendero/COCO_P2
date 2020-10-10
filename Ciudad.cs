using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Ciudad
    {
        /*antes eran privadas*/
        public int vertice;
        public String nombre;

        public Ciudad()
        {


        }

        public Ciudad(int vertice, String nombre)
        {
            this.vertice = vertice;
            this.nombre = nombre;
        }

        public string MostrarCuidadPorVertice(Ciudad[] ciudades, int vertice)
        {
            string aux = " ";
            for (int i = 0; i < ciudades.GetLength(0); i++)
                if (ciudades[i].vertice == vertice)
                    aux = ciudades[i].nombre;

            return aux;
        }

    }
}
