using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAllGameService
    {
        public List<AllGame> GetAllGames();
        public void AddGame(AllGame allGame);
        public void DeleteGame(AllGame allGame);
        public AllGame GetGameById(int id);
    }
}
