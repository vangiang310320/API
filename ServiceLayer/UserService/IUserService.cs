using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.UserService
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUser();
        User GetUser(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
