using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace lightk
{
    class TEST
    {
        public static int Exe(int exe)
        {
            string[] grupo = { "Chi", "Chenol" };
            string grupoprint = (grupo[0]+" , "+grupo[1]);
            Console.WriteLine();
            Console.WriteLine("Escribe dos palabras");
            grupo[0] = Console.ReadLine();
            grupo[1] = Console.ReadLine();
            Console.WriteLine("El nuevo grupo es: "+grupoprint);

            return exe;
        }


    }
}