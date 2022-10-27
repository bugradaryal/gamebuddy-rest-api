using System.Collections.Generic;
using Entities;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Business.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager()
        {
            _userRepository = new UserRepository();
        }
        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }
        public User GetUser(string email, string password)
        {
            return _userRepository.GetUser(email, password);
        }
        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
        public void DeleteUser(User user)
        {
            _userRepository.DeleteUser(user);
        }
        public void CreateUser(User user)
        {
            _userRepository.CreateUser(user);
        }

    }
}
