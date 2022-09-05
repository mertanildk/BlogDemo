using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class About
    {
        public int AboutId { get; set; }
        public string FirstDetails { get; set; }
        public string SecondDetails { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage{ get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
