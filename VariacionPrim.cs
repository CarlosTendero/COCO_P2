using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class VariacionPrim<T>
    {

        public static AristaGrafo[] ViajanteDeComercio(Grafo G, int vertice)
        {
            Conjunto<int> V = new Conjunto<int>();  /*Conjunto donde se guardan todos los vertices del grafo*/
            Conjunto<int> T = new Conjunto<int>();  /*Conjunto donde se guardan los vertices que hemos ido recorriendo*/
            AristaGrafo[] Arista = new AristaGrafo[G.get_Vertices()];   /*array de aristas */
            int[] grado = new int[G.get_Vertices()];    /*array para poder controlar y  modificar los grados de los vertices que visitamos*/
            int j = 0;

            int u = vertice;


            /*Inicializa el conjunto V con todos los vertices del grafo G*/
            for (int i = 0; i < G.get_Vertices(); i++)
                V.Inserta(i);
            /*Inicializamos los grados*/
            for (int k = 0; k < grado.GetLength(0); k++)
                grado[k] = 0;
            /*Inicializa el conjunto T con el vertice de partida*/
            T.Inserta(vertice);
            /*Guardamos los vertices que aun no hemos visitado*/
            Conjunto<int> W = V.Diferencia(T);

            /*Mientras no hayamos recorrido todos los verticces*/
            while (!T.EsIgual(V))   
            {
                Arista[j] = AristaCosteMinimo(u, W, G.get_Aristas(), grado);    /*obtenemos la arista de coste minimo*/
                T.Inserta(Arista[j].get_Destino()); /*Actualiza el conjunto T, anyadimos el vertice que hemos visitado*/
                W.Elimina(Arista[j].get_Destino()); /*Actualiza el conjunto W, eliminamos el vertice que hemos visitado*/
                u = Arista[j].get_Destino();        /*actualizamos u con el siguiente punto a analizar*/
                grado[Arista[j].get_Origen()]++;    /*Actualizamos el grado*/
                grado[Arista[j].get_Destino()]++;   /*Actualizamos el grado*/
                j++;
                
            }
            /*anyadimos la ultima arista, la que vuelve*/
            Arista[j] = new AristaGrafo(Arista[j - 1].get_Destino(), vertice, G.Coste(Arista[j - 1].get_Destino(), vertice));
            grado[vertice]++;                           /*actualizamos el grado*/

            grado[Arista[j - 1].get_Destino()]++;       /*Actualiza el grado*/
            T.Inserta(Arista[j].get_Destino());         /*anyadimos el origen al conjunto, ya que es la vuelt*/

            return Arista;  /*Se devuelve el array de AristaGrafo*/
        }
        /* Funcion: AristaCosteMinimo
         * Descripcion: a traves de un vertice, el conjunto de vertices que aun no hemos visitado, la matriz de adyacencia para poder
         *              acceder a los costes de las aristas y el array de grados de cada vertice. Obtenemos la arista de coste minimo 
         *              y que el vertice destino no tenga un grado mayor de dos
         * Parametros:  int u: variable de tipo int que guarda el origen
         *              Conjunto<int> W: Conjunto de vertices que aun no hemos recorrido
         *              int[,] aristas: matriz de adyacendia
         *              int [] grado: array de que guarda los grados de los vertices
         * 
         */
        public static AristaGrafo AristaCosteMinimo(int u, Conjunto<int> W, int[,] aristas, int[] grado)
        {

            /*buscar dentro de la matriz de aristas*/
            AristaGrafo arista = new AristaGrafo(9999, 9999, 9999);
            int j = 0;
            for (int i = 0; i < W.Elementos(); i++)     /*Buscamos todas las posibles soluciones*/
            {


                while (W.Contiene(j) == false)          /*buscamos el elemento*/
                    j++;

                if (arista.get_Coste() > aristas[u, j] && grado[j] < 2) /*Comparamos el coste y el grado del vertice*/
                {

                    arista.set_Coste(aristas[u, j]);    /*actualizamos el coste de la arista*/
                    arista.set_Origen(u);               /*actualizamos el origen de la arista*/
                    arista.set_Destino(j);              /*actualizamos el destino de la arista*/

                }
                j++;        /*actualizamos la posisicon para poder seguir buscando elementos*/
            }

            return arista;      /*se devuelve la arista*/
        }
    }
}
