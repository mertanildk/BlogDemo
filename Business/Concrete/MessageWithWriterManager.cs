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
    public class MessageWithWriterManager : IMessageWithWriterService
    {
        IMessageWithWriterDal _messageDal;

        public MessageWithWriterManager(IMessageWithWriterDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(MessageWithWriter messageWithWriter)
        {
            throw new NotImplementedException();
        }

        public void Delete(MessageWithWriter messageWithWriter)
        {
            throw new NotImplementedException();
        }

        public List<MessageWithWriter> GetAll()
        {
            return _messageDal.GetAll();
        }

        public List<MessageWithWriter> GetAllByBlogId(int blogId)
        {
            throw new NotImplementedException();
        }

        public MessageWithWriter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MessageWithWriter> GetInboxListByWriter(int receiverId)
        {
            return _messageDal.GetAll(x => x.ReceiverId == receiverId);
        }
        public List<MessageWithWriter> GetListWithMessageByWriter(int writerId)
        {
            return _messageDal.GetListWithMessageByWriter(writerId);
        }

        public void Update(MessageWithWriter messageWithWriter)
        {
            throw new NotImplementedException();
        }
    }
}
