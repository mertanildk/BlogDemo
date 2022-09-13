using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BlogValidation : AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(c => c.Content).MinimumLength(20).WithMessage("Gimme some more words");
            RuleFor(c => c.CreateDate).NotEmpty().WithMessage("Cant Emty");
            RuleFor(c => c.Title).NotEmpty().WithMessage("Cant Emty");
            RuleFor(c => c.Content).NotEmpty().WithMessage("Cant Emty");
        }
    }
}
