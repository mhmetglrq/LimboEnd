using System.Linq.Expressions;
using Limbo.Business.Abstract;
using Limbo.DataAccess.Abstract;
using Limbo.Entities.Concrete;

namespace Limbo.Business.Concrete
{
    public class UniversityManager:IUniversityService
    {
        IUniversityDal _universityDal;

        public UniversityManager(IUniversityDal universityDal)
        {
            _universityDal = universityDal;
        }

        public List<University> GetAll(Expression<Func<University, bool>> filter = null)
        {
            return _universityDal.GetAll(filter);
        }

        public University Get(Expression<Func<University, bool>> filter)
        {
            return _universityDal.Get(filter);
        }

        public void Add(University entity)
        {
            _universityDal.Add(entity);
        }

        public void Update(University entity)
        {
            _universityDal.Update(entity);
        }

        public void Delete(University entity)
        {
            _universityDal.Delete(entity);
        }
    }
}
