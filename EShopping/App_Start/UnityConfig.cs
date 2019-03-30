using EShopping.Controllers;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;
using EShopping.Service.CategoryServices;

namespace EShopping
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            container.RegisterType<ICategoryService,CategoryService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}