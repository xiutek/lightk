using System;
using System.Collections.Generic;
using System.Text;

namespace lightk
{
    // FLAGS PARA LOS RESULTADOS DE LOS MENUS
    class Server_Menu
    {
        public static int Tutorial(int tutorial)
        {
            Console.WriteLine("Flag Tutorial");
            Server_Tutorial.T1(1);
            Server_Tutorial.T2(1);
            return tutorial;
        }

        public static int Scores(int scores)
        {
            Logic_Menu.M02c(1);
            Console.WriteLine("Flag Scores");
            return scores;
        }


        public static int Players(int players)
        {
            Logic_Menu.P02a(1);
            return players;

        }

        public static int PP2(int pp2)
        {
            Game_Start.World(1);
            Game_Defaults.C_Startup(1);
            Game_Defaults.M_Startup(1);
            Game_Defaults.P2Orden(1);
            Game_2P.Play(1);
            return pp2;

        }

        public static int PP3(int pp3)
        {
            Console.WriteLine("Esta opción (3 Players) aún no se encuentra disponible, iniciando juego a 2 jugadores. (Presiona cualquier tecla para continuar)");
            Console.ReadKey();
            Game_Defaults.C_Startup(1);
            Game_Defaults.M_Startup(1);
            Game_Defaults.P2Orden(1);
            Game_2P.Play(1);
            return pp3;

        }

        public static int PP4(int pp4)
        {
            Console.WriteLine("Esta opción (2 Players) aún no se encuentra disponible, iniciando juego a 2 jugadores. (Presiona cualquier tecla para continuar)");
            Console.ReadKey();
            Game_Defaults.C_Startup(1);
            Game_Defaults.M_Startup(1);
            Game_Defaults.P2Orden(1);
            Game_2P.Play(1);
            return pp4;

        }



    }
}
