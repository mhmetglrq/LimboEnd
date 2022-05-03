using System.Linq.Expressions;
using Limbo.Business.Abstract;
using Limbo.DataAccess.Abstract;
using Limbo.Entities.Concrete;

namespace Limbo.Business.Concrete
{
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.GetAll(filter);
        }

        public Comment Get(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.Get(filter);
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }
    }
}
