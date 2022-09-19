using Entity.Concrete;
using FluentValidation;


namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            //RuleFor(c => c.CategoryName).NotEmpty().WithMessage("bos");
            //RuleFor(c => c.Description).NotEmpty().WithMessage("bos"); ;
            //RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("3"); ;
            //RuleFor(c => c.Description).MinimumLength(3).WithMessage("At least 3 character");
        }
    }
}
