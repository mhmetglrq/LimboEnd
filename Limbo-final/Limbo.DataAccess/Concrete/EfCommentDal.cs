using Limbo.DataAccess.Abstract;
using Limbo.Entities.Concrete;

namespace Limbo.DataAccess.Concrete
{
    public class EfCommentDal:EfRepositoryBase<Comment,LimboDbContext>,ICommentDal
    {
    }
}
