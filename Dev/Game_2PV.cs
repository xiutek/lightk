using System;
using System.Collections.Generic;
using System.Text;

namespace lightk
{
    class Game_2PV
    {
        public static int WinCondition(int wcon)

        {

            if (Game_Defaults.P1[8] == 0)
            {

                int mscore = ((((Game_Function.P2TMaxX-Game_Function.P2TMinX)*(Game_Function.P2TMaxY - Game_Function.P2TMinY))/120)*(Game_Defaults.P2[2]+ Game_Defaults.P2[3]+ Game_Defaults.P2[4]))*10;
                int cscore = ((((Game_Function.P1TMaxX-Game_Function.P1TMinX)*(Game_Function.P1TMaxY - Game_Function.P1TMinY))/120)*(Game_Defaults.P1[2]+ Game_Defaults.P1[3] + Game_Defaults.P1[4]))*10;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("¡"+Game_Defaults.MAGENTA+" ha ganado la partida! ¡Felicidades! \t Puntuación "+Game_Defaults.MAGENTA+ ": " + mscore + "\t Puntuación " + Game_Defaults.CYAN + ": " + cscore+" ");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Magenta;
                ACSII.Win(1);
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Logic_Menu.SALIR(1);
            }

            if (Game_Defaults.P2[8] == 0)
            {

                int mscore = ((((Game_Function.P2TMaxX - Game_Function.P2TMinX) * (Game_Function.P2TMaxY - Game_Function.P2TMinY)) / 120) * (Game_Defaults.P2[2] + Game_Defaults.P2[3] + Game_Defaults.P2[4])) * 10;
                int cscore = ((((Game_Function.P1TMaxX - Game_Function.P1TMinX) * (Game_Function.P1TMaxY - Game_Function.P1TMinY)) / 120) * (Game_Defaults.P1[2] + Game_Defaults.P1[3] + Game_Defaults.P1[4])) * 10;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("¡" + Game_Defaults.CYAN + " ha ganado la partida! ¡Felicidades! \t Puntuación " + Game_Defaults.CYAN + ": " + cscore + "\t Puntuación " + Game_Defaults.MAGENTA + ": " + mscore + " ");
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Cyan;
                ACSII.Win(1);
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Logic_Menu.SALIR(1);
            }

            return wcon;
        }

    }
}
