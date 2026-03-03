using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: DefaultController
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView(); 
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message p) // Dönüş tipi IActionResult olarak değiştirildi
        {
            MessageManager messageManager = new MessageManager (new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.IsRead = true;
            messageManager.TAdd(p);
            
            // İşlem bittikten sonra çıplak view yerine ana sayfadaki iletişim kısmına yönlendirir
            return Redirect("/#contact"); 
        }
    }
}