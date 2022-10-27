using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class GameAccount
    {
        public int id { get; set; }
        public int my_game_id { get; set; }
        public string rank { get; set; }
        public string game_nick { get; set; }
        public string info { get; set; }
        public string server { get; set; }

        public My_Game My_Game { get; set; }
    }
}
