using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IMy_GameRepository
    {
        public List<My_Game> GetUsersAllGame(User user);
        public void DeleteUsersGames(My_Game my_Game);
        public void AddUsersGame(My_Game my_Game);
    }
}
