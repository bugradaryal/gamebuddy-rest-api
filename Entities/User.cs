using System;
using System.Collections.Generic;

namespace Entities
{
    public class User   
    {
        public User()
        {
            this.My_Game = new HashSet<My_Game>();
        }
        public int id { get; set; }
        public string about { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string email { get; set; }

        public ICollection<My_Game> My_Game { get; set; }
    }
}
