using Core.DataAccess;
using Entity.Concrete;


namespace DataAccess.Abstract
{
    public interface IBlogDal:IEntityRepository<Blog>
    {
        List<Blog> IncludeCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}
