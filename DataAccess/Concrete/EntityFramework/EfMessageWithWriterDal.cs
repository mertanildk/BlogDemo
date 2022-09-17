using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMessageWithWriterDal : EfEntityRepositoryBase<MessageWithWriter, CoreBlogContext>, IMessageWithWriterDal
    {
        public List<MessageWithWriter> GetListWithMessageByWriter(int writerId)
        {
            using (CoreBlogContext context = new CoreBlogContext())
            {
                return context.MessageWithWriters.Include(x => x.SenderUser).Where(c => c.ReceiverId == writerId).ToList();
            }
        }
    }
}
