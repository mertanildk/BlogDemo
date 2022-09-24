using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace MvcUI.Controllers.ForApi
{

    public class WritersController : Controller
    {


        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44321/api/Writers/getall");
            var json = await response.Content.ReadAsStringAsync();
            var writers = JsonConvert.DeserializeObject<List<Writer>>(json);
            return View(writers);
        }



        public IActionResult AddWriters()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddWriters(Writer writer)
        {
            var httpClient = new HttpClient();
            var jsonWriter = JsonConvert.SerializeObject(writer);
            StringContent content = new StringContent(jsonWriter, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44321/api/Writers/add", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(writer);
        }

        public async Task<IActionResult> EditWriter(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44321/api/Writers/getbyid?writerId=" + id);
            if (response.IsSuccessStatusCode)
            {
                var jsonWriter = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Writer>(jsonWriter);
                return View(values);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditWriter(Writer writer)
        {

            var httpClient = new HttpClient();
            var jsonWriter = JsonConvert.SerializeObject(writer);
            StringContent content = new StringContent(jsonWriter, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44321/api/Writers/update", content);
            if (response.IsSuccessStatusCode)
            {
                return View(writer);
            }
            return RedirectToAction("Index");
        }

    }
}

