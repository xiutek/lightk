using System;
using System.Collections.Generic;
using System.Text;

namespace lightk
{
    class Game_2P
    {
        public static int Play(int play)
        {
            //Console.WriteLine("CHEAT MOSTRAR ITEMS");
            //Console.WriteLine("Items de vida en: " + Game_Defaults.AIX[0] + "-" + Game_Defaults.AIY[0] + " & " + Game_Defaults.AIX[1] + "-" + Game_Defaults.AIY[1]);
            //Console.WriteLine("Items de daño en: " + Game_Defaults.BIX[0] + "-" + Game_Defaults.BIY[0] + " & " + Game_Defaults.BIX[1] + "-" + Game_Defaults.BIY[1]);
            //Console.WriteLine("Items de rango en: " + Game_Defaults.CIX[0] + "-" + Game_Defaults.CIY[0] + " & " + Game_Defaults.CIX[1] + "-" + Game_Defaults.CIY[1]);
            //Console.WriteLine("Items de especiales en: " + Game_Defaults.DIX[0] + "-" + Game_Defaults.DIY[0] + " & " + Game_Defaults.DIX[1] + "-" + Game_Defaults.DIY[1]);
            //Console.ReadKey();


            // RONDA COMPLETA
            if (Game_Defaults.P1[6] < Game_Defaults.P2[6])
                
            do
            {

                    // WIN CONDITION
                    if (Game_Defaults.P1[2] < 1)
                    {
                        Game_Defaults.P1[8] = 0;
                        Game_2PV.WinCondition(1);
                    }
                    if (Game_Defaults.P2[2] < 1)
                    {
                        Game_Defaults.P2[8] = 0;
                        Game_2PV.WinCondition(1);
                    }

                    // TURNO CYAN
                    if (Game_Defaults.P1[7] > 0)
                    {
                        Game_Function.TCyan(1);
                    }
                    else Game_Defaults.P1[7]= 1;

                    // TURNO MAGENTA
                    if (Game_Defaults.P2[7] > 0)
                    {
                        Game_Function.TMagenta(1);
                    }
                    else Game_Defaults.P2[7] = 1;

            } while ((Game_Defaults.P1[8] == 1) & (Game_Defaults.P2[8] == 1));
            Console.WriteLine("Alguien perdió");



            if (Game_Defaults.P1[6] > Game_Defaults.P2[6])

            do
            {
                    // WIN CONDITION
                    if (Game_Defaults.P1[2] < 1)
                    {
                        Game_Defaults.P1[8] = 0;
                        Game_2PV.WinCondition(1);
                    }
                    if (Game_Defaults.P2[2] < 1)
                    {
                        Game_Defaults.P2[8] = 0;
                        Game_2PV.WinCondition(1);
                    }

                    // TURNO MAGENTA
                    if (Game_Defaults.P2[7] > 0)
                    {
                        Game_Function.TMagenta(1);
                    }
                    else Game_Defaults.P2[7] = 1;

                    // TURNO CYAN
                    if (Game_Defaults.P1[7] > 0)
                    {
                        Game_Function.TCyan(1);
                    }
                    else Game_Defaults.P1[7] = 1;


            } while ((Game_Defaults.P1[8] == 1) & (Game_Defaults.P2[8] == 1));
            Console.WriteLine("Alguien perdió");



            return play;
        }
    }
}
