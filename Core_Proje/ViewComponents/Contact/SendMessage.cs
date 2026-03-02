using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class SendMessage :ViewComponent
{
    MessageManager messageManager = new MessageManager (new EfMessageDal());
    public IViewComponentResult Invoke()
    {
        var values = messageManager.TGetList();
        return View(values);
    }   
}
