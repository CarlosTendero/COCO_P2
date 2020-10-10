using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    public class AristaGrafo
    {

        private int u, v, coste;

        public AristaGrafo()
        {
        }


        public AristaGrafo(int u, int v, int coste)
        {
            this.u = u;
            this.v = v;
            this.coste = coste;
        }

        public int get_Origen()
        {
            return this.u;
        }

        public void set_Origen(int u)
        {
            this.u = u;
        }

        public int get_Destino()
        {
            return this.v;
        }

        public void set_Destino(int v)
        {
            this.v = v;
        }

        public int get_Coste()
        {
            return this.coste;
        }

        public void set_Coste(int coste)
        {
            this.coste = coste;
        }

    }
}



