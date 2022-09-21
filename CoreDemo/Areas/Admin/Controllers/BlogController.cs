using Business.Abstract;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcUI.Areas.Admin.Models;

namespace MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Blog List");
                workSheet.Cell(1, 1).Value = "Blog ID";
                workSheet.Cell(1, 2).Value = "Blog Adı";

                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    workSheet.Cell(blogRowCount, 1).Value = item.BlogId;
                    workSheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogList.xlsx");
                }
            }
        }
        public IActionResult BlogListExcel()
        {
            return View();
            
        }
        List<BlogModel> GetBlogList()
        {
            List<BlogModel> blogModels = new List<BlogModel>
            {
                new BlogModel{BlogId=1,BlogName="Software"},
                new BlogModel{BlogId=2,BlogName="Hardware"},
                new BlogModel{BlogId=3,BlogName="C#"},
                new BlogModel{BlogId=4,BlogName="Apple news"},
                
            };
            return blogModels;
        }

        public IActionResult ExportExcelBlogList()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Blog List");
                workSheet.Cell(1, 1).Value = "Blog ID";
                workSheet.Cell(1, 2).Value = "Blog Name";
                int blogRowCount = 2;
                
                foreach (var item in _blogService.GetAll())
                {
                    workSheet.Cell(blogRowCount, 1).Value = item.BlogId;
                    workSheet.Cell(blogRowCount, 2).Value = item.Title;
                    blogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogList.xlsx");
                }
            }
           
        }
        public IActionResult DownloadBlogList()
        {
            return View();
        }
        

        public List<BlogModel> GetAllBlogList()
        {
            List<BlogModel> blogs = new List<BlogModel>();
            _blogService.GetAll().Select(x => new BlogModel
            {
                BlogId=x.BlogId,
                BlogName=x.Title
            }).ToList();
            return blogs;
        }
        


    }

    
}
