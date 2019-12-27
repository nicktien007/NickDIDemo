using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NickDIDemo.Services.Archer;
using NickDIDemo.Services.Cavalry;
using NickDIDemo.Services.Infantry;

namespace NickDIDemo
{
    public static class ControllerHelper
    {
        public static ArmyCommandController ArmyCommandController { get; private set; }

        static ControllerHelper()
        {
            RegisterArmyCommandController();
        }

        /// <summary>
        /// 注冊ArmyCommandController
        /// </summary>
        private static void RegisterArmyCommandController()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<ArmyCommandController>();

            builder.RegisterType<Archer>().As<IArcher>();
            builder.RegisterType<Cavalry>().As<ICavalry>();

            //步兵技能改版，抽換步兵的實作
            //builder.RegisterType<Infantry>().As<IInfantry>();
            builder.RegisterType<PowerfulInfantry>().As<IInfantry>();

            IContainer container = builder.Build();

            ArmyCommandController = container.Resolve<ArmyCommandController>();
        }
    }
}
