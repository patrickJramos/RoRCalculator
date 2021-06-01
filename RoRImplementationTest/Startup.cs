using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RoR;
using RoRImplementation.Game;
using RoRImplementation.Player.Players.Commando;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;
using Xunit.DependencyInjection;

namespace RoRImplementationTest
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IGameManager, GameManager>();
            services.AddTransient<IItemManager, ItemManager>();
            services.AddTransient<IPlayer, Commando>();
        }

    }
}
