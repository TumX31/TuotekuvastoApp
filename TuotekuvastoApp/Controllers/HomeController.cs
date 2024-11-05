using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TuotekuvastoApp.Models;

namespace TuotekuvastoApp.Controllers
{
    // Контроллер для обработки запросов к главной странице и странице продуктов
    public class HomeController : Controller
    {
        // Метод для отображения главной страницы (Index)
        public IActionResult Index()
        {
            return View(); // Возвращает представление Index.cshtml
        }

        // Метод для отображения страницы продуктов
        public IActionResult Product()
        {
            // Получаем список продуктов из метода GetProducts
            var products = GetProducts();
            return View(products); // Возвращает представление Product.cshtml с переданными продуктами
        }

        // Метод для чтения данных из JSON-файла и десериализации их в список продуктов
        private List<Product> GetProducts()
        {
            // Читаем содержимое файла products.json из папки wwwroot
            var json = System.IO.File.ReadAllText("wwwroot/products.json");
            // Десериализуем JSON в список объектов Product и возвращаем его
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}
