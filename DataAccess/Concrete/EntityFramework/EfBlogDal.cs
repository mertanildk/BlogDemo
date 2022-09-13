using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, CoreBlogContext>, IBlogDal
    {
        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (CoreBlogContext context = new CoreBlogContext())
            {

                return context.Blogs.Include(x => x.Category).Where(c=>c.WriterId==id) .ToList();
            }
        }

        public List<Blog> IncludeCategory()
        {
            using (CoreBlogContext context = new CoreBlogContext())
            {

                return context.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
