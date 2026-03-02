using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class SendMessage :ViewComponent
{
    MessageManager messageManager = new MessageManager (new EfMessageDal());
    [HttpGet]
    public IViewComponentResult Invoke()
    {
        return View();
    }   
    // [HttpPost]
    // public IViewComponentResult Invoke(Message p)
    // {
    //     p.Date= Convert.ToDateTime(DateTime.Now.ToShortDateString());
    //     p.Status=true;
    //     messageManager.TAdd(p);
    //     return View ();
    //}
}
