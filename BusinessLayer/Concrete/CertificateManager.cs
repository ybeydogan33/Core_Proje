using DataAccessLayer;
using EntityLayer;
using DataAccessLayer.Abstract;
using EntityLayer;
using System.Collections.Generic;
namespace BusinessLayer;

public class CertificateManager : ICertificateService
{
    ICertificateDal _certificateDal;

    public CertificateManager(ICertificateDal certificateDal)
    {
        _certificateDal = certificateDal;
    }

    public Certificate GetByID(int id)
    {
        return _certificateDal.GetById(id);
    }

    public void TAdd(Certificate t)
    {
        _certificateDal.Insert(t);
    }

    public void TDelete(Certificate t)
    {
        _certificateDal.Delete(t);
    }

    public List<Certificate> TGetList()
    {
        return _certificateDal.GetList();
    }

    public void TUpdate(Certificate t)
    {
        _certificateDal.Update(t);
    }
}
