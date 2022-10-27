using Entities;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IUserRepository
    {
        public List<User> GetAllUser();
        public void CreateUser(User user);
        public void DeleteUser(User user);
        public User GetUser(string email, string password);
        public void UpdateUser(User user);
        public User GetUserById(int id);
    }
}
