using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_use_v2.Models;
using lib_toan;

namespace web_use_v2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double banKinh)
        {
            TinhToan tinhToan = new TinhToan();
            double dienTich = tinhToan.TinhDienTichHinhTron(banKinh);
            ViewBag.Result = $"Diện tích hình tròn với bán kính {banKinh} là: {dienTich:F2}";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
