using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer;

public class TestimonialManager : ITestimonialService
{
    ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public Testimonial GetByID(int id)
    {
        return _testimonialDal.GetById(id);
    }

    public void TAdd(Testimonial t)
    {
        _testimonialDal.Insert(t);
    }

    public void TDelete(Testimonial t)
    {
        _testimonialDal.Delete(t);
    }

    public List<Testimonial> TGetList()
    {
        return _testimonialDal.GetList();
    }

    public void TUpdate(Testimonial t)
    {
        _testimonialDal.Update(t);
    }
}
