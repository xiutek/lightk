using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;

namespace lightk
{
    class Game_Function
    {

        // DOMINIO VERDADERO DE PLAYERS
        public static int P1TMinX = 0;
        public static int P1TMaxX = 0;
        public static int P1TMinY = 0;
        public static int P1TMaxY = 0;
        public static int P2TMinX = 0;
        public static int P2TMaxX = 0;
        public static int P2TMinY = 0;
        public static int P2TMaxY = 0;
        public static int P3TMinX = 0;
        public static int P3TMaxX = 0;
        public static int P3TMinY = 0;
        public static int P3TMaxY = 0;
        public static int P4TMinX = 0;
        public static int P4TMaxX = 0;
        public static int P4TMinY = 0;
        public static int P4TMaxY = 0;

        // STATUS VERDADERO DE PLAYERS
        public static int SVP12 = Game_Defaults.P1[2];
        public static int SVP13 = Game_Defaults.P1[3];
        public static int SVP14 = Game_Defaults.P1[4];
        public static int SVP22 = Game_Defaults.P2[2];
        public static int SVP23 = Game_Defaults.P2[3];
        public static int SVP24 = Game_Defaults.P2[4];
        public static int SVP32 = Game_Defaults.P3[2];
        public static int SVP33 = Game_Defaults.P3[3];
        public static int SVP34 = Game_Defaults.P3[4];
        public static int SVP42 = Game_Defaults.P4[2];
        public static int SVP43 = Game_Defaults.P4[3];
        public static int SVP44 = Game_Defaults.P4[4];


