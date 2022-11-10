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
        public List<AllGame> MostAddedTop5Games()
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.AllGames.GroupBy(x => new { x.My_Game.game_id, x.id, x.game_name }).OrderByDescending(y => y.Select(x => x.My_Game.game_id).Count()).Take(5).Select(x=> new AllGame { id = x.Key.id, game_name = x.Key.game_name}).ToList();
            }
        }

    }
}
