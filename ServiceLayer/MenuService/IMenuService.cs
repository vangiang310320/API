using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.MenuService
{
    public interface IMenuService
    {
        IEnumerable<Menu> GetAllMenu();
        Menu GetMenu(int id);
        void InsertMenu(Menu menu);
        void UpdateMenu(Menu menu);
        void DeleteMenu(int id);
    }
}
