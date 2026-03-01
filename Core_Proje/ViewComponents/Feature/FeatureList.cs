using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class FeatureList: ViewComponent
{
    FeatureManager featureManager= new FeatureManager(new EfFeatureDal());
    public IViewComponentResult Invoke()
    {
        var values = featureManager.TGetList();
        return View(values);
    }

}
