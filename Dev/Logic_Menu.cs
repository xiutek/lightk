using System;
using System.Collections.Generic;
using System.Text;

namespace lightk
{
    // Motor Lógico del Menú Welcome
    class Logic_Menu
    {


        public static int SALIR(int salir)
        {
            Console.Clear();
            ACSII.A02(1);
            Console.ReadKey();
            Environment.Exit(0);
            return salir;
        }
        
        
        // PIMRER MENU, CONTINUAR Y SALIR
        public static int M01(int m01)
        {
            bool verificador = false;
            do
            {
                User_Imput.UIk(1);
                switch (User_Imput.UIKey)
                {
                    case "e":
                        Console.WriteLine("Ok!");
                        verificador = true;
                        break;

                    case "x":
                        Console.WriteLine("¡Nos vemos!");
                        SALIR(1);
                        break;

                    default:
                        Console.WriteLine("No es válido, intenta de nuevo");
                        verificador = false;
                        break;
                }

            } while (verificador == false);

            return m01;
        }

        // ESTADO DEL SEGUNDO MENÚ
        //1=PLAY,2=TUTO,3=SCORE;4=M02A,5=M02B,6=M02C. 7=M02D, 8=EXIT
        public static int S_M02 = 0;


        // SEGUNDO MENU, VISTA A (DEFAULT)
        public static int M02a(int m02a)
        {
            bool verificador = false;
            do
            {
                ACSII.M02a(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "e")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 1;
                    verificador = true;
                }
                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 5;
                    verificador = true;
                }
                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 6;
                    verificador = true;
                }


            } while (verificador == false);

            Status_M02(1);

            return m02a;
        }

        // SEGUNDO MENU, VISTA B
        public static int M02b(int m02b)
        {
            bool verificador = false;
            do
            {
                ACSII.M02b(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "e")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 2;
                    verificador = true;
                }

                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 4;
                    verificador = true;
                }


            } while (verificador == false);

            Status_M02(1);

            return m02b;
        }

        // SEGUNDO MENU, VISTA C
        public static int M02c(int m02c)
        {
            bool verificador = false;
            do
            {
                ACSII.M02c(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "e")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 3;
                    verificador = true;
                }
                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 4;
                    verificador = true;
                }
                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 7;
                    verificador = true;
                }


            } while (verificador == false);

            Status_M02(1);

            return m02c;
        }

        // SEGUNDO MENU, VISTA D
        public static int M02d(int m02d)
        {
            bool verificador = false;
            do
            {
                ACSII.M02d(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "e")
                {
                    Console.WriteLine("Ok! Nos vemos!");
                    S_M02 = 8;
                    verificador = true;
                }
                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_M02 = 6;
                    verificador = true;
                }


            } while (verificador == false);

            Status_M02(1);

            return m02d;
        }

        // UNIDAD LOGICA DEL SEGUNDO MENU
        public static int Status_M02(int sm02)
        {
            
            bool verificacion = false;
            do
            {
                switch (S_M02)
                {
                    case 1:
                        Server_Menu.Players(1);
                        verificacion = true;
                        break;
                    case 2:
                        Server_Menu.Tutorial(1);
                        verificacion = true;
                        break;
                    case 3:
                        Server_Menu.Scores(1);
                        verificacion = true;
                        break;
                    case 4:
                        M02a(1);
                        verificacion = true;
                        break;
                    case 5:
                        M02b(1);
                        verificacion = true;
                        break;
                    case 6:
                        M02c(1);
                        verificacion = true;
                        break;
                    case 7:
                        M02d(1);
                        verificacion = true;
                        break;
                    case 8:
                        SALIR(1);
                        verificacion = true;
                        break;
                    default:
                        Console.WriteLine("Algo salió mal");
                        break;
                }
                return sm02;
            } while (verificacion == false);
        }

        // ESTADO DEL MENÚ TUTORIAL
        //1=M02a,2=T2a,3=T2b;4=T2c,5=T2d,6=T2e
        public static int S_T2 = 0;


        // TUTORIAL MENU, VISTA A (DEFAULT)
        public static int T2a(int t2a)
        {
            bool verificador2 = false;
            do
            {
                ACSII.T2a(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_T2 = 1;
                    verificador2 = true;
                }
                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_T2 = 3;
                    verificador2 = true;
                }

            } while (verificador2 == false);

            Status_T2(1);

            return t2a;
        }


        // TUTORIAL MENU, VISTA B
        public static int T2b(int t2b)
        {
            bool verificador2 = false;
            do
            {
                ACSII.T2b(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_T2 = 2;
                    verificador2 = true;
                }
                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_T2 = 4;
                    verificador2 = true;
                }

            } while (verificador2 == false);

            Status_T2(1);

            return t2b;
        }

        // TUTORIAL MENU, VISTA B
        public static int T2c(int t2c)
        {
            bool verificador2 = false;
            do
            {
                ACSII.T2c(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_T2 = 3;
                    verificador2 = true;
                }
                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_T2 = 1;
                    verificador2 = true;
                }

            } while (verificador2 == false);

            Status_T2(1);

            return t2c;
        }

        // TUTORIAL LOGICA DEL SEGUNDO MENU
        public static int Status_T2(int st2)
        {
            bool verificacion = false;

            do
            {
                switch (S_T2)
                {
                    case 1:
                        M02a(1);
                        verificacion = true;
                        break;
                    case 2:
                        T2a(1);
                        verificacion = true;
                        break;
                    case 3:
                        T2b(1);
                        verificacion = true;
                        break;
                    case 4:
                        T2c(1);
                        verificacion = true;
                        break;

                    default:
                        Console.WriteLine("Algo salió mal");
                        break;
                }
                return st2;

            } while (verificacion == false);
        }

        // ESTADO DEL MENU PLAYERS (PP)
        //1=M20a,2=PP2,3=PP3;4=PP4,5=P02a,6=P02b,7=P02c,8=EXIT
        public static int S_PP = 0;


        // PLAYERS MENU, VISTA A (DEFAULT)
        public static int P02a(int p02a)
        {
            bool verificador = false;
            do
            {
                ACSII.P02a(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "e")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 2;
                    verificador = true;
                }
                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 1;
                    verificador = true;
                }
                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 6;
                    verificador = true;
                }


            } while (verificador == false);

            Status_PP(1);

            return p02a;
        }

        // PLAYERS MENU, VISTA B
        public static int P02b(int p02b)
        {
            bool verificador = false;
            do
            {
                ACSII.P02b(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "e")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 3;
                    verificador = true;
                }
                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 5;
                    verificador = true;
                }
                if (User_Imput.UIKey == "d")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 7;
                    verificador = true;
                }


            } while (verificador == false);

            Status_PP(1);

            return p02b;
        }

        // PLAYERS MENU, VISTA B
        public static int P02c(int p02c)
        {
            bool verificador = false;
            do
            {
                ACSII.P02c(1);
                User_Imput.UIk(1);

                if (User_Imput.UIKey == "e")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 4;
                    verificador = true;
                }
                if (User_Imput.UIKey == "a")
                {
                    Console.WriteLine("Ok!");
                    S_PP = 6;
                    verificador = true;
                }


            } while (verificador == false);

            Status_PP(1);

            return p02c;
        }


        // UNIDAD LOGICA DEL SEGUNDO MENU
        public static int Status_PP(int spp)
        {

            bool verificacion = false;
            do
            {
                switch (S_PP)
                {
                    case 1:
                        M02a(1);
                        verificacion = true;
                        break;
                    case 2:
                        Server_Menu.PP2(1);
                        verificacion = true;
                        break;
                    case 3:
                        Server_Menu.PP3(1);
                        verificacion = true;
                        break;
                    case 4:
                        Server_Menu.PP4(1);
                        verificacion = true;
                        break;
                    case 5:
                        P02a(1);
                        verificacion = true;
                        break;
                    case 6:
                        P02b(1);
                        verificacion = true;
                        break;
                    case 7:
                        P02c(1);
                        verificacion = true;
                        break;
                    case 8:
                        SALIR(1);
                        verificacion = true;
                        break;
                    default:
                        Console.WriteLine("Algo salió mal");
                        break;
                }
                return spp;
            } while (verificacion == false);
        }



    }
}
