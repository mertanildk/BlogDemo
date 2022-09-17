using Entities.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageWithWriterService
    {
        void Add(MessageWithWriter messageWithWriter);
        void Delete(MessageWithWriter messageWithWriter);
        void Update(MessageWithWriter messageWithWriter);
        MessageWithWriter GetById(int id);
        List<MessageWithWriter> GetAll();
        List<MessageWithWriter> GetAllByBlogId(int blogId);
        List<MessageWithWriter> GetInboxListByWriter(int receiverId);
        List<MessageWithWriter> GetListWithMessageByWriter(int writerId);

    }
}
