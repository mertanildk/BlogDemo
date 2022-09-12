﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public List<Blog> GetBlogListByWriterID(int id)
        {
            return _blogDal.GetAll(x => x.WriterId == id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(x=>x.BlogId==id);
        }

        public List<Blog> IncludeCategory()
        {
            return _blogDal.IncludeCategory();
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
        
    }
}
