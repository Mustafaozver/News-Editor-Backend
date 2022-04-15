using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<NewsManager>().As<INewsService>().SingleInstance();
            builder.RegisterType<EfNewsDal>().As<INewsDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
           
            builder.RegisterType<SourceManager>().As<ISourceService>().SingleInstance();
            builder.RegisterType<EfSourceDal>().As<ISourceDal>().SingleInstance();

            builder.RegisterType<NewsSourceManager>().As<INewsSourceService>().SingleInstance();
            builder.RegisterType<EfNewsSourceDal>().As<INewsSourceDal>().SingleInstance();


            builder.RegisterType<NewsCompanyManager>().As<INewsCompanyServices>().SingleInstance();
            builder.RegisterType<EfNewsCompanyDal>().As<INewsCompanyDal>().SingleInstance();

            builder.RegisterType<NewsCategoriesManager>().As<INewsCategoriesService>().SingleInstance();
            builder.RegisterType<EfNewsCatrgoryDal>().As<INewsCategoriesDal>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();


            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }

    }
}
