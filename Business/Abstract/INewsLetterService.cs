using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewsLetterService
    {
        void Add(NewsLetter newsLetter);
        void Delete(NewsLetter newsLetter);
        void Update(NewsLetter newsLetter);
        NewsLetter GetById(int id);
        List<NewsLetter> GetAll();
    }
}
