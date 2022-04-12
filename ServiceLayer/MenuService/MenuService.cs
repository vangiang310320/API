using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.MenuService
{
    public class MenuService : IMenuService
    {
        private IRepository<Menu> repo;
        public MenuService(IRepository<Menu> repo)
        {
            this.repo = repo;
        }
        public void DeleteMenu(int id)
        {
            Menu menu = repo.Get(id);
            repo.Remove(menu);
            repo.SaveChanges();
        }

        public IEnumerable<Menu> GetAllMenu()
        {
            return repo.GetAll();
        }

        public Menu GetMenu(int id)
        {
            return repo.Get(id);
        }

        public void InsertMenu(Menu menu)
        {
            repo.Insert(menu);
        }

        public void UpdateMenu(Menu menu)
        {
            repo.Update(menu);
        }
    }
}
