using Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class AllGameRepository : IAllGameRepository
    {
        public List<AllGame> GetAllGames()
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.AllGames.ToList();
            }
        }
        
        public void AddGame(AllGame allGame)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.AllGames.Add(allGame);
                DbContext.SaveChanges();
            }
        }

        public void DeleteGame(AllGame allGame)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.AllGames.Remove(allGame);
                DbContext.SaveChanges();
            }
        }

        public AllGame GetGameById(int id)
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.AllGames.FirstOrDefault(x => x.id == id);
            }
        }
    }
}
