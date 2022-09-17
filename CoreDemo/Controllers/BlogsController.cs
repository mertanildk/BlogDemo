using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcUI.Controllers
{
    [AllowAnonymous]
    public class BlogsController : Controller
    {
        IBlogService _blogService;
        ICategoryService _categoryService;
        IWriterService _writerService;
        BlogValidation validationRules = new BlogValidation();
        ValidationResult results = new ValidationResult();
        public BlogsController(IBlogService blogService, ICategoryService categoryService, IWriterService writerService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            
            return View(_blogService.IncludeCategory()) ;
        }

        public IActionResult BlogDetails(int id)
        {
            var blog = _blogService.GetById(id);
            return View(blog);
        }
        public IActionResult BlogListByWriter()
        {
            var writerId = _writerService.GetByWriterMail(User.Identity.Name).WriterId;
            var blogOfWriter = _blogService.GetListWithCategoryByWriter(writerId);
            return View(blogOfWriter);
        }

        public IActionResult DeleteBlog(int id)
        {
            var blog = _blogService.GetById(id);
            _blogService.Delete(blog);
            return RedirectToAction("BlogListByWriter","Blogs");
        }

        public IActionResult AddBlogByWriter()
        {
            ViewBag.CategoryList = CategoryTextAndValue();
            return View();
        }
        [HttpPost]
        public IActionResult AddBlogByWriter(Blog blog)
        {
            blog.Status = true;
            blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.WriterId = _writerService.GetByWriterMail(User.Identity.Name).WriterId;
            results = validationRules.Validate(blog);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

            _blogService.Add(blog);
            return RedirectToAction("BlogListByWriter", "Blogs");

        }
        public IActionResult EditBlog(int id)
        {
            ViewBag.CategoryList = CategoryTextAndValue();
            return View(_blogService.GetById(id));
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            blog.WriterId = _writerService.GetByWriterMail(User.Identity.Name).WriterId;
            blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _blogService.Update(blog);
            return RedirectToAction("BlogListByWriter","Blogs");
        }

        







        private List<SelectListItem> CategoryTextAndValue()
        {
            var categoryValues = (from category in _categoryService.GetAll()
                                  select new SelectListItem
                                  {
                                      Text = category.CategoryName,
                                      Value = category.CategoryId.ToString()
                                  }).ToList();
            return categoryValues;
        }
    }
}
