using System.Collections.Generic;
using Entities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Business.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Business.Concrete
{
    public class AllGameManager : IAllGameService
    {
        private IAllGameRepository _allGameRepository;
        public AllGameManager()
        {
            _allGameRepository = new AllGameRepository();
        }

        public List<AllGame> GetAllGames()
        {
            return _allGameRepository.GetAllGames();
        }
        public void AddGame(AllGame allGame)
        {
            _allGameRepository.AddGame(allGame);
        }
        public void DeleteGame(AllGame allGame)
        {
            _allGameRepository.DeleteGame(allGame);
        }
        public AllGame GetGameById(int id)
        {
            return _allGameRepository.GetGameById(id);
        }
    }
}
