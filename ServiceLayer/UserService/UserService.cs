using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.UserService
{
    public class UserService : IUserService
    {
        private IRepository<User> repo;
        public UserService(IRepository<User> repo)
        {
            this.repo = repo;
        }
        public void DeleteUser(int id)
        {
            User user = repo.Get(id);
            repo.Remove(user);
            repo.SaveChanges();
        }

        public IEnumerable<User> GetAllUser()
        {
            return repo.GetAll();
        }

        public User GetUser(int id)
        {
            return repo.Get(id);
        }

        public void InsertUser(User user)
        {
            repo.Insert(user);
        }

        public void UpdateUser(User user)
        {
            repo.Update(user);
        }
    }
}
