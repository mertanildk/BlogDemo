using Core.Entites;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Writer : IEntity
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public List<Blog> Blogs { get; set; }
        public virtual ICollection<MessageWithWriter> WriterSender { get; set; }
        public virtual ICollection<MessageWithWriter> WriterReceiver { get; set; }

    }
}
