using Limbo.DataAccess.Abstract;
using Limbo.Entities.Concrete;

namespace Limbo.DataAccess.Concrete
{
    public class EfDepartmentDal:EfRepositoryBase<Department,LimboDbContext>,IDepartmentDal
    {
    }
}
