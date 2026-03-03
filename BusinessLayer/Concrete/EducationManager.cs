using DataAccessLayer;
using EntityLayer;
using DataAccessLayer.Abstract;
using EntityLayer;
using System.Collections.Generic;
namespace BusinessLayer;

public class EducationManager : IEducationService
{
    IEducationlDal _educationDal;

    public EducationManager(IEducationlDal educationDal)
    {
        _educationDal = educationDal;
    }

    public Education GetByID(int id)
    {
        return _educationDal.GetById(id);
    }

    public void TAdd(Education t)
    {
        _educationDal.Insert(t);
    }

    public void TDelete(Education t)
    {
        _educationDal.Delete(t);
    }

    public List<Education> TGetList()
    {
        return _educationDal.GetList();
    }

    public void TUpdate(Education t)
    {
        _educationDal.Update(t);
    }
}
