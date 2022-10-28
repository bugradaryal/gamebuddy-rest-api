using Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class My_GameRepository : IMy_GameRepository
    {
        public List<My_Game> GetUsersAllGame(User user)
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.My_Games.Where(x=>x.user_id == user.id).ToList();
            }
        }
        public void DeleteUsersGames(My_Game my_Game)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.My_Games.Remove(my_Game); 
                DbContext.SaveChanges();
            }
        }
        public void AddUsersGame(My_Game my_Game)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.My_Games.Add(my_Game);
                DbContext.SaveChanges();
            }
        }
    }
}
