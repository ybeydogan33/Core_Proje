using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer;

public class AboutManager : IAboutService
{
    IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public About GetByID(int id)
    {
        return _aboutDal.GetById(id);
    }

    public void TAdd(About t)
    {
        _aboutDal.Insert(t);
    }

    public void TDelete(About t)
    {
        _aboutDal.Delete(t);
    }

    public List<About> TGetList()
    {
        return _aboutDal.GetList();
    }

    public void TUpdate(About t)
    {
        _aboutDal.Update(t);
    }
}
