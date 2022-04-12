using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.SlideService
{
    public interface ISlideService
    {
        IEnumerable<Slide> GetAllSlide();
        Slide GetSlide(int id);
        void InsertSlide(Slide slide);
        void UpdateSlide(Slide slide);
        void DeleteSlide(int id);
    }
}
