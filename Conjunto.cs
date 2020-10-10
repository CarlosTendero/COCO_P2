using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Conjunto<T>
    {

        private HashSet<T> elementos;
        /*Constructor vacio*/
        public Conjunto()
        {
            this.elementos = new HashSet<T>();
        }
        /*Constructor parmetrizado*/
        public Conjunto(Conjunto<T> C)
        {
            /*Creamos un Conjunto nuevo con los elementos del Conjunto que hemos pasado*/
            this.elementos = new HashSet<T>(C.elementos);
        }

        /*Muestra si es un conjunto vacio o no*/
        public bool Vacio()
        {
            return (this.elementos.Count() == 0);
        }
        /*Muestra si los elementos de dos Conjuntos son iguales o no*/
        public bool EsIgual(Conjunto<T> C)
        {
            return this.elementos.SetEquals(C.elementos);
        }
        /*Inicializa un Conjunto*/
        public void Inicializa()
        {
            this.elementos.Clear();
        }
        /*Devuelve los elementos*/
        public int Elementos()
        {
            return this.elementos.Count();
        }
        /*Se anyade un elemento al Conjunto*/
        public void Inserta(T e)
        {
            this.elementos.Add(e);
        }
        /*Elimina un elemento del conjunto*/
        public void Elimina(T e)
        {
            this.elementos.Remove(e);
        }
        /*Muestra si el elemento esta en el Conjunto*/
        public bool Contiene(T e)
        {
            return this.elementos.Contains(e);
        }
        /*Une alconjunto el conjunto que se le une por parametro*/
        public void Une(Conjunto<T> C)
        {
            this.elementos.UnionWith(C.elementos);
        }
        /*Intersecta el conjunto existente con el que se une por parametro*/
        public void Intersecta(Conjunto<T> C)
        {
            this.elementos.IntersectWith(C.elementos);
        }
        /*se realiza la operacion de resta sobre el conjunto existente tcon el que se pasa por parametro*/
        public void Resta(Conjunto<T> C)
        {
            this.elementos.ExceptWith(C.elementos);
        }
        /*Se unen dos conjuntos y se devuelve*/
        public Conjunto<T> Union(Conjunto<T> C)
        {
            Conjunto<T> cAux = new Conjunto<T>();
            cAux.elementos.UnionWith(this.elementos);
            cAux.Une(C);
            return cAux;

        }
        /*Se intersectan dos conjuntos y se devuelve*/
        public Conjunto<T> Interseccion(Conjunto<T> C)
        {
            Conjunto<T> cAux = new Conjunto<T>();
            cAux.elementos.UnionWith(this.elementos);
            cAux.Intersecta(C);
            return cAux;
        }
        /*Se realiza la diferencia entre dos conjuntos y se devuelve*/
        public Conjunto<T> Diferencia(Conjunto<T> C)
        {
            Conjunto<T> cAux = new Conjunto<T>();
            cAux.elementos.UnionWith(this.elementos);
            cAux.Resta(C);
            return cAux;
        }
        /*Devuelve en una cadena los elementos del conjunto*/
        public string ToString(string s)
        {
            return s + "{" + string.Join(" ",this.elementos) + "}";
        }
    }

}
    


