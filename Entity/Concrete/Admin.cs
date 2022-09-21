using Core.Entites;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Admin:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImageURL { get; set; }
        public string Role { get; set; }
    }
}
