using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class SkillList: ViewComponent
{
    SkillManager skillManager= new SkillManager(new EfSkillDal());
    public IViewComponentResult Invoke()
    {
        var values = skillManager.TGetList();
        return View(values);
    }
        
    

}
