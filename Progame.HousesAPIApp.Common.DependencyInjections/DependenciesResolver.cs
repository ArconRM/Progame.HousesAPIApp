using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Progame.HousesAPIApp.BLL.Interfaces;
using Progame.HousesAPIApp.BLL;
using Progame.HousesAPIApp.DAL.Interfaces;
using Progame.HousesAPIApp.DAL;

namespace Progame.HousesAPIApp.Common.DependencyInjections
{
    public class DependenciesResolver
    {
        public static IServiceProvider Kernel { get; set; }
        private static IServiceCollection _services { get; set; }

        static DependenciesResolver()
        {
            _services = new ServiceCollection();
            Kernel = Config();
        }

        private static IServiceProvider Config()
        {
            _services.AddTransient<IBuyerService, BuyerService>();
            _services.AddTransient<IEstateAgentService, EstateAgentService>();
            _services.AddTransient<IHouseService, HouseService>();
            _services.AddTransient<IOwnerService, OwnerService>();

            _services.AddTransient<IBuyerDAL, BuyerDAL>();
            _services.AddTransient<IEstateAgentDAL, EstateAgentDAL>();
            _services.AddTransient<IHouseDAL, HouseDAL>();
            _services.AddTransient<IOwnerDAL, OwnerDAL>();

            return _services.BuildServiceProvider();
        }
    }
}
