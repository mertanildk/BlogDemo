using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(Comment comment);
        void Update(Comment comment);
        Comment GetById(int id);
        List<Comment> GetAll();
        List<Comment> GetAllByBlogId(int blogId);
    }
}
