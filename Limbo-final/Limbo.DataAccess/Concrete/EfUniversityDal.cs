using Limbo.DataAccess.Abstract;
using Limbo.Entities.Concrete;

namespace Limbo.DataAccess.Concrete
{
    public class EfUniversityDal:EfRepositoryBase<University,LimboDbContext>,IUniversityDal
    {
    }
}
