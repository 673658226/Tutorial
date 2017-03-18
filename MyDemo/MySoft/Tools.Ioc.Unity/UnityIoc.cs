using Microsoft.Practices.Unity;
using Qx.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using users.Entity;
using users.Interfaces;
using users.Repository;
using users.Services;

namespace Tools.Ioc.Unity
{
    public static class UnityIoc
    {
        public static void Register(List<Type> controllers)
        {
            //Container
            IUnityContainer container = new UnityContainer();
            //Register controllers
            controllers.ForEach(c => container.RegisterType(c));
            //Register Services
            RegisterServices(container);
            //Resolver
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
        static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IRepository<users.Entity.users>, usersRepository>();
            container.RegisterType<IuserPrivider, userProvider>();
        }
    }
}
