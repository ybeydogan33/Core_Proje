using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer;

public class PortfolioManager : IPortfolioService
{
    IPortfolioDal _portfolioDal;

    public PortfolioManager(IPortfolioDal portfolioDal)
    {
        _portfolioDal = portfolioDal;
    }

    public Portfolio GetByID(int id)
    {
        return _portfolioDal.GetById(id);
    }

    public void TAdd(Portfolio t)
    {
        _portfolioDal.Insert(t);
    }

    public void TDelete(Portfolio t)
    {
        _portfolioDal.Delete(t);
    }

    public List<Portfolio> TGetList()
    {
        return _portfolioDal.GetList();
    }

    public void TUpdate(Portfolio t)
    {
        _portfolioDal.Update(t);
    }
}
