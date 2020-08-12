using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lightk
{
    class Game_Defaults
    {

        // RANDOM GENERATOR (rnd)
        public static Random random = new Random();
        public static object syncLock = new object();
        public static int rnd(int min, int max)
        {
            lock (syncLock)
            {
                return random.Next(min, max);
            }
        }


        // VARIABLES GLOBALES

        // MAPA
        public static int MAPX = 40;
        public static int MAPY = 30;

        // PLAYERS LOCATION
        public static int P1X = rnd(0, 39);
        public static int P1Y = rnd(0, 29);
        public static int P2X = rnd(0, 39);
        public static int P2Y = rnd(0, 29);
        public static int P3X = rnd(0, 39);
        public static int P3Y = rnd(0, 29);
        public static int P4X = rnd(0, 39);
        public static int P4Y = rnd(0, 29);

        // OBJETOS
        public static int No_Items = 0;
        public static List<int> AIX = new List<int>();
        public static List<int> AIY = new List<int>();
        public static List<int> BIX = new List<int>();
        public static List<int> BIY = new List<int>();
        public static List<int> CIX = new List<int>();
        public static List<int> CIY = new List<int>();
        public static List<int> DIX = new List<int>();
        public static List<int> DIY = new List<int>();

        // PLAYERS DEFAULT START
        public static List<int> P1 = new List<int>();
        public static List<int> P2 = new List<int>();
        public static List<int> P3 = new List<int>();
        public static List<int> P4 = new List<int>();

        // DADOS
        public static int D6 = rnd(0, 5);
        public static int D12 = rnd(0, 11);

        // PLAYERS CUSTOM NAMES
        public static string CYAN = "CYAN";
        public static string MAGENTA = "MAGENTA";
        public static string YELLOW = "YELLOW";
        public static string GREEN = "GREEN";

        // PLAYERS TERRITORY
        public static List<int> P1XT = new List<int>();
        public static List<int> P1YT = new List<int>();
        public static List<int> P2XT = new List<int>();
        public static List<int> P2YT = new List<int>();
        public static List<int> P3XT = new List<int>();
        public static List<int> P3YT = new List<int>();
        public static List<int> P4XT = new List<int>();
        public static List<int> P4YT = new List<int>();

        // PLAYERS FORT
        public static List<int> P1XF = new List<int>();
        public static List<int> P1YF = new List<int>();
        public static List<int> P2XF = new List<int>();
        public static List<int> P2YF = new List<int>();
        public static List<int> P3XF = new List<int>();
        public static List<int> P3YF = new List<int>();
        public static List<int> P4XF = new List<int>();
        public static List<int> P4YF = new List<int>();



        // FUNCIONES

        // "DIASPORA" VERIFICA QUE NINGÚN JUGADOR APAREZCA EN EL MISMO LUGAR
        public static int DiasporaX(int diasporax)
        {
            do
            {
                do
                {
                    do
                    {

                      P2X = rnd(0, 29);
                    } while ((P2X == P1X));

                    P3X = rnd(0, 29);
                } while ((P3X == P2X) | (P3X == P1X));
                P4X = rnd(0, 29);

            } while ((P4X == P3X) | (P4X == P2X) | (P4X == P1X));

            return diasporax;
        }
        public static int DiasporaY(int diasporay)
        {
            do
            {
                do
                {
                    do
                    {

                        P2Y = rnd(0, 29);
                    } while ((P2Y == P1Y));

                    P3Y = rnd(0, 29);
                } while ((P3Y == P2Y) | (P3X == P1Y));
                P4X = rnd(0, 29);

            } while ((P4Y == P3Y) | (P4Y == P2Y) | (P4X == P1Y));

            return diasporay;
        }


        public static int Diaspora(int diaspora)
        {
            DiasporaX(1);
            DiasporaY(1);
            Console.WriteLine("P1:" + P1X + "," + P1Y + ". " + "P2:" + P2X + "," + P2Y + ". " + "P3:" + P3X + "," + P3Y + ". " + "P4:" + P4X + "," + P1Y + ". ");
            return diaspora;
        }

        // CALCULAR OBJETOS, REQUIERE DIÁSPORA

        public static int NItems(int spp)
        {

            // SELECTOR DE NÚMERO DE OBJETOS

            Console.WriteLine("flag NItems");
            bool verificacion = false;
            do
            {
                switch (Logic_Menu.S_PP)
                {
                    case 2:

                        No_Items = 2;
                        verificacion = true;
                        break;

                    case 3:

                        No_Items = 3;
                        verificacion = true;
                        break;

                    case 4:

                        No_Items = 4;
                        verificacion = true;
                        break;
                }


                return spp;
            } while (verificacion == false);
        }


        // REQUIERE NItems, CALCULA LA POSICIÓN DE LOS OBJETOS
        public static int LItems(int igen)

        {
            int contador = 0;
            do
            {
                contador = contador + 1;

                AIX.Add(rnd(0, 39));
                AIY.Add(rnd(0, 29));

                BIX.Add(rnd(0, 39));
                BIY.Add(rnd(0, 29));

                CIX.Add(rnd(0, 39));
                CIY.Add(rnd(0, 29));

                DIX.Add(rnd(0, 39));
                DIY.Add(rnd(0, 29));

            } while (contador < No_Items);

            return igen;
        }

        //Print Items location Cheat
        public static int LItemsCheat(int litemscheat)

        {
            Console.WriteLine("Items Vida, Coordenadas X");
            foreach (int n in AIX)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Items Vida, Coordenadas Y");
            foreach (int n in AIY)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();


            Console.WriteLine("Items Daño, Coordenadas X");
            foreach (int n in BIX)
            {
                Console.WriteLine("ItemX :" + n);
            }
            Console.WriteLine("Items Daño, Coordenadas Y");
            foreach (int n in BIY)
            {
                Console.WriteLine("ItemX :" + n);
            }
            Console.WriteLine();


            Console.WriteLine("Items Rango, Coordenadas X");
            foreach (int n in CIX)
            {
                Console.WriteLine("ItemX :" + n);
            }
            Console.WriteLine("Items Rango, Coordenadas Y");
            foreach (int n in CIY)
            {
                Console.WriteLine("ItemX :" + n);
            }
            Console.WriteLine();


            Console.WriteLine("Items Especiales, Coordenadas X");
            foreach (int n in DIX)
            {
                Console.WriteLine("ItemX :" + n);
            }
            Console.WriteLine("Items Especiales, Coordenadas Y");
            foreach (int n in DIY)
            {
                Console.WriteLine("ItemX :" + n);
            }
            Console.WriteLine();


            return litemscheat;
        }

        // PLAYERS START DATA (Requiere todo lo anterior)
        public static int SPlayers(int splayers)
        {
            //    0            1          2         3           4          5          6          7         8
            //LOCACION X | LOCACION Y | VIDA    | DAÑO     | RANGO    | ESPECIAL | TURNO    | ACTIVO  | GAMEOVER  |  
            P1.Add(P1X); P1.Add(P1Y); P1.Add(2); P1.Add(1); P1.Add(1); P1.Add(0); P1.Add(0); P1.Add(1); P1.Add(1);
            P2.Add(P2X); P2.Add(P2Y); P2.Add(2); P2.Add(1); P2.Add(1); P2.Add(0); P2.Add(0); P2.Add(1); P2.Add(1);
            P3.Add(P3X); P3.Add(P3Y); P3.Add(2); P3.Add(1); P3.Add(1); P3.Add(0); P3.Add(0); P3.Add(1); P3.Add(1);
            P4.Add(P4X); P4.Add(P4Y); P4.Add(2); P4.Add(1); P4.Add(1); P4.Add(0); P4.Add(0); P4.Add(1); P4.Add(1);

            return splayers;
        }

        // DISPLAY PLAYER START DATA

        public static int DPlayers(int dplayers)

        {

            Console.WriteLine("Player 1: Cyan\r\nUbicación Inicial: " + P1[0] + "x - " + P1[1] + "y\r\nVida: " + P1[2] + " | Daño: " + P1[3] + " | Rango: " + P1[4] + " | Especial: " + P1[5]);
            Console.WriteLine();
            Console.WriteLine("Player 2: Yellow\r\nUbicación Inicial: " + P2[0] + "x - " + P2[1] + "y\r\nVida: " + P2[2] + " | Daño: " + P2[3] + " | Rango: " + P2[4] + " | Especial: " + P2[5]);
            Console.WriteLine();
            Console.WriteLine("Player 3: Magenta\r\nUbicación Inicial: " + P3[0] + "x - " + P3[1] + "y\r\nVida: " + P3[2] + " | Daño: " + P3[3] + " | Rango: " + P3[4] + " | Especial: " + P3[5]);
            Console.WriteLine();
            Console.WriteLine("Player 4: Green\r\nUbicación Inicial: " + P4[0] + "x - " + P4[1] + "y\r\nVida: " + P4[2] + " | Daño: " + P4[3] + " | Rango: " + P4[4] + " | Especial: " + P4[5]);

            return dplayers;
        }

        // CYAN STARTUP

        public static int C_Startup(int cstartup)

        {
            ACSII.CYANSa(1);
            bool verificador = false;
            bool verificador2 = false;

            do
            {
                User_Imput.UIk(1);
                switch (User_Imput.UIKey)
                {

                    case "e":
                        Console.WriteLine("Ok!");
                        ACSII.CYANSb(1); ;
                        User_Imput.UIt(1);
                        CYAN = User_Imput.UIString;
                        ACSII.CYANSc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.CRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);
                        verificador = true;
                        break;

                    case "x":
                        Console.WriteLine("¡Ok!");
                        ACSII.CYANSc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.CRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);

                        verificador = true;
                        break;


                    default:
                        Console.WriteLine("No es válido, intenta de nuevo");
                        verificador = false;
                        break;
                }

            } while (verificador == false);


            return cstartup;
        }

        // MAGENTA STARTUP

        public static int M_Startup(int mstartup)

        {
            ACSII.MAGENTASa(1);
            bool verificador = false;
            bool verificador2 = false;

            do
            {
                User_Imput.UIk(1);
                switch (User_Imput.UIKey)
                {

                    case "e":
                        Console.WriteLine("Ok!");
                        ACSII.MAGENTASb(1); ;
                        User_Imput.UIt(1);
                        MAGENTA = User_Imput.UIString;
                        ACSII.MAGENTASc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.MRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);
                        verificador = true;
                        break;

                    case "x":
                        Console.WriteLine("¡Ok!");
                        ACSII.MAGENTASc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.MRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);

                        verificador = true;
                        break;


                    default:
                        Console.WriteLine("No es válido, intenta de nuevo");
                        verificador = false;
                        break;
                }

            } while (verificador == false);


            return mstartup;
        }

        // YELLOW STARTUP

        public static int Y_Startup(int yellow)

        {
            ACSII.YELLOWSa(1);
            bool verificador = false;
            bool verificador2 = false;

            do
            {
                User_Imput.UIk(1);
                switch (User_Imput.UIKey)
                {

                    case "e":
                        Console.WriteLine("Ok!");
                        ACSII.YELLOWSb(1); ;
                        User_Imput.UIt(1);
                        YELLOW = User_Imput.UIString;
                        ACSII.YELLOWSc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.YRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);
                        verificador = true;
                        break;

                    case "x":
                        Console.WriteLine("¡Ok!");
                        ACSII.YELLOWSc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.YRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);

                        verificador = true;
                        break;


                    default:
                        Console.WriteLine("No es válido, intenta de nuevo");
                        verificador = false;
                        break;
                }

            } while (verificador == false);


            return yellow;
        }

        // GREEN STARTUP (P4)

        public static int G_Startup(int green)

        {
            ACSII.GREENSa(1);
            bool verificador = false;
            bool verificador2 = false;

            do
            {
                User_Imput.UIk(1);
                switch (User_Imput.UIKey)
                {

                    case "e":
                        Console.WriteLine("Ok!");
                        ACSII.GREENSb(1); ;
                        User_Imput.UIt(1);
                        GREEN = User_Imput.UIString;
                        ACSII.GREENSc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.GRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);
                        verificador = true;
                        break;

                    case "x":
                        Console.WriteLine("¡Ok!");
                        ACSII.GREENSc(1);

                        do
                        {
                            User_Imput.UIk(1);
                            switch (User_Imput.UIKey)
                            {
                                case "e":
                                    Game_Dice.GRoll(1);
                                    verificador2 = true;
                                    break;

                                default:
                                    Console.WriteLine("No es válido, intenta de nuevo");
                                    verificador2 = false;
                                    break;
                            }

                        } while (verificador2 == false);

                        verificador = true;
                        break;


                    default:
                        Console.WriteLine("No es válido, intenta de nuevo");
                        verificador = false;
                        break;
                }

            } while (verificador == false);


            return green;
        }


        // SELECOR DE TURNOS

        // 2 PLAYERS 
        public static int P2Orden(int p2orden)

        {

            if (Game_Dice.CDado > Game_Dice.MDado)
            {
                P1[6] = 1;
                P2[6] = 2;
            }
            else
            {
                P1[6] = 2;
                P2[6] = 1;
            }
            //Console.WriteLine();
            //Console.WriteLine("Flag P2Orden. " + Game_Dice.CDado + " , " + Game_Dice.MDado + " || P1 TURNO " + P1[6] + " , P2 TURNO " + P2[6]);
            //Console.ReadKey();

            return p2orden;
        }

        // 3 PLAYERS

        //public static bool ver1;
        //public static bool ver2;
        //public static bool ver3;
        public static int ostatus;
        //1=CMY, 2=CYM, 3=MCY, 4=MYC, 5=YCM, 6=YMC

        public static int P3Orden(int p3o)


        {

            //FALSE= C > M ; TRUE M > C
            bool ver1 = (Game_Dice.MDado > Game_Dice.CDado);

            //FALSE= C > Y ; TRUE Y > C
            bool ver2 = (Game_Dice.YDado > Game_Dice.CDado);

            //FALSE= Y > M ; TRUE M > Y
            bool ver3 = (Game_Dice.MDado > Game_Dice.YDado);

            if ((ver1 == false) & (ver2 == false))
            {
                //1=CMY
                ostatus = 1;
                P1[6] = 1;
                P2[6] = 2;
                P3[6] = 3;
            }

            if ((ver2 == false) & (ver3 == false))
            {
                //2=CYM
                ostatus = 2;
                P1[6] = 1;
                P2[6] = 3;
                P3[6] = 2;
            }

            if ((ver1 == true) & (ver2 == false))
            {
                //3=MCY
                ostatus = 3;
                P1[6] = 2;
                P2[6] = 1;
                P3[6] = 3;
            }

            if ((ver3 == true) & (ver2 == true))
            {
                //4=MYC
                ostatus = 4;
                P1[6] = 3;
                P2[6] = 1;
                P3[6] = 2;
            }

            if ((ver1 == false) & (ver2 == true))
            {
                //5=YCM
                ostatus = 5;
                P1[6] = 2;
                P2[6] = 3;
                P3[6] = 1;
            }

            if ((ver3 == false) & (ver1 == true))
            {
                //5=YMC
                ostatus = 5;
                P1[6] = 3;
                P2[6] = 2;
                P3[6] = 1;
            }
            Console.WriteLine();
            Console.WriteLine("Flag P2Orden. " + Game_Dice.CDado + " , " + Game_Dice.MDado + " , " + Game_Dice.YDado+ " || P1 TURNO " + P1[6] + " , P2 TURNO " + P2[6]+" , P3 TURNO "+P3[6]);
            Console.ReadKey();




            return p3o;
        }



    }
}
