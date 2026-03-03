using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class EducationList :ViewComponent
{
    EducationManager educationManager = new EducationManager (new EfEducationDal());
    public IViewComponentResult Invoke()
    {
        var values = educationManager.TGetList();
        return View(values);
    }   
}
