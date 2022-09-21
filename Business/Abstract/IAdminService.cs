using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdminService
    {
        void Add(Admin admin);
        void Delete(Admin admin);
        void Update(Admin admin);
        Admin GetById(int id);
        List<Admin> GetAll();

    }
}
