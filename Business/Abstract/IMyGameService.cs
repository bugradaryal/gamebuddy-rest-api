using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMyGameService
    {
        public List<My_Game> GetUsersAllGame(User user);
        public void DeleteUsersGames(My_Game my_Game);
        public void AddUsersGame(My_Game my_Game);
        public List<AllGame> MostAddedTop5Games();
    }
}
