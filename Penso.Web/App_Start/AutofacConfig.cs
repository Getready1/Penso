using Autofac;
using Autofac.Integration.Mvc;
using Penso.Persistance;
using Penso.Persistance.Repositories;
using Penso.Persistance.RepositoryInterfaces;
using Penso.Service;
using Penso.Service.ServiceInterfaces;
using System.Web.Mvc;

namespace Penso.Web.App_Start
{
	public class AutofacConfig
	{
		public static void RegisterAutofac()
		{
			var builder = new ContainerBuilder();
			builder.RegisterControllers(typeof(AutofacConfig).Assembly);
			builder.RegisterType<UserManagement>().As<IUserManagement>();
			builder.RegisterType<UserRepository>().As<IUserRepository>();
			builder.RegisterType<PensoContext>().AsSelf();
			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}