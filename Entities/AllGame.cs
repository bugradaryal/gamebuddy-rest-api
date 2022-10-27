using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class AllGame
    {
        public int id { get; set; }
        public string game_name { get; set; }

        public My_Game My_Game { get; set; }
    }
}
