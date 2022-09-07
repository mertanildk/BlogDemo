using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }
        public List<Comment> GetAllByBlogId(int blogId)
        {
            return _commentDal.GetAll(x => x.BlogId == blogId);
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x=>x.CommentId==id);
        }

        public void Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
