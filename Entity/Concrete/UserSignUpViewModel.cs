using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserSignUpViewModel
    {
        public string NameSurname { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler aynı değil")]
        public string ConfirmPassword { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
    }
}
