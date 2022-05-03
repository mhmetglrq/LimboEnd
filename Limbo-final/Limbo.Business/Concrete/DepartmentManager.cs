using System.Linq.Expressions;
using Limbo.Business.Abstract;
using Limbo.DataAccess.Abstract;
using Limbo.Entities.Concrete;

namespace Limbo.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public List<Department> GetAll(Expression<Func<Department, bool>> filter = null)
        {
            return _departmentDal.GetAll(filter);
        }

        public Department Get(Expression<Func<Department, bool>> filter)
        {
            return _departmentDal.Get(filter);
        }

        public void Add(Department entity)
        {
            _departmentDal.Add(entity);
        }

        public void Update(Department entity)
        {
            _departmentDal.Update(entity);
        }

        public void Delete(Department entity)
        {
            _departmentDal.Delete(entity);
        }
    }
}
