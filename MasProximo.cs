using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class MasProximo<T>
    {
        /* Funcion: ViajanteComercioMasProximo
         * Descripcion: Hallar el recorrido a traves de un grafo y un punto de partida
         *              moviendose unicamente a traves de las aristas de coste minimo
         * Parametros: Grafo G, grafo con el que vamos a trabajar
         *              int vertice: variable de tipo int que va a marcara el pnto de partida
         * Salida:  Un array AristaGrafo en que se han ido guardando las aristas de coste minimo
         */
        
        public static AristaGrafo[] ViajanteComercioVecinoMasProximo(Grafo G, int vertice)
        {
            Conjunto<int> V = new Conjunto<int>();  /*Conjunto que guarda todos los vertices del grafo*/
            Conjunto<int> T = new Conjunto<int>();  /*Conjunto donde se guardan los vertinces que hemos recorrido en ese orden*/
            AristaGrafo[] Arista = new AristaGrafo[G.get_Vertices()];   /*array de aristas, es la solucion del problema*/
            int j = 0;  /*variable que marca la posicion donde se va a guardar las aristas dentro del array*/
            int u = vertice;


            /*Inicializa el conjunto V con todos los vertices del grafo G*/
            for (int i = 0; i < G.get_Vertices(); i++)
                V.Inserta(i);
            /*Inicializa el conjunto T con el vertice de partida*/
            T.Inserta(vertice);

            /*Conjunto donde se almacenan los vertices aun no visitados*/
            Conjunto<int> W = V.Diferencia(T);


            /*Mientras no hayamos visitado todos los vertices del grafo*/
            while (!T.EsIgual(V))
            {
                
                Arista[j] = AristaCosteMinimo(u, W, G.get_Aristas());   /*Obtenemos la arista de coste minimo*/
                T.Inserta(Arista[j].get_Destino());    /*Actualizamos el conjunto T*/
                W.Elimina(Arista[j].get_Destino());    /*Actualizamos el conjunto W*/
                u = Arista[j].get_Destino();           /*Actualizamos el siguiente punto analizar*/
                j++;                /*actualizamos la variable que indica la posicion del array de nuestras aristas, solucion*/
            }

            /*Colocamos el ultimo punto visitado con el origen para dar la vuelta*/
            Arista[j] = new AristaGrafo(Arista[j-1].get_Destino(), vertice, G.Coste(Arista[j-1].get_Destino(),vertice));

            T.Inserta(Arista[j].get_Destino()); /*Actualizamos el conjunto de vertices que recorremos*/

            return Arista;  /*Se devuelve el array de AristaGrafo*/
        }
        /* Funcion: AristaCosteMinimo
         * Descripcion: Dado un vertice, un conjunto y la matriz de adyacencia, encontrar la arista que une el vertice
         *              con un elemento del conjunto que tenga la arista de coste minimo
         * Parametros: int u: varia de tipo int que guarda el origen
         *             Conjunto<int> W: Conjunto de vertices que aun no hemos recorrido
         *             int [,] aristas: matriz de adyacencia
         * Salida: Una variable de tipo AristaCosteMinimo donde u, es el origen, elemento de W es el destino y el coste de la 
         *         arista de coste minimo.
         */
        public static AristaGrafo AristaCosteMinimo(int u, Conjunto<int> W, int [,] aristas)
        {

            /*buscar dentro de la matriz de aristas*/
            AristaGrafo arista = new AristaGrafo(9999,9999,9999);   /*Inicializo la arista*/
            int j = 0;  
            for(int i = 0; i < W.Elementos(); i++)  /*numero de vueltas que tengo que dar para comprobar todos*/
            {
                

                while (W.Contiene(j) == false)      /*encuentro el elemento*/
                    j++;

                if (arista.get_Coste() > aristas[u, j]) /*modifico la arista en caso de ecnontrar alguna que tenga un coste mas pequenyo*/
                {

                    arista.set_Coste(aristas[u, j]);    /*actualizo el coste de la arista*/
                    arista.set_Origen(u);               /*actualizo el origen de la arista*/
                    arista.set_Destino(j);              /*actualizo el destino de la arista*/
                    
                }
                j++;   /*actualizo la variable que marca el elemento*/
            }

            return arista;  /*se devuelve la arista*/
        }

    
    }
}