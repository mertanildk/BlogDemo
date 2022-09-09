using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void Add(NewsLetter newsLetter)
        {
            _newsLetterDal.Add(newsLetter);
        }

        public void Delete(NewsLetter newsLetter)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetAll()
        {
           return _newsLetterDal.GetAll();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter newsLetter)
        {
            throw new NotImplementedException();
        }
    }
}
