using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class AboutList :ViewComponent
{
    AboutManager aboutManager = new AboutManager (new EfAboutDal());
    public IViewComponentResult Invoke()
    {
        var values = aboutManager.TGetList();
        return View(values);
    }   
}
