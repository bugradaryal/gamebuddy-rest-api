using Entities;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUser()
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.Users.ToList();
            }
        }
        public User GetUser(string email,string password)
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.Users.Where(x => x.email == email).FirstOrDefault(x => x.password == password);
            }
        }
        public User GetUserById(int id)
        {
            using (var DbContext = new DataDbContext())
            {
                return DbContext.Users.FirstOrDefault(x => x.id == id);
            }
        }
        public void UpdateUser(User user)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.Update(user);
                DbContext.SaveChanges();
            }
        }
        public void DeleteUser(User user)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.Users.Remove(user);
                DbContext.SaveChanges();
            }
        }
        public void CreateUser(User user)
        {
            using (var DbContext = new DataDbContext())
            {
                DbContext.Users.Add(user);
                DbContext.SaveChanges();
            }
        }
    }
}
