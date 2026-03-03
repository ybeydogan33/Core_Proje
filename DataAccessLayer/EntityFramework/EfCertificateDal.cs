using DataAccessLayer.Abstract;
using EntityLayer;

namespace DataAccessLayer.EntityFramework
{
    public class EfCertificateDal : GenericRepository<Certificate>, ICertificateDal
    {
    }
}