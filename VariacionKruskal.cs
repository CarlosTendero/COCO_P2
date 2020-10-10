using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class VariacionKruskal<T>
    {

        public static AristaGrafo[] ViajanteDeComercio(Grafo G, ref AristaGrafo[] todas_aristas)
        {

            IList<AristaGrafo> lista_aristas = new List<AristaGrafo>();
            for (int i = 0; i < todas_aristas.GetLength(0); i++)
                lista_aristas.Add(todas_aristas[i]);

            ColaPrioridad<AristaGrafo> cola = new ColaPrioridad<AristaGrafo>();

            for (int i = 0; i < todas_aristas.GetLength(0); i++)
                cola.Inserta(todas_aristas[i].get_Coste(), todas_aristas[i]);

            for (int i = 0; i < cola.prioridad.Count(); i++)
                cola.IntercambioDescendente(i);
            for (int i = 0; i < cola.prioridad.Count(); i++)
                cola.IntercambioAscendente(i, i + 1);

           

            Conjunto<int>[] bosque = new Conjunto<int>[G.get_Vertices()];     // Inicializamos un array de conjuntos que sera nuestro bosque de arboles
            for (int i = 0; i < G.get_Vertices(); i++)
                bosque[i] = new Conjunto<int>();

            for (int i = 0; i < G.get_Vertices(); i++)    // Insertamos los vertices dentro del array 
            {
                bosque[i].Inserta(i);
            }

            AristaGrafo arista = new AristaGrafo();

            AristaGrafo[] resul_arista = new AristaGrafo[G.get_Vertices()];

            int[] grado_vertices = new int[G.get_Vertices()];
            for (int i = 0; i < grado_vertices.GetLength(0); i++)
                grado_vertices[i] = 0;

            int p = 0;

            /*
            AristaGrafo arista_vuelta = new AristaGrafo();
            */
            bool completado = false;

            while (completado == false)
            {

                arista = cola.ElmininaMinimo();
                /*
                arista_vuelta.set_Origen(arista.get_Destino());
                arista_vuelta.set_Destino(arista.get_Origen());
                arista_vuelta.set_Coste(arista.get_Coste());

                cola.EliminaporArista(arista_vuelta);
                */
                for (int i = 0; i < cola.prioridad.Count(); i++)
                    cola.IntercambioDescendente(i);
                for (int i = 0; i < cola.prioridad.Count(); i++)
                    cola.IntercambioAscendente(i, i + 1);


                if ((grado_vertices[arista.get_Origen()] < 2) && (grado_vertices[arista.get_Destino()] < 2))
                {
                    //if (!(bosque[arista.get_Origen()].Contiene(arista.get_Destino())) && !(bosque[arista.get_Destino()].Contiene(arista.get_Origen())) && bosque[arista.get_Destino()].Elementos() > 0)
                  // if(bosque[arista.get_Origen()].Elementos() > 0 || bosque[arista.get_Destino()].Elementos() > 0)
                   // {


                        if (bosque[arista.get_Origen()].Elementos() == 0)
                        {
                            Conjunto<int> aux = new Conjunto<int>();
                            int posicion_aux = 0;
                            for (posicion_aux = 0; posicion_aux < bosque.GetLength(0) && !bosque[posicion_aux].Contiene(arista.get_Origen()); posicion_aux++)
                                aux = bosque[posicion_aux+1];

                            if (!aux.Contiene(arista.get_Destino()))
                            {
                                grado_vertices[arista.get_Origen()]++;
                                grado_vertices[arista.get_Destino()]++;

                                bosque[posicion_aux].Une(aux);

                                bosque[arista.get_Origen()].Inicializa();

                                resul_arista[p] = arista;

                                p++;
                            }
                        }
                        else if (bosque[arista.get_Destino()].Elementos() == 0)
                        {
                            Conjunto<int> aux = new Conjunto<int>();
                            int posicion = 0;
                            for (posicion = 0; posicion < bosque.GetLength(0) && !bosque[posicion].Contiene(arista.get_Destino()); posicion++)
                                aux = bosque[posicion+1];
                            if (!aux.Contiene(arista.get_Origen()))
                            {
                                grado_vertices[arista.get_Origen()]++;
                                grado_vertices[arista.get_Destino()]++;

                                bosque[arista.get_Origen()].Une(aux);

                                bosque[posicion].Inicializa();

                                resul_arista[p] = arista;

                                p++;
                            }

                        }
                        else
                        {
                            grado_vertices[arista.get_Origen()]++;
                            grado_vertices[arista.get_Destino()]++;

                            bosque[arista.get_Origen()].Une(bosque[arista.get_Destino()]);

                            bosque[arista.get_Destino()].Inicializa();

                            resul_arista[p] = arista;

                            p++;
                        }
                  //  }
                }



                completado = true;
                for (int j = 0; j < grado_vertices.GetLength(0) && completado == true; j++)   // recorre todo el vector de los grados de los vertices y si todos tienen grado dos ya esta completado
                {
                    if (grado_vertices[j] != 2)
                        completado = false;
                }

                if (cola.prioridad.Count() == 0)
                    completado = true;

            }
            return resul_arista;   

        }

        



    }
}
