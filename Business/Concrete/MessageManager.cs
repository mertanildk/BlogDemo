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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message message)
        {
            _messageDal.Add(message);
        }

        public void Delete(Message message)
        {
            _messageDal.Delete(message);
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }


        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }

        public List<Message> GetInboxListByWriter(string receiverEmail)
        {
            return _messageDal.GetAll().Where(x => x.Receiver == receiverEmail).ToList();
        }

        public void Update(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
