using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.SlideService
{
    public class SlideService : ISlideService
    {
        private IRepository<Slide> repo;
        public SlideService(IRepository<Slide> repo)
        {
            this.repo = repo;
        }
        public void DeleteSlide(int id)
        {
            Slide slide = repo.Get(id);
            repo.Remove(slide);
            repo.SaveChanges();
        }

        public IEnumerable<Slide> GetAllSlide()
        {
            return repo.GetAll();
        }

        public Slide GetSlide(int id)
        {
            return repo.Get(id);
        }

        public void InsertSlide(Slide slide)
        {
            repo.Insert(slide);
        }

        public void UpdateSlide(Slide slide)
        {
            repo.Update(slide);
        }
    }
}
