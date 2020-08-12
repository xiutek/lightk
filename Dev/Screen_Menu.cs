using System;
using System.Collections.Generic;
using System.Text;


namespace lightk
{
    class Screen_Menu
    {
        public static int WS1(int ws1)
        {

            // MENÚ 1
            ACSII.A01(1);
            ACSII.M01(1);
            Logic_Menu.M01(1);

            // MENÚ 2
            Console.Clear();
            ACSII.M02a(1);
            Logic_Menu.M02a(1);

            return ws1;
        }

    }
}
