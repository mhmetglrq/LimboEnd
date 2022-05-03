using Limbo.Business.Abstract;
using Limbo.Business.Concrete;
using Limbo.DataAccess.Abstract;
using Limbo.DataAccess.Concrete;
using Ninject.Modules;

namespace Limbo.Business.DependencyResolvers.Ninject
{
    internal class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICommentService>().To<CommentManager>().InSingletonScope();
            Bind<ICommentDal>().To<EfCommentDal>().InSingletonScope();
            Bind<IDepartmentService>().To<DepartmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<EfDepartmentDal>().InSingletonScope();
            Bind<IUniversityService>().To<UniversityManager>().InSingletonScope();
            Bind<IUniversityDal>().To<EfUniversityDal>().InSingletonScope();
        }
    }
}
