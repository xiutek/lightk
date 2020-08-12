using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Reflection;

namespace lightk
{
    class Game_Dice
    {
        public static int CDado = 0;
        public static int MDado = 0;
        public static int YDado = 0;
        public static int GDado = 0;

        public static int CRoll(int croll)
        {

            if (Game_Defaults.P1[5] == 1)
            {
                CDado = Game_Defaults.rnd(1, 12);
            }
            else
            {
                CDado = Game_Defaults.rnd(1, 6);
            }

            {

                Console.Clear();
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(800);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1600);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(2400);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(3200);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> ¡Obtuviste un " + CDado + "!");
                    Console.ResetColor();
                }));

                Console.WriteLine("Presiona cualquier tecla para terminar tu turno.\r\n");
                Console.ReadKey();


                return croll;
            }

        }

        public static int MRoll(int mroll)
        {

            if (Game_Defaults.P2[5] == 1)
            {
                MDado = Game_Defaults.rnd(1, 12);
            }
            else
            {
                MDado = Game_Defaults.rnd(1, 6);
            }

            {

                Console.Clear();
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(800);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1600);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(2400);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(3200);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> ¡Obtuviste un " + MDado + "!");
                    Console.ResetColor();
                }));

                Console.WriteLine("Presiona cualquier tecla para terminar tu turno.\r\n");
                Console.ReadKey();

                return mroll;
            }
        }

        public static int YRoll(int yroll)
        {

            if (Game_Defaults.P3[5] == 1)
            {
                YDado = Game_Defaults.rnd(1, 12);
            }
            else
            {
                YDado = Game_Defaults.rnd(1, 6);
            }

            {

                Console.Clear();
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(800);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1600);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(2400);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(3200);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> ¡Obtuviste un " + YDado + "!");
                    Console.ResetColor();
                }));

                Console.WriteLine("Presiona cualquier tecla para terminar tu turno.\r\n");
                Console.ReadKey();

                return yroll;
            }
        }

        public static int GRoll(int groll)
        {

            if (Game_Defaults.P4[5] == 1)
            {
                GDado = Game_Defaults.rnd(1, 12);
            }
            else
            {
                GDado = Game_Defaults.rnd(1, 6);
            }

            {

                Console.Clear();
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(800);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(1600);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(2400);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> . . .");
                    Console.ResetColor();
                }));
                Task.Factory.StartNew(new Action(() =>
                {
                    Thread.Sleep(3200);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\r\n>> ¡Obtuviste un " + GDado + "!");
                    Console.ResetColor();
                }));

                Console.WriteLine("Presiona cualquier tecla para terminar tu turno.\r\n");
                Console.ReadKey();

                return groll;
            }
        }
    }
}
