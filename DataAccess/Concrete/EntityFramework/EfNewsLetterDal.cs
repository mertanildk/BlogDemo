using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfNewsLetterDal:EfEntityRepositoryBase<NewsLetter,CoreBlogContext>,INewsLetterDal
    {
    }
}
