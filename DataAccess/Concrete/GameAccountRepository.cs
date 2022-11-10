using Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class GameAccountRepository : IGameAccountRepository
    {
        public List<GameAccount> GetUsersAllAccounts(int user_id)
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.GameAccounts.Where(x => x.My_Game.user_id == user_id).ToList();
            }
        }

        public List<GameAccount> GetUsersAccountsByGame(int my_game_id)
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.GameAccounts.Where(x => x.my_game_id == my_game_id).ToList();
            }
        }

        public List<GameAccount> GetSelectedAccount(int id)
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.GameAccounts.Where(x => x.id == id).ToList();
            }
        }

        public void DeleteAccount(GameAccount gameAccount)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.GameAccounts.Remove(gameAccount);
                DbContext.SaveChanges();
            }
        }

        public void CreateAccount(GameAccount gameAccount)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.GameAccounts.Add(gameAccount);
                DbContext.SaveChanges();
            }
        }

        public void UpdateAccount(GameAccount gameAccount)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.GameAccounts.Update(gameAccount);
                DbContext.SaveChanges();
            }
        }
    }
}
