using Entity.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WriterValidation:AbstractValidator<Writer>,IValidator
    {
        public WriterValidation()
        {
            //RuleFor(writer => writer.Password).NotEmpty().MinimumLength(3).WithMessage("Boş geçilemez");
            ////RuleFor(writer => writer.WriterName).NotEmpty().WithMessage("Boş geçilemez");
            //RuleFor(writer => writer.Mail).NotEmpty().WithMessage("Boş geçilemez");
            //RuleFor(writer => writer.Password).Matches(@"((?=.\d)(?=.[a-z])(?=.*[A-Z]).{6,})");
            //RuleFor(x => x.Password).Matches("^(?=.?[A-Z])(?=.?[a-z])(?=.?[0-9])(?=.?[#?!@$%^&*-]).{8,}$")
            //.WithMessage("Password must contain at least 8 characters, At least one uppercase letter, At least one lowercase letter, At least one number and At least one special character.");
        }

    }
}
