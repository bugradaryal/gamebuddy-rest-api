using System.Collections.Generic;
using Entities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Business.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Business.Concrete
{
    public class My_GameManager : IMyGameService
    {
        private IMy_GameRepository _my_GameRepository;
        public My_GameManager()
        {
            _my_GameRepository = new My_GameRepository();
        }
        public List<My_Game> GetUsersAllGame(User user)
        {
            return _my_GameRepository.GetUsersAllGame(user);
        }
        public void DeleteUsersGames(My_Game my_Game)
        {
            _my_GameRepository.DeleteUsersGames(my_Game);
        }
        public void AddUsersGame(My_Game my_Game)
        {
            _my_GameRepository.AddUsersGame(my_Game);
        }
        public List<AllGame> MostAddedTop5Games()
        {
            return _my_GameRepository.MostAddedTop5Games();
        }
    }
}
