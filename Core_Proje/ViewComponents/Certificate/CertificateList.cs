using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class CertificateList:ViewComponent
{
    public CertificateManager certificateManager = new CertificateManager(new EfCertificateDal());
    public IViewComponentResult Invoke()
    {
        var values = certificateManager.TGetList();
        return View(values);
    }
}
