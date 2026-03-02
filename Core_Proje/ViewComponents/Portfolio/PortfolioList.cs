using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje;

public class PortfolioList:ViewComponent
{
    public PortfolioManager portfolioManager  = new PortfolioManager(new EfPortfolioDal());
    public IViewComponentResult Invoke()
    {
        var values = portfolioManager.TGetList();
        return View(values);
    }
}
