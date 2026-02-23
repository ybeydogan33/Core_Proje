using EntityLayer;
namespace DataAccessLayer;

public interface IAbaoutDal
{
    void Delete();
    void Insert();
    void Update();
    List<About> Getlist();
}
