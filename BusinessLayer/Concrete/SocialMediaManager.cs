using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer;

public class SocialMediaManager : ISocialMediaService
{
    ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public SocialMedia GetByID(int id)
    {
        return _socialMediaDal.GetById(id);
    }

    public void TAdd(SocialMedia t)
    {
        _socialMediaDal.Insert(t);
    }

    public void TDelete(SocialMedia t)
    {
        _socialMediaDal.Delete(t);
    }

    public List<SocialMedia> TGetList()
    {
        return _socialMediaDal.GetList();
    }

    public void TUpdate(SocialMedia t)
    {
        _socialMediaDal.Update(t);
    }
}
