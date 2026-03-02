using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class TestimonialList: ViewComponent
{
    TestimonialManager testimonialManager= new TestimonialManager(new EfTestimonialDal());
    public IViewComponentResult Invoke()
    {
        var values = testimonialManager.TGetList();
        return View(values);
    }
        
    

}
