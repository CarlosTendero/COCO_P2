using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grafo de las ciudades: ");
            /* Grafo de las ciudades */
            Grafo G = new Grafo(20);

            /*Vertice A Corunya*/
            G.Arista(0, 1, 1118);
            G.Arista(1, 0, 1118);

            G.Arista(0, 2, 644);
            G.Arista(2, 0, 644);

            G.Arista(0, 3, 535);
            G.Arista(3, 0, 535);

            G.Arista(0, 4, 683);
            G.Arista(4, 0, 683);

            G.Arista(0, 5, 995);
            G.Arista(5, 0, 995);

            G.Arista(0, 6, 334);
            G.Arista(6, 0, 334);

            G.Arista(0, 7, 609);
            G.Arista(7, 0, 609);

            G.Arista(0, 8, 1153);
            G.Arista(8, 0, 1153);

            G.Arista(0, 9, 1010);
            G.Arista(9, 0, 1010);

            G.Arista(0, 10, 340);
            G.Arista(10, 0, 340);

            G.Arista(0, 11, 738);
            G.Arista(11, 0, 738);

            G.Arista(0, 12, 473);
            G.Arista(12, 0, 473);

            G.Arista(0, 13, 763);
            G.Arista(13, 0, 763);

            G.Arista(0, 14, 947);
            G.Arista(14, 0, 947);

            G.Arista(0, 15, 676);
            G.Arista(15, 0, 676);

            G.Arista(0, 16, 961);
            G.Arista(16, 0, 961);

            G.Arista(0, 17, 455);
            G.Arista(17, 0, 455);

            G.Arista(0, 18, 411);
            G.Arista(18, 0, 411);

            G.Arista(0, 19, 833);
            G.Arista(19, 0, 833);

            /*Vertice Barcelona*/
            G.Arista(1, 2, 620);
            G.Arista(2, 1, 620);

            G.Arista(1, 3, 583);
            G.Arista(3, 1, 583);

            G.Arista(1, 4, 918);
            G.Arista(4, 1, 918);

            G.Arista(1, 5, 908);
            G.Arista(5, 1, 908);

            G.Arista(1, 6, 784);
            G.Arista(6, 1, 784);

            G.Arista(1, 7, 621);
            G.Arista(7, 1, 621);

            G.Arista(1, 8, 997);
            G.Arista(8, 1, 997);

            G.Arista(1, 9, 590);
            G.Arista(9, 1, 590);

            G.Arista(1, 10, 902);
            G.Arista(10, 1, 902);

            G.Arista(1, 11, 437);
            G.Arista(11, 1, 437);

            G.Arista(1, 12, 778);
            G.Arista(12, 1, 778);

            G.Arista(1, 13, 529);
            G.Arista(13, 1, 529);

            G.Arista(1, 14, 1046);
            G.Arista(14, 1, 1046);

            G.Arista(1, 15, 453);
            G.Arista(15, 1, 453);

            G.Arista(1, 16, 349);
            G.Arista(16, 1, 349);

            G.Arista(1, 17, 663);
            G.Arista(17, 1, 663);

            G.Arista(1, 18, 759);
            G.Arista(18, 1, 759);

            G.Arista(1, 19, 296);
            G.Arista(19, 1, 296);

            /*Vertice Bilbao*/
            G.Arista(2, 3, 158);
            G.Arista(3, 2, 158);

            G.Arista(2, 4, 605);
            G.Arista(4, 2, 605);

            G.Arista(2, 5, 795);
            G.Arista(5, 2, 795);

            G.Arista(2, 6, 359);
            G.Arista(6, 2, 359);

            G.Arista(2, 7, 395);
            G.Arista(7, 2, 395);

            G.Arista(2, 8, 939);
            G.Arista(8, 2, 939);

            G.Arista(2, 9, 796);
            G.Arista(9, 2, 796);

            G.Arista(2, 10, 304);
            G.Arista(10, 2, 304);

            G.Arista(2, 11, 159);
            G.Arista(11, 2, 159);

            G.Arista(2, 12, 395);
            G.Arista(12, 2, 395);

            G.Arista(2, 13, 119);
            G.Arista(13, 2, 119);

            G.Arista(2, 14, 993);
            G.Arista(14, 2, 993);

            G.Arista(2, 15, 257);
            G.Arista(15, 2, 257);

            G.Arista(2, 16, 633);
            G.Arista(16, 2, 633);

            G.Arista(2, 17, 280);
            G.Arista(17, 2, 280);

            G.Arista(2, 18, 376);
            G.Arista(18, 2, 376);

            G.Arista(2, 19, 324);
            G.Arista(19, 2, 324);

            /*Vertice Burgos*/
            G.Arista(3, 4, 447);
            G.Arista(4, 3, 447);

            G.Arista(3, 5, 637);
            G.Arista(5, 3, 637);

            G.Arista(3, 6, 201);
            G.Arista(6, 3, 201);

            G.Arista(3, 7, 237);
            G.Arista(7, 3, 237);

            G.Arista(3, 8, 781);
            G.Arista(8, 3, 781);

            G.Arista(3, 9, 638);
            G.Arista(9, 3, 638);

            G.Arista(3, 10, 322);
            G.Arista(10, 3, 322);

            G.Arista(3, 11, 203);
            G.Arista(11, 3, 203);

            G.Arista(3, 12, 237);
            G.Arista(12, 3, 237);

            G.Arista(3, 13, 232);
            G.Arista(13, 3, 232);

            G.Arista(3, 14, 775);
            G.Arista(14, 3, 775);

            G.Arista(3, 15, 141);
            G.Arista(15, 3, 141);

            G.Arista(3, 16, 517);
            G.Arista(16, 3, 517);

            G.Arista(3, 17, 122);
            G.Arista(17, 3, 122);

            G.Arista(3, 18, 218);
            G.Arista(18, 3, 218);

            G.Arista(3, 19, 287);
            G.Arista(19, 3, 287);

            /*Vertice Caceres*/
            G.Arista(4, 5, 319);
            G.Arista(5, 4, 319);

            G.Arista(4, 6, 407);
            G.Arista(6, 4, 407);

            G.Arista(4, 7, 297);
            G.Arista(7, 4, 297);

            G.Arista(4, 8, 506);
            G.Arista(8, 4, 506);

            G.Arista(4, 9, 654);
            G.Arista(9, 4, 654);

            G.Arista(4, 10, 525);
            G.Arista(10, 4, 525);

            G.Arista(4, 11, 650);
            G.Arista(11, 4, 650);

            G.Arista(4, 12, 210);
            G.Arista(12, 4, 210);

            G.Arista(4, 13, 679);
            G.Arista(13, 4, 679);

            G.Arista(4, 14, 264);
            G.Arista(14, 4, 264);

            G.Arista(4, 15, 490);
            G.Arista(15, 4, 490);

            G.Arista(4, 16, 636);
            G.Arista(16, 4, 636);

            G.Arista(4, 17, 325);
            G.Arista(17, 4, 325);

            G.Arista(4, 18, 272);
            G.Arista(18, 4, 272);

            G.Arista(4, 19, 622);
            G.Arista(19, 4, 622);

            /*Vertice Cordoba*/
            G.Arista(5, 6, 733);
            G.Arista(6, 5, 733);

            G.Arista(5, 7, 400);
            G.Arista(7, 5, 400);

            G.Arista(5, 8, 187);
            G.Arista(8, 5, 187);

            G.Arista(5, 9, 444);
            G.Arista(9, 5, 444);

            G.Arista(5, 10, 851);
            G.Arista(10, 5, 851);

            G.Arista(5, 11, 807);
            G.Arista(11, 5, 807);

            G.Arista(5, 12, 529);
            G.Arista(12, 5, 529);

            G.Arista(5, 13, 869);
            G.Arista(13, 5, 869);

            G.Arista(5, 14, 138);
            G.Arista(14, 5, 138);

            G.Arista(5, 15, 631);
            G.Arista(15, 5, 631);

            G.Arista(5, 16, 545);
            G.Arista(16, 5, 545);

            G.Arista(5, 17, 578);
            G.Arista(17, 5, 578);

            G.Arista(5, 18, 616);
            G.Arista(18, 5, 616);

            G.Arista(5, 19, 725);
            G.Arista(19, 5, 725);

            /*Vertice Leon*/
            G.Arista(6, 7, 333);
            G.Arista(7, 6, 333);

            G.Arista(6, 8, 877);
            G.Arista(8, 6, 877);

            G.Arista(6, 9, 734);
            G.Arista(9, 6, 734);

            G.Arista(6, 10, 118);
            G.Arista(10, 6, 118);

            G.Arista(6, 11, 404);
            G.Arista(11, 6, 404);

            G.Arista(6, 12, 197);
            G.Arista(12, 6, 197);

            G.Arista(6, 13, 433);
            G.Arista(13, 6, 433);

            G.Arista(6, 14, 671);
            G.Arista(14, 6, 671);

            G.Arista(6, 15, 342);
            G.Arista(15, 6, 342);

            G.Arista(6, 16, 685);
            G.Arista(16, 6, 685);

            G.Arista(6, 17, 134);
            G.Arista(17, 6, 134);

            G.Arista(6, 18, 135);
            G.Arista(18, 6, 135);

            G.Arista(6, 19, 488);
            G.Arista(19, 6, 488);

            /*Vertice Madrid*/
            G.Arista(7, 8, 544);
            G.Arista(8, 7, 544);

            G.Arista(7, 9, 401);
            G.Arista(9, 7, 401);

            G.Arista(7, 10, 451);
            G.Arista(10, 7, 451);

            G.Arista(7, 11, 407);
            G.Arista(11, 7, 407);

            G.Arista(7, 12, 212);
            G.Arista(12, 7, 212);

            G.Arista(7, 13, 469);
            G.Arista(13, 7, 469);

            G.Arista(7, 14, 538);
            G.Arista(14, 7, 538);

            G.Arista(7, 15, 231);
            G.Arista(15, 7, 231);

            G.Arista(7, 16, 352);
            G.Arista(16, 7, 352);

            G.Arista(7, 17, 193);
            G.Arista(17, 7, 193);

            G.Arista(7, 18, 248);
            G.Arista(18, 7, 248);

            G.Arista(7, 19, 325);
            G.Arista(19, 7, 325);

            /*Vertice Malaga*/
            G.Arista(8, 9, 407);
            G.Arista(9, 8, 407);

            G.Arista(8, 10, 995);
            G.Arista(10, 8, 995);

            G.Arista(8, 11, 951);
            G.Arista(11, 8, 951);

            G.Arista(8, 12, 756);
            G.Arista(12, 8, 756);

            G.Arista(8, 13, 1013);
            G.Arista(13, 8, 1013);

            G.Arista(8, 14, 219);
            G.Arista(14, 8, 219);

            G.Arista(8, 15, 775);
            G.Arista(15, 8, 775);

            G.Arista(8, 16, 648);
            G.Arista(16, 8, 648);

            G.Arista(8, 17, 737);
            G.Arista(17, 8, 737);

            G.Arista(8, 18, 792);
            G.Arista(18, 8, 792);

            G.Arista(8, 19, 869);
            G.Arista(19, 8, 869);

            /*Vertice Murcia*/
            G.Arista(9, 10, 852);
            G.Arista(10, 9, 852);

            G.Arista(9, 11, 714);
            G.Arista(11, 9, 714);

            G.Arista(9, 12, 613);
            G.Arista(12, 9, 613);

            G.Arista(9, 13, 807);
            G.Arista(13, 9, 807);

            G.Arista(9, 14, 534);
            G.Arista(14, 9, 534);

            G.Arista(9, 15, 589);
            G.Arista(15, 9, 589);

            G.Arista(9, 16, 241);
            G.Arista(16, 9, 241);

            G.Arista(9, 17, 594);
            G.Arista(17, 9, 594);

            G.Arista(9, 18, 649);
            G.Arista(18, 9, 649);

            G.Arista(9, 19, 539);
            G.Arista(19, 9, 539);

            /*Vertice Oviedo*/
            G.Arista(10, 11, 463);
            G.Arista(11, 10, 463);

            G.Arista(10, 12, 315);
            G.Arista(12, 10, 315);

            G.Arista(10, 13, 423);
            G.Arista(13, 10, 423);

            G.Arista(10, 14, 789);
            G.Arista(14, 10, 789);

            G.Arista(10, 15, 463);
            G.Arista(15, 10, 463);

            G.Arista(10, 16, 803);
            G.Arista(16, 10, 803);

            G.Arista(10, 17, 252);
            G.Arista(17, 10, 252);

            G.Arista(10, 18, 253);
            G.Arista(18, 10, 253);

            G.Arista(10, 19, 604);
            G.Arista(19, 10, 604);

            /*Vertice Pamplona*/
            G.Arista(11, 12, 440);
            G.Arista(12, 11, 440);

            G.Arista(11, 13, 92);
            G.Arista(13, 11, 92);

            G.Arista(11, 14, 945);
            G.Arista(14, 11, 945);

            G.Arista(11, 15, 176);
            G.Arista(15, 11, 176);

            G.Arista(11, 16, 501);
            G.Arista(16, 11, 501);

            G.Arista(11, 17, 325);
            G.Arista(17, 11, 325);

            G.Arista(11, 18, 421);
            G.Arista(18, 11, 421);

            G.Arista(11, 19, 175);
            G.Arista(19, 11, 175);

            /*Vertice Salamanca*/
            G.Arista(12, 13, 469);
            G.Arista(13, 12, 469);

            G.Arista(12, 14, 474);
            G.Arista(14, 12, 474);

            G.Arista(12, 15, 325);
            G.Arista(15, 12, 325);

            G.Arista(12, 16, 564);
            G.Arista(16, 12, 564);

            G.Arista(12, 17, 115);
            G.Arista(17, 12, 115);

            G.Arista(12, 18, 62);
            G.Arista(18, 12, 62);

            G.Arista(12, 19, 482);
            G.Arista(19, 12, 482);

            /*Vertice San Sebastian*/
            G.Arista(13, 14, 1007);
            G.Arista(14, 13, 1007);

            G.Arista(13, 15, 268);
            G.Arista(15, 13, 268);

            G.Arista(13, 16, 594);
            G.Arista(16, 13, 594);

            G.Arista(13, 17, 354);
            G.Arista(17, 13, 354);

            G.Arista(13, 18, 450);
            G.Arista(18, 13, 450);

            G.Arista(13, 19, 268);
            G.Arista(19, 13, 268);

            /*Vertice Sevilla*/
            G.Arista(14, 15, 769);
            G.Arista(15, 14, 769);

            G.Arista(14, 16, 697);
            G.Arista(16, 14, 697);

            G.Arista(14, 17, 589);
            G.Arista(17, 14, 589);

            G.Arista(14, 18, 536);
            G.Arista(18, 14, 536);

            G.Arista(14, 19, 863);
            G.Arista(19, 14, 863);

            /*Vertice Soria*/
            G.Arista(15, 16, 376);
            G.Arista(16, 15, 376);

            G.Arista(15, 17, 210);
            G.Arista(17, 15, 210);

            G.Arista(15, 18, 306);
            G.Arista(18, 15, 306);

            G.Arista(15, 19, 157);
            G.Arista(19, 15, 157);

            /*Vertice Valencia*/
            G.Arista(16, 17, 545);
            G.Arista(17, 16, 545);

            G.Arista(16, 18, 600);
            G.Arista(18, 16, 600);

            G.Arista(16, 19, 326);
            G.Arista(19, 16, 326);

            /*Vertice Valladolid*/
            G.Arista(17, 18, 96);
            G.Arista(18, 17, 96);

            G.Arista(17, 19, 367);
            G.Arista(19, 17, 367);

            /*Vertice Zamora*/
            G.Arista(18, 19, 463);
            G.Arista(19, 18, 463);

            /*Vertice Zaragoza (Ya esta completo)*/

            /*Inicializamos las ciudades con las que vamos a programar*/

            Ciudad[] ciudades = new Ciudad[20];

            InicializarCiudades(ciudades);
            /*Mostramos las ciudades*/
            for (int i = 0; i < ciudades.GetLength(0); i++)
                Console.WriteLine(" Ciudad:  " + ciudades[i].nombre + " \tVertice:  " + ciudades[i].vertice);

            Console.ReadKey();

            G.MostrarMatrizAdyacencia();

            AristaGrafo[] aristas;


           /* Lo he movido a kruskal */
            

            /*--------------------------------------------------------------------------------------------------------------------*/
            /*Viajante de Comercio por Vecino mas Proximo*/
            int coste = 0;

            for (int t = 0; t < ciudades.GetLength(0); t++)
            {
                coste = 0;
                aristas = MasProximo<AristaGrafo>.ViajanteComercioVecinoMasProximo(G, t);
                /*Cogiendo A Corunya como punto de partida*/

                Console.WriteLine("Viajante de comercio por Vecino mas Proximo desde:\t{0}", MostrarCuidadPorVertice(ciudades, t));
                for (int i = 0; i < aristas.GetLength(0); i++)
                {
                    Console.WriteLine("de " + MostrarCuidadPorVertice(ciudades, aristas[i].get_Origen()) + " a " + MostrarCuidadPorVertice(ciudades, aristas[i].get_Destino()) + ": " + aristas[i].get_Coste());
                    coste += aristas[i].get_Coste();
                }
                Console.WriteLine("Coste Total:{0}\n", coste);

                Console.ReadKey();
            }


            Console.ReadKey();

            Console.Clear();
            /*--------------------------------------------------------------------------------------------------------------------*/
            /*Viajante de Comercio por VariacionPrim*/

            for (int t = 0; t < ciudades.GetLength(0); t++)
            {

                coste = 0;

                aristas = VariacionPrim<AristaGrafo>.ViajanteDeComercio(G, t);
                /*Cogiendo A corunya como punto de partida*/

                Console.WriteLine("Viajante de comercio por VariacionPrim desde:\t{0}", MostrarCuidadPorVertice(ciudades, t));
                for (int j = 0; j < aristas.GetLength(0); j++)
                {
                    Console.WriteLine("de " + MostrarCuidadPorVertice(ciudades, aristas[j].get_Origen()) + " a " + MostrarCuidadPorVertice(ciudades, aristas[j].get_Destino()) + ": " + aristas[j].get_Coste());
                    coste += aristas[j].get_Coste();
                }
                Console.WriteLine("Coste Total:{0}\n", coste);

                Console.ReadKey();
            }

            Console.ReadKey();




            /*--------------------------------------------------------------------------------------------------------------------*/
            /*Viajante de Comercio por VariacionKruskal*/

            coste = 0;

            AristaGrafo[] todas_aristas = InicilizarTodasAristas();

            aristas = VariacionKruskal<AristaGrafo>.ViajanteDeComercio(G, ref todas_aristas);

            Console.WriteLine("Viajante de comercio por VariacionKruskal:");
            for (int i = 0; i < aristas.GetLength(0)-1; i++)
            {
                Console.WriteLine("de " + MostrarCuidadPorVertice(ciudades, aristas[i].get_Origen()) + " a " + MostrarCuidadPorVertice(ciudades, aristas[i].get_Destino()) + ": " + aristas[i].get_Coste());
                coste += aristas[i].get_Coste();
            }
            Console.WriteLine("Coste Total:{0}\n", coste);


            Console.ReadKey();
        }

        

        public static void InicializarCiudades(Ciudad[] ciudades)
        {
            ciudades[0] = new Ciudad(0, "A Corunya");
            ciudades[1] = new Ciudad(1, "Barcelona");
            ciudades[2] = new Ciudad(2, "Bilbao");
            ciudades[3] = new Ciudad(3, "Burgos");
            ciudades[4] = new Ciudad(4, "Caceres");
            ciudades[5] = new Ciudad(5, "Cordoba");
            ciudades[6] = new Ciudad(6, "Leon");
            ciudades[7] = new Ciudad(7, "Madrid");
            ciudades[8] = new Ciudad(8, "Malaga");
            ciudades[9] = new Ciudad(9, "Murcia");
            ciudades[10] = new Ciudad(10, "Oviedo");
            ciudades[11] = new Ciudad(11, "Pamplona");
            ciudades[12] = new Ciudad(12, "Salamanca");
            ciudades[13] = new Ciudad(13, "San Sebastian");
            ciudades[14] = new Ciudad(14, "Sevilla");
            ciudades[15] = new Ciudad(15, "Soria");
            ciudades[16] = new Ciudad(16, "Valencia");
            ciudades[17] = new Ciudad(17, "Valladolid");
            ciudades[18] = new Ciudad(18, "Zamora");
            ciudades[19] = new Ciudad(19, "Zaragoza");
        }



        public static AristaGrafo[] InicilizarTodasAristas()
        {
            AristaGrafo[] aristas = { new AristaGrafo(0,0,9999),new AristaGrafo(0,1,1118), new AristaGrafo(0,2,644), new AristaGrafo(0,3,535), new AristaGrafo(0,4,683), new AristaGrafo(0,5,995), new AristaGrafo(0,6,334), new AristaGrafo(0,7,609), new AristaGrafo(0,8,1153), new AristaGrafo(0,9,1010), new AristaGrafo(0,10,340), new AristaGrafo(0,11,738), new AristaGrafo(0,12,473), new AristaGrafo(0,13,763), new AristaGrafo(0,14,947), new AristaGrafo(0,15,767), new AristaGrafo(0,16,961), new AristaGrafo(0,17,455), new AristaGrafo(0,18,411), new AristaGrafo(0,19,833),
                                      new AristaGrafo(1,0,1118), new AristaGrafo(1,1,9999), new AristaGrafo(1,2,620), new AristaGrafo(1,3,583), new AristaGrafo(1,4,918), new AristaGrafo(1,5,908), new AristaGrafo(1,6,784), new AristaGrafo(1,7,621), new AristaGrafo(1,8,997), new AristaGrafo(1,9,590), new AristaGrafo(1,10,902), new AristaGrafo(1,11,437), new AristaGrafo(1,12,778), new AristaGrafo(1,13,529), new AristaGrafo(1,14,1046), new AristaGrafo(1,15,453), new AristaGrafo(1,16,349), new AristaGrafo(1,17,663), new AristaGrafo(1,18,759), new AristaGrafo(1,19,296),
                                      new AristaGrafo(2,0,644), new AristaGrafo(2,1,620), new AristaGrafo(2,2,9999), new AristaGrafo(2,3,158), new AristaGrafo(2,4,605), new AristaGrafo(2,5,795), new AristaGrafo(2,6,359), new AristaGrafo(2,7,395), new AristaGrafo(2,8,939), new AristaGrafo(2,9,796), new AristaGrafo(2,10,304), new AristaGrafo(2,11,159), new AristaGrafo(2,12,395), new AristaGrafo(2,13,119), new AristaGrafo(2,14,993), new AristaGrafo(2,15,257), new AristaGrafo(2,16,633), new AristaGrafo(2,17,280), new AristaGrafo(2,18,376), new AristaGrafo(2,19,324),
                                      new AristaGrafo(3,0,535), new AristaGrafo(3,1,583), new AristaGrafo(3,2,158), new AristaGrafo(3,3,9999), new AristaGrafo(3,4,447), new AristaGrafo(3,5,637), new AristaGrafo(3,6,201), new AristaGrafo(3,7,237), new AristaGrafo(3,8,781), new AristaGrafo(3,9,638), new AristaGrafo(3,10,322), new AristaGrafo(3,11,203), new AristaGrafo(3,12,237), new AristaGrafo(3,13,232), new AristaGrafo(3,14,775), new AristaGrafo(3,15,141), new AristaGrafo(3,16,517), new AristaGrafo(3,17,122), new AristaGrafo(3,18,218), new AristaGrafo(3,19,287),
                                      new AristaGrafo(4,0,683), new AristaGrafo(4,1,918), new AristaGrafo(4,2,605), new AristaGrafo(4,3,447), new AristaGrafo(4,4,9999), new AristaGrafo(4,5,319), new AristaGrafo(4,6,407), new AristaGrafo(4,7,297), new AristaGrafo(4,8,506), new AristaGrafo(4,9,654), new AristaGrafo(4,10,525), new AristaGrafo(4,11,650), new AristaGrafo(4,12,210), new AristaGrafo(4,13,679), new AristaGrafo(4,14,264), new AristaGrafo(4,15,490), new AristaGrafo(4,16,636), new AristaGrafo(4,17,325), new AristaGrafo(4,18,272), new AristaGrafo(4,19,622),
                                      new AristaGrafo(5,0,995), new AristaGrafo(5,1,908), new AristaGrafo(5,2,795), new AristaGrafo(5,3,637), new AristaGrafo(5,4,319), new AristaGrafo(5,5,9999), new AristaGrafo(5,6,733), new AristaGrafo(5,7,400), new AristaGrafo(5,8,187), new AristaGrafo(5,9,444), new AristaGrafo(5,10,851), new AristaGrafo(5,11,807), new AristaGrafo(5,12,529), new AristaGrafo(5,13,869), new AristaGrafo(5,14,138), new AristaGrafo(5,15,631), new AristaGrafo(5,16,545), new AristaGrafo(5,17,578), new AristaGrafo(5,18,616), new AristaGrafo(5,19,725),
                                      new AristaGrafo(6,0,334), new AristaGrafo(6,1,784), new AristaGrafo(6,2,359), new AristaGrafo(6,3,201), new AristaGrafo(6,4,407), new AristaGrafo(6,5,733), new AristaGrafo(6,6,9999), new AristaGrafo(6,7,333), new AristaGrafo(6,8,877), new AristaGrafo(6,9,734), new AristaGrafo(6,10,118), new AristaGrafo(6,11,404), new AristaGrafo(6,12,197), new AristaGrafo(6,13,433), new AristaGrafo(6,14,671), new AristaGrafo(6,15,342), new AristaGrafo(6,16,685), new AristaGrafo(6,17,134), new AristaGrafo(6,18,135), new AristaGrafo(6,19,488),
                                      new AristaGrafo(7,0,609), new AristaGrafo(7,1,621), new AristaGrafo(7,2,395), new AristaGrafo(7,3,237), new AristaGrafo(7,4,297), new AristaGrafo(7,5,400), new AristaGrafo(7,6,333), new AristaGrafo(7,7,9999), new AristaGrafo(7,8,544), new AristaGrafo(7,9,401), new AristaGrafo(7,10,451), new AristaGrafo(7,11,407), new AristaGrafo(7,12,212), new AristaGrafo(7,13,469), new AristaGrafo(7,14,538), new AristaGrafo(7,15,231), new AristaGrafo(7,16,352), new AristaGrafo(7,17,193), new AristaGrafo(1,18,248), new AristaGrafo(1,19,325),
                                      new AristaGrafo(8,0,1153), new AristaGrafo(8,1,997), new AristaGrafo(8,2,939), new AristaGrafo(8,3,781), new AristaGrafo(8,4,506), new AristaGrafo(8,5,187), new AristaGrafo(8,6,877), new AristaGrafo(8,7,544), new AristaGrafo(8,8,9999), new AristaGrafo(8,9,407), new AristaGrafo(8,10,995), new AristaGrafo(8,11,951), new AristaGrafo(8,12,756), new AristaGrafo(8,13,1013), new AristaGrafo(8,14,219), new AristaGrafo(8,15,775), new AristaGrafo(8,16,684), new AristaGrafo(8,17,737), new AristaGrafo(8,18,792), new AristaGrafo(8,19,869),
                                      new AristaGrafo(9,0,1010), new AristaGrafo(9,1,590), new AristaGrafo(9,2,796), new AristaGrafo(9,3,648), new AristaGrafo(9,4,654), new AristaGrafo(9,5,444), new AristaGrafo(9,6,734), new AristaGrafo(9,7,401), new AristaGrafo(9,8,407), new AristaGrafo(9,9,9999), new AristaGrafo(9,10,852), new AristaGrafo(9,11,714), new AristaGrafo(9,12,613), new AristaGrafo(9,13,807), new AristaGrafo(9,14,534), new AristaGrafo(9,15,589), new AristaGrafo(9,16,241), new AristaGrafo(9,17,594), new AristaGrafo(9,18,649), new AristaGrafo(9,19,539),
                                      new AristaGrafo(10,0,340), new AristaGrafo(10,1,902), new AristaGrafo(10,2,304), new AristaGrafo(10,3,322), new AristaGrafo(10,4,525), new AristaGrafo(10,5,851), new AristaGrafo(10,6,118), new AristaGrafo(10,7,451), new AristaGrafo(10,8,995), new AristaGrafo(10,9,852), new AristaGrafo(10,10,9999), new AristaGrafo(10,11,463), new AristaGrafo(10,12,315), new AristaGrafo(10,13,423), new AristaGrafo(10,14,789), new AristaGrafo(10,15,463), new AristaGrafo(10,16,803), new AristaGrafo(10,17,252), new AristaGrafo(10,18,253), new AristaGrafo(10,19,604),
                                      new AristaGrafo(11,0,738), new AristaGrafo(11,1,437), new AristaGrafo(11,2,159), new AristaGrafo(11,3,203), new AristaGrafo(11,4,650), new AristaGrafo(11,5,807), new AristaGrafo(11,6,404), new AristaGrafo(11,7,407), new AristaGrafo(11,8,951), new AristaGrafo(11,9,714), new AristaGrafo(11,10,463), new AristaGrafo(11,11,9999), new AristaGrafo(11,12,440), new AristaGrafo(11,13,92), new AristaGrafo(11,14,945), new AristaGrafo(11,15,176), new AristaGrafo(11,16,501), new AristaGrafo(11,17,325), new AristaGrafo(11,18,421), new AristaGrafo(11,19,175),
                                      new AristaGrafo(12,0,473), new AristaGrafo(12,1,778), new AristaGrafo(12,2,395), new AristaGrafo(12,3,237), new AristaGrafo(12,4,210), new AristaGrafo(12,5,529), new AristaGrafo(12,6,197), new AristaGrafo(12,7,212), new AristaGrafo(12,8,756), new AristaGrafo(12,9,613), new AristaGrafo(12,10,315), new AristaGrafo(12,11,440), new AristaGrafo(12,12,9999), new AristaGrafo(12,13,469), new AristaGrafo(12,14,474), new AristaGrafo(12,15,325), new AristaGrafo(12,16,564), new AristaGrafo(12,17,115), new AristaGrafo(12,18,62), new AristaGrafo(12,19,482),
                                      new AristaGrafo(13,0,763), new AristaGrafo(13,1,529), new AristaGrafo(13,2,119), new AristaGrafo(13,3,232), new AristaGrafo(13,4,679), new AristaGrafo(13,5,869), new AristaGrafo(13,6,433), new AristaGrafo(13,7,469), new AristaGrafo(13,8,1013), new AristaGrafo(13,9,807), new AristaGrafo(13,10,423), new AristaGrafo(13,11,92), new AristaGrafo(13,12,469), new AristaGrafo(13,13,9999), new AristaGrafo(13,14,1007), new AristaGrafo(13,15,268), new AristaGrafo(13,16,594), new AristaGrafo(13,17,354), new AristaGrafo(13,18,450), new AristaGrafo(13,19,268),
                                      new AristaGrafo(14,0,947), new AristaGrafo(14,1,1046), new AristaGrafo(14,2,993), new AristaGrafo(14,3,775), new AristaGrafo(14,4,264), new AristaGrafo(14,5,138), new AristaGrafo(14,6,671), new AristaGrafo(14,7,538), new AristaGrafo(14,8,219), new AristaGrafo(14,9,534), new AristaGrafo(14,10,789), new AristaGrafo(14,11,945), new AristaGrafo(14,12,474), new AristaGrafo(14,13,1007), new AristaGrafo(14,14,9999), new AristaGrafo(14,15,769), new AristaGrafo(14,16,697), new AristaGrafo(14,17,589), new AristaGrafo(14,18,536), new AristaGrafo(14,19,836),
                                      new AristaGrafo(15,0,676), new AristaGrafo(15,1,453), new AristaGrafo(15,2,257), new AristaGrafo(15,3,141), new AristaGrafo(15,4,490), new AristaGrafo(15,5,631), new AristaGrafo(15,6,432), new AristaGrafo(15,7,231), new AristaGrafo(15,8,775), new AristaGrafo(15,9,589), new AristaGrafo(15,10,463), new AristaGrafo(15,11,176), new AristaGrafo(15,12,325), new AristaGrafo(15,13,268), new AristaGrafo(15,14,769), new AristaGrafo(15,15,9999), new AristaGrafo(15,16,376), new AristaGrafo(15,17,210), new AristaGrafo(15,18,306), new AristaGrafo(15,19,157),
                                      new AristaGrafo(16,0,961), new AristaGrafo(16,1,349), new AristaGrafo(16,2,633), new AristaGrafo(16,3,517), new AristaGrafo(16,4,636), new AristaGrafo(16,5,545), new AristaGrafo(16,6,685), new AristaGrafo(16,7,352), new AristaGrafo(16,8,648), new AristaGrafo(16,9,241), new AristaGrafo(16,10,803), new AristaGrafo(16,11,501), new AristaGrafo(16,12,564), new AristaGrafo(16,13,594), new AristaGrafo(16,14,697), new AristaGrafo(16,15,376), new AristaGrafo(16,16,9999), new AristaGrafo(16,17,545), new AristaGrafo(16,18,600), new AristaGrafo(16,19,326),
                                      new AristaGrafo(17,0,455), new AristaGrafo(17,1,663), new AristaGrafo(17,2,280), new AristaGrafo(17,3,122), new AristaGrafo(17,4,325), new AristaGrafo(17,5,578), new AristaGrafo(17,6,134), new AristaGrafo(17,7,193), new AristaGrafo(17,8,737), new AristaGrafo(17,9,594), new AristaGrafo(17,10,252), new AristaGrafo(17,11,325), new AristaGrafo(17,12,115), new AristaGrafo(17,13,354), new AristaGrafo(17,14,589), new AristaGrafo(17,15,210), new AristaGrafo(17,16,545), new AristaGrafo(17,17,9999), new AristaGrafo(17,18,96), new AristaGrafo(17,19,367),
                                      new AristaGrafo(18,0,411), new AristaGrafo(18,1,759), new AristaGrafo(18,2,376), new AristaGrafo(18,3,218), new AristaGrafo(18,4,272), new AristaGrafo(18,5,616), new AristaGrafo(18,6,135), new AristaGrafo(18,7,248), new AristaGrafo(18,8,792), new AristaGrafo(18,9,649), new AristaGrafo(18,10,253), new AristaGrafo(18,11,421), new AristaGrafo(18,12,62), new AristaGrafo(18,13,450), new AristaGrafo(18,14,536), new AristaGrafo(18,15,306), new AristaGrafo(18,16,600), new AristaGrafo(18,17,96), new AristaGrafo(18,18,9999), new AristaGrafo(18,19,463),
                                      new AristaGrafo(19,0,833), new AristaGrafo(19,1,296), new AristaGrafo(19,2,324), new AristaGrafo(19,3,287), new AristaGrafo(19,4,622), new AristaGrafo(19,5,725), new AristaGrafo(19,6,488), new AristaGrafo(19,7,325), new AristaGrafo(19,8,869), new AristaGrafo(19,9,539), new AristaGrafo(19,10,604), new AristaGrafo(19,11,175), new AristaGrafo(19,12,482), new AristaGrafo(19,13,268), new AristaGrafo(19,14,863), new AristaGrafo(19,15,157), new AristaGrafo(19,16,326), new AristaGrafo(19,17,367), new AristaGrafo(19,18,463), new AristaGrafo(19,19,9999) };


            return aristas;
        }





        public static string MostrarCuidadPorVertice(Ciudad[] ciudades, int vertice)
        {
            string aux = " ";
            for (int i = 0; i < ciudades.GetLength(0); i++)
                if (ciudades[i].vertice == vertice)
                    aux = ciudades[i].nombre;

            return aux;
        }

    }
}