        // TURNO DE CYAN
        public static int TCyan(int tcyan)
        {

            // STATUS CHECK

            // DESCUBRIR ITEMS A
            bool Aitemxcatch = false;
            bool Aitemdiscovery = false;
            int AIXDiscover = 0;
            int Aiindex = 0;
            foreach (int i in Game_Defaults.AIX)
            {
                foreach (int n in Game_Defaults.P1XT)
                {
                    if (n == i)
                    {
                        Aitemxcatch = true;
                        AIXDiscover = i;
                        if (Aitemxcatch == true)
                        {
                            Aiindex = Game_Defaults.AIX.IndexOf(AIXDiscover);
                            foreach (int m in Game_Defaults.P1YT)
                            {
                                if (Game_Defaults.AIY[Aiindex] == m)
                                {
                                    Aitemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Aitemdiscovery == true)
            {
                Game_Defaults.AIX.RemoveAt(Aiindex);
                Game_Defaults.AIY.RemoveAt(Aiindex);
                Game_Defaults.P1[2] = Game_Defaults.P1[2] + 1;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.CYAN + ", encontraste un punto de vida!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar >>");
                Console.ReadKey();
            }
            // DESCUBRIR ITEMS B
            bool Bitemxcatch = false;
            bool Bitemdiscovery = false;
            int BIXDiscover = 0;
            int Biindex = 0;
            foreach (int i in Game_Defaults.BIX)
            {
                foreach (int n in Game_Defaults.P1XT)
                {
                    if (n == i)
                    {
                        Bitemxcatch = true;
                        BIXDiscover = i;
                        if (Bitemxcatch == true)
                        {
                            Biindex = Game_Defaults.BIX.IndexOf(BIXDiscover);
                            foreach (int m in Game_Defaults.P1YT)
                            {
                                if (Game_Defaults.BIY[Biindex] == m)
                                {
                                    Bitemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Bitemdiscovery == true)
            {
                Game_Defaults.BIX.RemoveAt(Biindex);
                Game_Defaults.BIY.RemoveAt(Biindex);
                Game_Defaults.P1[3] = Game_Defaults.P1[3] + 1;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.CYAN + ", encontraste un punto de daño!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar >>");
                Console.ReadKey();
            }
            // DESCUBRIR ITEMS C
            bool Citemxcatch = false;
            bool Citemdiscovery = false;
            int CIXDiscover = 0;
            int Ciindex = 0;
            foreach (int i in Game_Defaults.CIX)
            {
                foreach (int n in Game_Defaults.P1XT)
                {
                    if (n == i)
                    {
                        Citemxcatch = true;
                        CIXDiscover = i;
                        if (Citemxcatch == true)
                        {
                            Ciindex = Game_Defaults.CIX.IndexOf(CIXDiscover);
                            foreach (int m in Game_Defaults.P1YT)
                            {
                                if (Game_Defaults.CIY[Ciindex] == m)
                                {
                                    Citemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Citemdiscovery == true)
            {
                Game_Defaults.CIX.RemoveAt(Ciindex);
                Game_Defaults.CIY.RemoveAt(Ciindex);
                Game_Defaults.P1[4] = Game_Defaults.P1[4] + 1;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.CYAN + ", encontraste un punto de rango!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar >>");
                Console.ReadKey();
            }
            // DESCUBRIR ITEMS D
            bool Ditemxcatch = false;
            bool Ditemdiscovery = false;
            int DIXDiscover = 0;
            int Diindex = 0;
            foreach (int i in Game_Defaults.DIX)
            {
                foreach (int n in Game_Defaults.P1XT)
                {
                    if (n == i)
                    {
                        Ditemxcatch = true;
                        DIXDiscover = i;
                        if (Ditemxcatch == true)
                        {
                            Diindex = Game_Defaults.DIX.IndexOf(DIXDiscover);
                            foreach (int m in Game_Defaults.P1YT)
                            {
                                if (Game_Defaults.DIY[Diindex] == m)
                                {
                                    Ditemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Ditemdiscovery == true)
            {
                Game_Defaults.DIX.RemoveAt(Diindex);
                Game_Defaults.DIY.RemoveAt(Diindex);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.CYAN + ", encontraste una FICHA ESPECIAL!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Selecciona tu nuevo poder:\r\n\r\n" +
                    ">> (W) Favor Divino (Tiras con doble dado)\r\n" +
                    ">> (A) Armadura Pesada (Duplica tus puntos de vida)\r\n" +
                    ">> (S) Filo Profano (Duplica tus puntos de daño)\r\n" +
                    ">> (D) Conquistador (Duplica tus puntos de rango\r\n");
                bool IDSelection = false;
                do
                {
                    User_Imput.UIk(1);

                    if (User_Imput.UIKey == "w")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P1[5] = 1;
                        IDSelection = true;
                    }
                    if (User_Imput.UIKey == "a")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P1[5] = 2;
                        IDSelection = true;
                    }
                    if (User_Imput.UIKey == "s")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P1[5] = 3;
                        IDSelection = true;
                    }
                    if (User_Imput.UIKey == "d")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P1[5] = 4;
                        IDSelection = true;
                    }

                } while (IDSelection == false);

            }


            // INICIO DE TURNO, SELECCION ACCION
            ACSII.TCyan(1);
            ACSII.SCyan(1);
            bool verificador = false;
            do
            {
                User_Imput.UIk(1);
                switch (User_Imput.UIKey)
                {

                    // ACCION "EXPLORAR"
                    case "w":
                        Console.WriteLine("Ok!");
                        Game_Dice.CRoll(1);
                        int movimientos = Game_Dice.CDado;
                        do
                        {
                            bool actionend = false;
                            do
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\r\n>> " + Game_Defaults.CYAN.ToUpper() + " Puedes moverte hasta " + movimientos + " espacios. <<");
                                Console.ResetColor();
                                Console.WriteLine("* Ubicación actual: " + Game_Defaults.P1[0] + " & " + Game_Defaults.P1[1]);
                                Console.WriteLine("* Utiliza las teclas WASD para realizar tu movimiento, para terminar utiliza E.");
                                Console.ResetColor();

                                User_Imput.UIk(1);
                                switch (User_Imput.UIKey)
                                {
                                    case "w":
                                        int VMoveW = Game_Defaults.P1[1] + 1;
                                        if ((VMoveW < 30) && (VMoveW >= 0))
                                        {
                                            Game_Defaults.P1XT.Add(Game_Defaults.P1[0]);
                                            Game_Defaults.P1YT.Add(Game_Defaults.P1[1]);
                                            Game_Defaults.P1[1] = VMoveW;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "s":
                                        int VMoveS = Game_Defaults.P1[1] - 1;
                                        if ((VMoveS < 30) && (VMoveS >= 0))
                                        {
                                            Game_Defaults.P1XT.Add(Game_Defaults.P1[0]);
                                            Game_Defaults.P1YT.Add(Game_Defaults.P1[1]);
                                            Game_Defaults.P1[1] = VMoveS;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "a":
                                        int VMoveA = Game_Defaults.P1[0] - 1;
                                        if ((VMoveA < 40) && (VMoveA >= 0))
                                        {
                                            Game_Defaults.P1XT.Add(Game_Defaults.P1[0]);
                                            Game_Defaults.P1YT.Add(Game_Defaults.P1[1]);
                                            Game_Defaults.P1[0] = VMoveA;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "d":
                                        int VMoveD = Game_Defaults.P1[0] + 1;
                                        if ((VMoveD < 40) && (VMoveD >= 0))
                                        {
                                            Game_Defaults.P1XT.Add(Game_Defaults.P1[0]);
                                            Game_Defaults.P1YT.Add(Game_Defaults.P1[1]);
                                            Game_Defaults.P1[0] = VMoveD;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "e":
                                        {
                                            Console.WriteLine("Deteniendo la exploración en la ubicación actual.");
                                            movimientos = 0;
                                            actionend = true;
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                            break;
                                        }


                                }


                            } while (actionend == false);

                            movimientos = movimientos - 1;

                        } while (movimientos > 0);

                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\r\n>> " + Game_Defaults.CYAN.ToUpper() + " terminó de explorar. <<");
                        Console.ResetColor();
                        Console.WriteLine("\r\n* Ubicación final: " + Game_Defaults.P1[0] + " & " + Game_Defaults.P1[1] + "\r\n");
                        // FILTRANDO TERRITORIO
                        Game_Defaults.P1XT.Add(Game_Defaults.P1[0]);
                        Game_Defaults.P1YT.Add(Game_Defaults.P1[1]);
                        Game_Defaults.P1XT = Game_Defaults.P1XT.Distinct().ToList();
                        Game_Defaults.P1YT = Game_Defaults.P1YT.Distinct().ToList();
                        Game_Defaults.P1XT = Game_Defaults.P1XT.OrderBy(n => n).ToList();
                        Game_Defaults.P1YT = Game_Defaults.P1YT.OrderBy(n => n).ToList();
                        P1TMaxX = Game_Defaults.P1XT.Max();
                        P1TMinX = Game_Defaults.P1XT.Min();
                        P1TMaxY = Game_Defaults.P1YT.Max();
                        P1TMinY = Game_Defaults.P1YT.Min();

                        // IMPRESION DEL TERRITORIO
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(">> Dominio X: " + P1TMinX + " - " + P1TMaxX);
                        Console.WriteLine(">> Dominio Y: " + P1TMinY + " - " + P1TMaxY);
                        Console.WriteLine();
                        Console.ResetColor();

                        ACSII.SCyan(1);



                        Console.WriteLine("Presiona cualquier tecla para terminar tu turno.");
                        Console.ReadKey();
                        verificador = true;
                        break;

                    case "s":
                        Game_Defaults.P1XT.Add(Game_Defaults.P1[0]);
                        Game_Defaults.P1YT.Add(Game_Defaults.P1[1]);
                        List<int> XTemp = new List<int>();
                        List<int> YTemp = new List<int>();
                        int rango = Game_Defaults.P1[4];
                        Console.WriteLine("Ok!");
                        do
                        {
                            // ACCION "EXPANSION"

                            foreach (int i in Game_Defaults.P1XT)
                            {
                                if (((i + 1) < 40))
                                {
                                    XTemp.Add(i + 1);
                                }
                                if (((i - 1) > 0))
                                {
                                    XTemp.Add(i - 1);
                                }
                                else continue;
                            }
                            foreach (int i in Game_Defaults.P1YT)
                            {
                                if (((i + 1) < 30))
                                {
                                    YTemp.Add(i + 1);
                                }
                                if (((i - 1) > 0))
                                {
                                    YTemp.Add(i - 1);
                                }
                                else continue;
                            }

                            rango = rango - 1;

                        } while (rango > 0);

                        // AGREGANDO TERRITORIO

                        foreach (int i in XTemp)
                        {
                            Game_Defaults.P1XT.Add(i);
                        }
                        foreach (int i in YTemp)
                        {
                            Game_Defaults.P1YT.Add(i);
                        }

                        // FILTRANDO TERRITORIO
                        Game_Defaults.P1XT = Game_Defaults.P1XT.Distinct().ToList();
                        Game_Defaults.P1YT = Game_Defaults.P1YT.Distinct().ToList();
                        Game_Defaults.P1XT = Game_Defaults.P1XT.OrderBy(n => n).ToList();
                        Game_Defaults.P1YT = Game_Defaults.P1YT.OrderBy(n => n).ToList();
                        P1TMaxX = Game_Defaults.P1XT.Max();
                        P1TMinX = Game_Defaults.P1XT.Min();
                        P1TMaxY = Game_Defaults.P1YT.Max();
                        P1TMinY = Game_Defaults.P1YT.Min();

                        // IMPRESION DEL TERRITORIO
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\r\n>> " + Game_Defaults.CYAN.ToUpper() + " terminó su expansión y perdió un turno. <<");
                        Console.ResetColor();
                        Console.WriteLine("\r\n* Ubicación actual: " + Game_Defaults.P1[0] + " & " + Game_Defaults.P1[1]+"\r\n");
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(">> Dominio X: " + P1TMinX + " - " + P1TMaxX);
                        Console.WriteLine(">> Dominio Y: " + P1TMinY + " - " + P1TMaxY);
                        Console.WriteLine();
                        Console.ResetColor();

                        ACSII.SCyan(1);


                        // DESACTIVAR EL TURNO
                        Game_Defaults.P1[7] = 0;

                        Console.WriteLine("Presiona cualquier tecla para terminar tu turno.");
                        Console.ReadKey();
                        verificador = true;
                        break;


                    case "a":
                        // ACCION MEDITACIÓN
                        Game_Defaults.P1[7] = 2;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\r\n>> " + Game_Defaults.CYAN.ToUpper() + " terminó de meditar y duplicó sus stats por un turno. <<");
                        Console.ResetColor();
                        Console.WriteLine("\r\n* Ubicación actual: " + Game_Defaults.P1[0] + " & " + Game_Defaults.P1[1] + "\r\n");
                        Console.WriteLine();
                        ACSII.SCyan(1);
                        Console.WriteLine();
                        Console.WriteLine("Presiona cualquier tecla para terminar tu turno.");
                        Console.ReadKey();

                        verificador = true;
                        break;

                    case "d":
                        Console.WriteLine("Ok!");
                        // ACCION "DUELO"

                        // COMBATE CYAN - MAGENTA
                        bool Kitemxcatch = false;
                        bool MKitemdiscovery = false;
                        foreach (int i in Game_Defaults.P1XT)
                        {
                            foreach (int n in Game_Defaults.P2XT)
                            {
                                if (n == i)
                                {
                                    Kitemxcatch = true;
                                    if (Kitemxcatch == true)
                                    {
                                        foreach (int m in Game_Defaults.P1YT)
                                        {
                                            foreach (int ñ in Game_Defaults.P2YT)
                                            {
                                                if (ñ == m)
                                                {
                                                    MKitemdiscovery = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        bool BSelection = false;
                        if (MKitemdiscovery == true)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Presiona (E) para entrar en combate con "+Game_Defaults.MAGENTA+" o presiona (X) para cancelar.");
                            do
                            {
                                User_Imput.UIk(1);

                                if (User_Imput.UIKey == "e")
                                {
                                    Game_Combate.CM(1);
                                    verificador = true;
                                    BSelection = true;
                                }
                                if (User_Imput.UIKey == "x")
                                {
                                    verificador = true;
                                    BSelection = true;
                                }

                            } while (BSelection == false);
                        }
                        if (MKitemdiscovery == false)
                        {

                            Console.WriteLine("No estás en rango de combate con "+Game_Defaults.MAGENTA+", presiona cualquier tecla para seleccionar otra acción.");
                            verificador = false;
                        }

                        
                        
                        break;
                    default:
                        Console.WriteLine("No es válido, intenta de nuevo");
                        verificador = false;
                        break;
                }

            } while (verificador == false);
            return tcyan;
        }












        // TURNO DE MAGENTA
        public static int TMagenta(int tmagenta)
        {

            // STATUS CHECK

            // DESCUBRIR ITEMS A
            bool Aitemxcatch = false;
            bool Aitemdiscovery = false;
            int AIXDiscover = 0;
            int Aiindex = 0;
            foreach (int i in Game_Defaults.AIX)
            {
                foreach (int n in Game_Defaults.P2XT)
                {
                    if (n == i)
                    {
                        Aitemxcatch = true;
                        AIXDiscover = i;
                        if (Aitemxcatch == true)
                        {
                            Aiindex = Game_Defaults.AIX.IndexOf(AIXDiscover);
                            foreach (int m in Game_Defaults.P2YT)
                            {
                                if (Game_Defaults.AIY[Aiindex] == m)
                                {
                                    Aitemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Aitemdiscovery == true)
            {
                Game_Defaults.AIX.RemoveAt(Aiindex);
                Game_Defaults.AIY.RemoveAt(Aiindex);
                Game_Defaults.P2[2] = Game_Defaults.P2[2] + 1;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.MAGENTA + ", encontraste un punto de vida!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar >>");
                Console.ReadKey();
            }
            // DESCUBRIR ITEMS B
            bool Bitemxcatch = false;
            bool Bitemdiscovery = false;
            int BIXDiscover = 0;
            int Biindex = 0;
            foreach (int i in Game_Defaults.BIX)
            {
                foreach (int n in Game_Defaults.P2XT)
                {
                    if (n == i)
                    {
                        Bitemxcatch = true;
                        BIXDiscover = i;
                        if (Bitemxcatch == true)
                        {
                            Biindex = Game_Defaults.BIX.IndexOf(BIXDiscover);
                            foreach (int m in Game_Defaults.P2YT)
                            {
                                if (Game_Defaults.BIY[Biindex] == m)
                                {
                                    Bitemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Bitemdiscovery == true)
            {
                Game_Defaults.BIX.RemoveAt(Biindex);
                Game_Defaults.BIY.RemoveAt(Biindex);
                Game_Defaults.P2[3] = Game_Defaults.P2[3] + 1;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.MAGENTA + ", encontraste un punto de daño!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar >>");
                Console.ReadKey();
            }
            // DESCUBRIR ITEMS C
            bool Citemxcatch = false;
            bool Citemdiscovery = false;
            int CIXDiscover = 0;
            int Ciindex = 0;
            foreach (int i in Game_Defaults.CIX)
            {
                foreach (int n in Game_Defaults.P2XT)
                {
                    if (n == i)
                    {
                        Citemxcatch = true;
                        CIXDiscover = i;
                        if (Citemxcatch == true)
                        {
                            Ciindex = Game_Defaults.CIX.IndexOf(CIXDiscover);
                            foreach (int m in Game_Defaults.P2YT)
                            {
                                if (Game_Defaults.CIY[Ciindex] == m)
                                {
                                    Citemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Citemdiscovery == true)
            {
                Game_Defaults.CIX.RemoveAt(Ciindex);
                Game_Defaults.CIY.RemoveAt(Ciindex);
                Game_Defaults.P2[4] = Game_Defaults.P2[4] + 1;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.MAGENTA + ", encontraste un punto de rango!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar >>");
                Console.ReadKey();
            }
            // DESCUBRIR ITEMS D
            bool Ditemxcatch = false;
            bool Ditemdiscovery = false;
            int DIXDiscover = 0;
            int Diindex = 0;
            foreach (int i in Game_Defaults.DIX)
            {
                foreach (int n in Game_Defaults.P2XT)
                {
                    if (n == i)
                    {
                        Ditemxcatch = true;
                        DIXDiscover = i;
                        if (Ditemxcatch == true)
                        {
                            Diindex = Game_Defaults.DIX.IndexOf(DIXDiscover);
                            foreach (int m in Game_Defaults.P2YT)
                            {
                                if (Game_Defaults.DIY[Diindex] == m)
                                {
                                    Ditemdiscovery = true;
                                }
                            }
                        }
                    }
                }
            }

            if (Ditemdiscovery == true)
            {
                Game_Defaults.DIX.RemoveAt(Diindex);
                Game_Defaults.DIY.RemoveAt(Diindex);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("¡" + Game_Defaults.MAGENTA + ", encontraste una FICHA ESPECIAL!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Selecciona tu nuevo poder:\r\n\r\n" +
                    ">> (W) Favor Divino (Tiras con doble dado)\r\n" +
                    ">> (A) Armadura Pesada (Duplica tus puntos de vida)\r\n" +
                    ">> (S) Filo Profano (Duplica tus puntos de daño)\r\n" +
                    ">> (D) Conquistador (Duplica tus puntos de rango\r\n");
                bool IDSelection = false;
                do
                {
                    User_Imput.UIk(1);

                    if (User_Imput.UIKey == "w")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P2[5] = 1;
                        IDSelection = true;
                    }
                    if (User_Imput.UIKey == "a")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P2[5] = 2;
                        IDSelection = true;
                    }
                    if (User_Imput.UIKey == "s")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P2[5] = 3;
                        IDSelection = true;
                    }
                    if (User_Imput.UIKey == "d")
                    {
                        Console.WriteLine("Ok!");
                        Game_Defaults.P2[5] = 4;
                        IDSelection = true;
                    }


                } while (IDSelection == false);

            }



            // INICIO DE TURNO, SELECCION ACCION
            ACSII.TMagenta(1);
            ACSII.SMagenta(1);
            bool verificador = false;
            do
            {
                User_Imput.UIk(1);
                switch (User_Imput.UIKey)
                {

                    // ACCION "EXPLORAR"
                    case "w":
                        Console.WriteLine("Ok!");
                        Game_Dice.MRoll(1);
                        int movimientos = Game_Dice.MDado;
                        do
                        {
                            bool actionend = false;
                            do
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\r\n>> " + Game_Defaults.MAGENTA.ToUpper() + " Puedes moverte hasta " + movimientos + " espacios. <<");
                                Console.ResetColor();
                                Console.WriteLine("* Ubicación actual: " + Game_Defaults.P2[0] + " & " + Game_Defaults.P2[1]);
                                Console.WriteLine("* Utiliza las teclas WASD para realizar tu movimiento, para terminar utiliza E.");
                                Console.ResetColor();

                                User_Imput.UIk(1);
                                switch (User_Imput.UIKey)
                                {
                                    case "w":
                                        int VMoveW = Game_Defaults.P2[1] + 1;
                                        if ((VMoveW < 30) && (VMoveW >= 0))
                                        {
                                            Game_Defaults.P2XT.Add(Game_Defaults.P2[0]);
                                            Game_Defaults.P2YT.Add(Game_Defaults.P2[1]);
                                            Game_Defaults.P2[1] = VMoveW;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "s":
                                        int VMoveS = Game_Defaults.P2[1] - 1;
                                        if ((VMoveS < 30) && (VMoveS >= 0))
                                        {
                                            Game_Defaults.P2XT.Add(Game_Defaults.P2[0]);
                                            Game_Defaults.P2YT.Add(Game_Defaults.P2[1]);
                                            Game_Defaults.P2[1] = VMoveS;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "a":
                                        int VMoveA = Game_Defaults.P2[0] - 1;
                                        if ((VMoveA < 40) && (VMoveA >= 0))
                                        {
                                            Game_Defaults.P2XT.Add(Game_Defaults.P2[0]);
                                            Game_Defaults.P2YT.Add(Game_Defaults.P2[1]);
                                            Game_Defaults.P2[0] = VMoveA;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "d":
                                        int VMoveD = Game_Defaults.P2[0] + 1;
                                        if ((VMoveD < 40) && (VMoveD >= 0))
                                        {
                                            Game_Defaults.P2XT.Add(Game_Defaults.P2[0]);
                                            Game_Defaults.P2YT.Add(Game_Defaults.P2[1]);
                                            Game_Defaults.P2[0] = VMoveD;
                                            actionend = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                        }
                                        break;

                                    case "e":
                                        {
                                            Console.WriteLine("Deteniendo la exploración en la ubicación actual.");
                                            movimientos = 0;
                                            actionend = true;
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("No es un movimiento válido, intenta otra vez.");
                                            actionend = false;
                                            break;
                                        }


                                }


                            } while (actionend == false);

                            movimientos = movimientos - 1;

                        } while (movimientos > 0);

                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\r\n>> " + Game_Defaults.MAGENTA.ToUpper() + " terminó de explorar. <<");
                        Console.ResetColor();
                        Console.WriteLine("\r\n* Ubicación final: " + Game_Defaults.P2[0] + " & " + Game_Defaults.P2[1] + "\r\n");
                        // FILTRANDO TERRITORIO
                        Game_Defaults.P2XT.Add(Game_Defaults.P2[0]);
                        Game_Defaults.P2YT.Add(Game_Defaults.P2[1]);
                        Game_Defaults.P2XT = Game_Defaults.P2XT.Distinct().ToList();
                        Game_Defaults.P2YT = Game_Defaults.P2YT.Distinct().ToList();
                        Game_Defaults.P2XT = Game_Defaults.P2XT.OrderBy(n => n).ToList();
                        Game_Defaults.P2YT = Game_Defaults.P2YT.OrderBy(n => n).ToList();
                        P2TMaxX = Game_Defaults.P2XT.Max();
                        P2TMinX = Game_Defaults.P2XT.Min();
                        P2TMaxY = Game_Defaults.P2YT.Max();
                        P2TMinY = Game_Defaults.P2YT.Min();

                        // IMPRESION DEL TERRITORIO
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(">> Dominio X: " + P2TMinX + " - " + P2TMaxX);
                        Console.WriteLine(">> Dominio Y: " + P2TMinY + " - " + P2TMaxY);
                        Console.WriteLine();
                        Console.ResetColor();

                        ACSII.SMagenta(1);



                        Console.WriteLine("Presiona cualquier tecla para terminar tu turno.");
                        Console.ReadKey();
                        verificador = true;
                        break;

                    case "s":
                        Game_Defaults.P2XT.Add(Game_Defaults.P2[0]);
                        Game_Defaults.P2YT.Add(Game_Defaults.P2[1]);
                        List<int> XTemp = new List<int>();
                        List<int> YTemp = new List<int>();
                        int rango = Game_Defaults.P2[4];
                        Console.WriteLine("Ok!");
                        do
                        {
                            // ACCION "EXPANSION"

                            foreach (int i in Game_Defaults.P2XT)
                            {
                                if (((i + 1) < 40))
                                {
                                    XTemp.Add(i + 1);
                                }
                                if (((i - 1) > 0))
                                {
                                    XTemp.Add(i - 1);
                                }
                                else continue;
                            }
                            foreach (int i in Game_Defaults.P2YT)
                            {
                                if (((i + 1) < 30))
                                {
                                    YTemp.Add(i + 1);
                                }
                                if (((i - 1) > 0))
                                {
                                    YTemp.Add(i - 1);
                                }
                                else continue;
                            }

                            rango = rango - 1;

                        } while (rango > 0);

                        // AGREGANDO TERRITORIO

                        foreach (int i in XTemp)
                        {
                            Game_Defaults.P2XT.Add(i);
                        }
                        foreach (int i in YTemp)
                        {
                            Game_Defaults.P2YT.Add(i);
                        }

                        // FILTRANDO TERRITORIO
                        Game_Defaults.P2XT = Game_Defaults.P2XT.Distinct().ToList();
                        Game_Defaults.P2YT = Game_Defaults.P2YT.Distinct().ToList();
                        Game_Defaults.P2XT = Game_Defaults.P2XT.OrderBy(n => n).ToList();
                        Game_Defaults.P2YT = Game_Defaults.P2YT.OrderBy(n => n).ToList();
                        P2TMaxX = Game_Defaults.P2XT.Max();
                        P2TMinX = Game_Defaults.P2XT.Min();
                        P2TMaxY = Game_Defaults.P2YT.Max();
                        P2TMinY = Game_Defaults.P2YT.Min();

                        // IMPRESION DEL TERRITORIO
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\r\n>> " + Game_Defaults.MAGENTA.ToUpper() + " terminó su expansión y perdió un turno. <<");
                        Console.ResetColor();
                        Console.WriteLine("\r\n* Ubicación actual: " + Game_Defaults.P2[0] + " & " + Game_Defaults.P2[1] + "\r\n");
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(">> Dominio X: " + P2TMinX + " - " + P2TMaxX);
                        Console.WriteLine(">> Dominio Y: " + P2TMinY + " - " + P2TMaxY);
                        Console.WriteLine();
                        Console.ResetColor();

                        ACSII.SMagenta(1);


                        // DESACTIVAR EL TURNO
                        Game_Defaults.P2[7] = 0;

                        Console.WriteLine("Presiona cualquier tecla para terminar tu turno.");
                        Console.ReadKey();
                        verificador = true;
                        break;


                    case "a":
                        // ACCION MEDITACIÓN
                        Game_Defaults.P2[7] = 2;
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\r\n>> " + Game_Defaults.MAGENTA.ToUpper() + " terminó de meditar y duplicó sus stats por un turno. <<");
                        Console.ResetColor();
                        Console.WriteLine("\r\n* Ubicación actual: " + Game_Defaults.P2[0] + " & " + Game_Defaults.P2[1] + "\r\n");
                        Console.WriteLine();
                        ACSII.SMagenta(1);
                        Console.WriteLine();
                        Console.WriteLine("Presiona cualquier tecla para terminar tu turno.");
                        Console.ReadKey();

                        verificador = true;
                        break;

                    case "d":
                        Console.WriteLine("Ok!");
                        // ACCION "DUELO"

                        // COMBATE MAGENTA - CYAN
                        bool Kitemxcatch = false;
                        bool MKitemdiscovery = false;
                        foreach (int i in Game_Defaults.P2XT)
                        {
                            foreach (int n in Game_Defaults.P1XT)
                            {
                                if (n == i)
                                {
                                    Kitemxcatch = true;
                                    if (Kitemxcatch == true)
                                    {
                                        foreach (int m in Game_Defaults.P2YT)
                                        {
                                            foreach (int ñ in Game_Defaults.P1YT)
                                            {
                                                if (ñ == m)
                                                {
                                                    MKitemdiscovery = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        bool BSelection = false;
                        if (MKitemdiscovery == true)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Presiona (E) para entrar en combate con " + Game_Defaults.CYAN + " o presiona (X) para cancelar.");
                            do
                            {
                                User_Imput.UIk(1);

                                if (User_Imput.UIKey == "e")
                                {
                                    Game_Combate.MC(1);
                                    verificador = true;
                                    BSelection = true;
                                }
                                if (User_Imput.UIKey == "x")
                                {
                                    verificador = true;
                                    BSelection = true;
                                }

                            } while (BSelection == false);
                        }
                        if (MKitemdiscovery == false)
                        {

                            Console.WriteLine("No estás en rango de combate con " + Game_Defaults.CYAN + ", presiona cualquier tecla para seleccionar otra acción.");
                            verificador = false;
                        }
                        break;


                    default:
                        Console.WriteLine("No es válido, intenta de nuevo");
                        verificador = false;
                        break;
                }

            } while (verificador == false);
            return tmagenta;
        }

        public static int TYellow(int tyellow)
        {

            return tyellow;
        }

        public static int TGreen(int tgreen)
        {

            return tgreen;
        }
    }
}
