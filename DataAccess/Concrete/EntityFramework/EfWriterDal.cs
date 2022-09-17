using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfWriterDal : EfEntityRepositoryBase<Writer, CoreBlogContext>, IWriterDal
    {

        public Writer GetByWriterMail(string email)
        {
            using (CoreBlogContext context = new CoreBlogContext())
            {
                return context.Writers.FirstOrDefault(x => x.Mail == email);
            }
        }
    }
}
