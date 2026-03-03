using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        // category parametresi URL'den gelecek (Örn: ?category=Web)
        public IActionResult Index(string category)
        {
            // Eğer kategori boş gelirse tüm projeleri, dolu gelirse sadece o kelimeyi içerenleri getirir
            var values = portfolioManager.TGetList();
            
            if (!string.IsNullOrEmpty(category))
            {
                values = values.Where(x => x.Category.ToLower().Contains(category.ToLower())).ToList();
                ViewBag.Title = category + " Projeleri";
            }
            else
            {
                ViewBag.Title = "Tüm Projeler";
            }

            return View(values);
        }
    }
}