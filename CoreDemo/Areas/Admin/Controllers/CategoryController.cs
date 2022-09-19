using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Entity.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index(int page = 1)
        {
            return View(_categoryService.GetAll().ToPagedList(page, 8));
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            
            category.Status = true;
            CategoryValidation validations = new CategoryValidation();
            ValidationResult results = validations.Validate(category);
            if (results.IsValid)
            {
                _categoryService.Add(category);
                return RedirectToAction("Index", "Category");
            }
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
            
        }

        [HttpGet]
        public IActionResult DeleteCategory(int id)
        { 
            var categoryValue = _categoryService.GetById(id);
            categoryValue.Status = false;
            _categoryService.Update(categoryValue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ActiveCategory(int id)
        {
            var categoryValue = _categoryService.GetById(id);
            categoryValue.Status = true;
            _categoryService.Update(categoryValue);
            return RedirectToAction("Index");
        }


    }
}
