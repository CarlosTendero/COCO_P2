using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Grafo
    {
        public const int INFINITO = 9999;
        private int vertices;
        private int[,] aristas;
        /*Constructor parametrizado*/
        public Grafo(int vertices)
        {
            this.vertices = vertices;
            this.aristas = new int[vertices, vertices];

            for (int i = 0; i < this.vertices; i++)
                for (int j = 0; j < this.vertices; j++)
                    this.aristas[i, j] = INFINITO;
        }

        public Grafo(int [,] costes)
        {
            this.vertices = costes.GetLength(0);
            this.aristas = new int[vertices, vertices];

            for (int i = 0; i < this.vertices; i++)
                for (int j = 0; j < this.vertices; j++)
                    this.aristas[i, j] = (costes[i, j] == -1) ? INFINITO : costes[i, j];
        }

        

        public int get_Vertices()
        {

          return vertices;

        }

        public void set_Vertices(int vertices)
        {
            this.vertices = vertices;
        }

        public int[,] get_Aristas()
        {
            return this.aristas;
        }

        public void Arista(int u, int v, int coste)
        {
            //asigna el coste del vertices(u,v)
            this.aristas[u, v] = coste;
        }

        public int Coste(int u, int v)
        {
            //devuelve el coste del vertice(u,v)
            return this.aristas[u, v];
        }
        public string ToString(string s)
        {
            return s + "{" + string.Join(" ", this.vertices) + "}";

        }

        public void MostrarMatrizAdyacencia()
        {
            for (int i = 0; i < this.vertices; i++)
                for (int j = 0; j < this.vertices; j++)
                    Console.WriteLine("Origen:\t{0}\tDestino:\t{1}\tCoste:\t{2}", i+1, j+1, this.Coste(i, j));
        }
    }
}
