using Core.Entites;
using Entity.Concrete;
using System.ComponentModel.DataAnnotations;


namespace Entities.Concrete
{
    public class MessageWithWriter:IEntity
    {
        [Key]
        public int MessageId { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool Status { get; set; }
        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }

    }
}
