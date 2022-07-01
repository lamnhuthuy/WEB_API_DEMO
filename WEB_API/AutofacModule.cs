using Autofac;
using WebApi.Repository.Implementation;
using WebApi.Repository.Interfaces;

namespace WEB_API
{
    public class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>()
           .InstancePerDependency();
            builder.RegisterType<ProductRepository>().As<IProductRepository>()
          .InstancePerDependency();
        }
    }
}
