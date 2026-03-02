using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
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
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager (new EfMessageDal());
            p.Date= Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status=true;
            messageManager.TAdd(p);
            return PartialView();
        }

    }
}
