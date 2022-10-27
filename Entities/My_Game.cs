using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class My_Game
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int game_id { get; set; }


        public User User { get; set; }
        public AllGame AllGame { get; set; }
        public ICollection<GameAccount> GameAccount { get; set; }
    }
}
