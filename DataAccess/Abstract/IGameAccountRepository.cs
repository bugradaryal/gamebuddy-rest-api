using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGameAccountRepository
    {
        public List<GameAccount> GetUsersAllAccounts(int user_id);
        public List<GameAccount> GetUsersAccountsByGame(int my_game_id);
        public List<GameAccount> GetSelectedAccount(int id);
        public void DeleteAccount(GameAccount gameAccount);
        public void CreateAccount(GameAccount gameAccount);
        public void UpdateAccount(GameAccount gameAccount);
    }
}
