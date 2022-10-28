using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAllGameRepository
    {
        public List<AllGame> GetAllGames();
        public void AddGame(AllGame allGame);
        public void DeleteGame(AllGame allGame);
        public AllGame GetGameById(int id);
    }
}
