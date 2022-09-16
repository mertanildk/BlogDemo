using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMessageService
    {
        void Add(Message message);
        void Delete(Message message);
        void Update(Message message);
        Message GetById(int id);
        List<Message> GetAll();
        List<Message> GetInboxListByWriter(string receiverEmail);
    }
}
