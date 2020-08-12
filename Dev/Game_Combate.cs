using System;
using System.Collections.Generic;
using System.Text;

namespace lightk
{
    class Game_Combate
    {
        public static int CM(int cm)
        {
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("¡"+Game_Defaults.CYAN+" se enfrentará a "+Game_Defaults.MAGENTA+"!");
            ACSII.Battle(1);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para iniciar el combate.");
            Console.ReadKey();
            Game_Dice.CRoll(1);
            Game_Dice.MRoll(1);
            if (Game_Dice.CDado > Game_Dice.MDado)
            {
                int idmg = 0;
                int lbonus = Game_Function.SVP22 - Game_Defaults.P2[2];
                int dmg = Game_Function.SVP13;
                if (dmg > lbonus)
                {
                    int tdmg = lbonus - dmg;
                    Game_Defaults.P2[2] = Game_Defaults.P2[2] + tdmg;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    ACSII.TDmg(1);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("¡" + Game_Defaults.MAGENTA + " recibió +"+dmg+" puntos de daño verdadero!");
                    idmg = dmg;
                    Console.ResetColor();
                }
                if (dmg <= lbonus)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    ACSII.Armor(1);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("¡La armadura de "+Game_Defaults.MAGENTA+" evitó el daño verdadero y no perderá vida!");
                    Console.ResetColor();
                }

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.CYAN + " DERROTÓ a " + Game_Defaults.MAGENTA + "!, "+Game_Defaults.MAGENTA+" perdió "+ idmg + " puntos de vida.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para salir del combate.");
                Console.ReadKey();

            }
            if (Game_Dice.CDado <= Game_Dice.MDado)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                ACSII.Armor(1);
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("¡" + Game_Defaults.MAGENTA + " DERROTÓ a " + Game_Defaults.CYAN + "!, " + Game_Defaults.MAGENTA + " evitó todo daño.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para salir del combate.");
                Console.ReadKey();

            }

            return cm;
        }

        public static int MC(int mc)
        {

            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("¡" + Game_Defaults.MAGENTA + " se enfrentará a " + Game_Defaults.CYAN + "!");
            ACSII.Battle(1);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para iniciar el combate.");
            Console.ReadKey();
            Game_Dice.MRoll(1);
            Game_Dice.CRoll(1);
            if (Game_Dice.MDado > Game_Dice.CDado)
            {
                int idmg = 0;
                int lbonus = Game_Function.SVP12 - Game_Defaults.P1[2];
                int dmg = Game_Function.SVP23;
                if (dmg > lbonus)
                {
                    int tdmg = lbonus - dmg;
                    Game_Defaults.P1[2] = Game_Defaults.P1[2] + tdmg;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    ACSII.TDmg(1);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("¡" + Game_Defaults.CYAN + " recibió "+dmg+" puntos de daño verdadero!");
                    idmg = dmg;
                    Console.ResetColor();
                }
                if (dmg <= lbonus)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    ACSII.Armor(1);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("¡La armadura de " + Game_Defaults.CYAN + " evitó el daño verdadero y no perderá vida!");
                    Console.ResetColor();
                }

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.MAGENTA + " DERROTÓ a " + Game_Defaults.CYAN + "!, " + Game_Defaults.CYAN + " perdió " + idmg + " puntos de vida.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para salir del combate.");
                Console.ReadKey();

            }
            if (Game_Dice.MDado <= Game_Dice.CDado)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                ACSII.Armor(1);
                Console.ResetColor();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("¡" + Game_Defaults.CYAN + " DERROTÓ a " + Game_Defaults.MAGENTA + "!, " + Game_Defaults.CYAN + " evitó todo daño.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para salir del combate.");
                Console.ReadKey();
            }

            return mc;
        }
    }
}
