using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class ContactDetails :ViewComponent
{
    ContactManager contactManager = new ContactManager (new EfContactDal());
    public IViewComponentResult Invoke()
    {
        var values = contactManager.TGetList();
        return View(values);
    }   
}
