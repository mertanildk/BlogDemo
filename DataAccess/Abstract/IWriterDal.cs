using Core.DataAccess;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface IWriterDal:IEntityRepository<Writer>
    {
        Writer GetByWriterMail(string email);
    }
}
