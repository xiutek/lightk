using System;
using System.Collections.Generic;
using System.Text;

namespace lightk
{
    class User_Imput
    {
        // CONTRALDOR DEL USER IMPUT

        public static string UIString;
        public static string UIKey;
        public static int UIInt;

        // IMPUT SIMPLE DE STRING
        public static int UIt(int uit)
        {
            UIString = Console.ReadLine().ToLower();
            Console.WriteLine("El usuario escribió: "+UIString);
            return uit;
        }

        // IMPUT SIMPLE DEL MENÚ
        public static int UIk(int uik)
        {
            bool IVUIk = false;
            do
            {
                Console.WriteLine("Selecciona una tecla");
                string mensage = "Selección: ";
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.KeyChar)
                {
                    // INPUT W
                    case ('w'):
                        UIKey = "w";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;
                    case ('W'):
                        UIKey = "w";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;

                    // INPUT A
                    case 'a':
                        UIKey = "a";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;
                    case 'A':
                        UIKey = "a";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;

                    // INPUT S
                    case 's':
                        UIKey = "s";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;
                    case 'S':
                        UIKey = "s";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;

                    // INPUT D
                    case 'd':
                        UIKey = "d";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;
                    case 'D':
                        UIKey = "d";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;

                    // INPUT E
                    case 'e':
                        UIKey = "e";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;
                    case 'E':
                        UIKey = "e";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;

                    // INPUT X
                    case 'x':
                        UIKey = "x";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;
                    case 'X':
                        UIKey = "x";
                        IVUIk = true;
                        Console.WriteLine(mensage + UIKey);
                        break;

                    // DEFAULT
                    default:
                        Console.WriteLine("No es válido, intenta de nuevo.");
                        break;
                }
            } while (IVUIk == false);
            return uik;
        }

        // IMPUT SIMPLE DE NÚMERO
        public static int UIi(int uii)
        {
            bool isNum;
            string IVUIInt;
            do
            {
                int Ver;
                IVUIInt = Console.ReadLine();
                isNum = int.TryParse(IVUIInt.ToString(), out Ver);
                if (!isNum) Console.WriteLine("No es válido, intenta de nuevo.");

            }
            while (!isNum);

            UIInt = Convert.ToInt32(IVUIInt);
            Console.WriteLine("Selección: "+UIInt);

            return uii;
        }

    }
}
