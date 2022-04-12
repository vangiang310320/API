using DomainLayer.Models;
using RepositoryLayer.Repository;
using ServiceLayer.CategorySevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> repo;
        public CategoryService(IRepository<Category> repo)
        {
            this.repo = repo;
        }
        public void DeleteCategory(int id)
        {
            Category category = repo.Get(id);
            repo.Remove(category);
            repo.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return repo.GetAll();
        }

        public Category GetCategory(int id)
        {
            return repo.Get(id);
        }

        public void InsertCategory(Category category)
        {
            repo.Insert(category);
        }

        public void UpdateCategory(Category category)
        {
            repo.Update(category);
        }
    }
}
