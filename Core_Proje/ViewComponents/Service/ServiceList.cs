using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class ServiceList:ViewComponent
{
    public ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
    public IViewComponentResult Invoke()
    {
        var values = serviceManager.TGetList();
        return View(values);
    }
}
