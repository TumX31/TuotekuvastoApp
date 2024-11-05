using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TuotekuvastoApp.Models;

namespace TuotekuvastoApp.Controllers
{
    // ���������� ��� ��������� �������� � ������� �������� � �������� ���������
    public class HomeController : Controller
    {
        // ����� ��� ����������� ������� �������� (Index)
        public IActionResult Index()
        {
            return View(); // ���������� ������������� Index.cshtml
        }

        // ����� ��� ����������� �������� ���������
        public IActionResult Product()
        {
            // �������� ������ ��������� �� ������ GetProducts
            var products = GetProducts();
            return View(products); // ���������� ������������� Product.cshtml � ����������� ����������
        }

        // ����� ��� ������ ������ �� JSON-����� � �������������� �� � ������ ���������
        private List<Product> GetProducts()
        {
            // ������ ���������� ����� products.json �� ����� wwwroot
            var json = System.IO.File.ReadAllText("wwwroot/products.json");
            // ������������� JSON � ������ �������� Product � ���������� ���
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
}
