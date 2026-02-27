using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer;

public class ServiceManager : IServiceService
{
    IServiceDal _serviceDal;

    public ServiceManager(IServiceDal serviceDal)
    {
        _serviceDal = serviceDal;
    }

    public Service GetByID(int id)
    {
        return _serviceDal.GetById(id);
    }

    public void TAdd(Service t)
    {
        _serviceDal.Insert(t);
    }

    public void TDelete(Service t)
    {
        _serviceDal.Delete(t);
    }

    public List<Service> TGetList()
    {
        return _serviceDal.GetList();
    }

    public void TUpdate(Service t)
    {
        _serviceDal.Update(t);
    }
}
