using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    public class ColaPrioridad<T>
    {
        public List<int> prioridad;
        public List<T> elementos;

        public ColaPrioridad()
        {
            this.prioridad = new List<int>();
            this.elementos = new List<T>();
        }
        
        public bool Vacia()
        {
            /*Devuelve true si la cola esta vacia*/
            return (elementos.Count() == 0);
        }

        public int Elementos()
        {
            /*Devuelve el numero de elementos de la cola*/
            return elementos.Count();
        }

        public void Intercambio(int p, int q)
        {
            /*Intercambia los valores almacenados en las posiciones p y q de ambas listas, la de prioridades y la de elementos*/
            int auxPrioridad = prioridad[p];
            T auxElemento = elementos[p];

            prioridad[p] = prioridad[q];
            prioridad[q] = auxPrioridad;

            elementos[p] = elementos[q];
            elementos[q] = auxElemento;
        }

        public void IntercambioAscendente(int p, int q)
        {
            /*Intercambia los elementos de las posiciones p y q de la cola si la prioridad[q] < prioridad[p] hasta llegar a la raiz del monticulo*/
            if (p >= 0 && q < prioridad.Count())
            {
                if (prioridad[q] < prioridad[p]) // La condicion tiene que ser hasta que q llegue a la raiz del monticulo
                {
                    Intercambio(p, q);

                    if (p >= 0)
                    {
                        int aux = p;

                        if (aux % 2 == 0)
                            p = (p - 2) / 2; // Hijo derecho
                        else
                            p = (p - 1) / 2; // Hijo izquierdo 

                        IntercambioAscendente(p, aux);
                    }

                }
            }

        }

        public void Inserta(int prioridad, T elemento)
        {
            /*Inserta un elemento en el montículo y realiza el intercambio ascedente hasta llegar a la raiz  para 
             mantener el orden de un monticulo de minimos*/
            this.elementos.Add(elemento);
            this.prioridad.Add(prioridad);
            int aux = this.elementos.Count()-1;
           
            //if (aux > 0)
            //{
            //    if (aux % 2 == 0)
            //    {
            //        IntercambioAscendente((this.elementos.Count() - 2) / 2, this.elementos.Count()-1); // Hijo derecho
            //    //    IntercambioAscendente((this.prioridad.Count() - 2) / 2, this.prioridad.Count()-1);
            //    }
            //    else
            //    {
            //        IntercambioAscendente((this.elementos.Count() - 1) / 2, this.elementos.Count()-1); // Hijo izquierdo
            //    //    IntercambioAscendente((this.prioridad.Count() - 1) / 2, this.prioridad.Count()-1);
            //    }
            //}
            
        }

        public void IntercambioDescendente(int p)
        {
            /*Intercambia los elementos del monticulo desde la raiz hasta llegar a una hoja para manetener el
             orden de un monticulo de minimos*/


            if (p * 2 + 1 < prioridad.Count())
            {
                if (prioridad[p] > prioridad[p * 2 + 1])
                {
                    if (p * 2 + 2 < prioridad.Count())
                    {
                        if (prioridad[p] < prioridad[p * 2 + 2])   // Hijo izquierdo
                        {
                            Intercambio(p*2+1, p);

                            IntercambioDescendente(p * 2 + 1);
                        }
                        else if (prioridad[p] > prioridad[p * 2 + 2])
                        {
                            Intercambio(p*2+2, p);

                            IntercambioDescendente(p * 2 + 2);
                        }
                    }
                 //   else if (p * 2 + 2 >= prioridad.Count())
                 //   {

                        Intercambio(p*2+1, p);
                        IntercambioDescendente(p * 2 + 1);
                //    }

                }else if(p*2+2 < prioridad.Count())
                {
                    if(prioridad[p] > prioridad[p*2 + 2])
                    {
                        Intercambio(p * 2 + 2, p);
                        IntercambioDescendente(p * 2 + 2);
                    }
                }
            }

        }

        public T ElmininaMinimo()
        {
            /*Si la cola esta vacia devuelve false
              Si la cola no esta vacia elimina el elemeento de la raiz del monticulo, devuelve 
              su prioridad y el elemento asociado
              
              Para mantener el orden de un monticulo de minimos, mueve el ultimo elementos a la raiz y realiza el
              intercambio descendente para que el elemeneto con menor prioridad ocupe la raiz del monticulo*/

            int tramo = prioridad[0];
           
            T miArista = elementos[0];

            int indexida = prioridad.FindIndex(x => x == tramo);
            if (indexida != -1)
            {
                prioridad.RemoveAt(indexida);
                elementos.RemoveAt(indexida);
            }
            int indexvuelta = prioridad.FindIndex(x => x == tramo);
            if (indexvuelta != -1)
            {
                prioridad.RemoveAt(indexvuelta);
                elementos.RemoveAt(indexvuelta);
            }
            //prioridad.RemoveAt(0);
            //prioridad.RemoveAt(0);
            //elementos.RemoveAt(0);

            //T arista = elementos[0]; 
            //elementos.RemoveAt(0);
            
            for (int i = 0; i < prioridad.Count(); i++)
                IntercambioDescendente(i);
            for (int i = 0; i < prioridad.Count(); i++)
                IntercambioAscendente(i, i + 1);
                
            return miArista;
        }

        /*
        public void EliminaporArista(AristaGrafo arista)
        {
            T arista_aux = (T)Convert.ChangeType(arista, typeof(T));
            
            int borrado = 0;
            for(int i = 0; i < this.Elementos() && borrado == 0; i++)
            {
                if(this.elementos[i].Equals(arista_aux) == true)
                {
                    borrado = 1;
                    this.elementos.RemoveAt(i);
                }

            }

           
        }

    */
    }
}
