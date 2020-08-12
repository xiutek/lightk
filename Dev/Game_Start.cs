using System;
using System.Collections.Generic;
using System.Text;

namespace lightk
{
    class Game_Start
    {
        public static int World(int world)
        {
            Game_Defaults.Diaspora(1);
            Game_Defaults.NItems(1);
            Game_Defaults.LItems(1);
            Game_Defaults.LItemsCheat(1);
            Game_Defaults.SPlayers(1);
            Game_Defaults.DPlayers(1);
            return world;
        }
    }
}
