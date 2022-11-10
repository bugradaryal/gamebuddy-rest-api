using System.Collections.Generic;
using Entities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Business.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Business.Concrete
{
    public class GameAccountManager : IGameAccountService
    {
        private IGameAccountRepository _gameAccountRepository;
        public GameAccountManager()
        {
            _gameAccountRepository = new GameAccountRepository();
        }

        public List<GameAccount> GetUsersAllAccounts(int user_id)
        {
            return _gameAccountRepository.GetUsersAllAccounts(user_id);
        }

        public List<GameAccount> GetUsersAccountsByGame(int my_game_id)
        {
            return _gameAccountRepository.GetUsersAccountsByGame(my_game_id);
        }
        public List<GameAccount> GetSelectedAccount(int id)
        {
            return  _gameAccountRepository.GetSelectedAccount(id);
        }
        public void DeleteAccount(GameAccount gameAccount)
        {
            _gameAccountRepository.DeleteAccount(gameAccount);
        }
        public void CreateAccount(GameAccount gameAccount)
        {
            _gameAccountRepository.CreateAccount(gameAccount);
        }
        public void UpdateAccount(GameAccount gameAccount)
        {
            _gameAccountRepository.UpdateAccount(gameAccount);
        }
    }
}
