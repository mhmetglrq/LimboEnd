using Ninject;

namespace Limbo.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            return new StandardKernel(new BusinessModule()).Get<T>();
        }
    }
}
