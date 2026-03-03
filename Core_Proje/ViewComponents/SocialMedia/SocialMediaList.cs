using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class SocialMediaList:ViewComponent
{
    public SocialMediaManager socialMediaManager  = new SocialMediaManager(new EfSocialMediaDal());
    public IViewComponentResult Invoke()
    {
        var values = socialMediaManager.TGetList();
        return View(values);
    }
}
