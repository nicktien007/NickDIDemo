using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NickDIDemo.Services.Archer;
using NickDIDemo.Services.Cavalry;
using NickDIDemo.Services.Infantry;

namespace NickDIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用New的實作
            //ArmyCommandController controller = new ArmyCommandController(new Archer(), new Cavalry(), new Infantry());
            //controller.SendOrder(ArmyType.Infantry);

            //使用DI的實作，消除了new 關鍵字，更佳的解耦合方式
            ControllerHelper.ArmyCommandController.SendOrder(ArmyType.Cavalry);
            ControllerHelper.ArmyCommandController.SendOrder(ArmyType.Infantry);
        }
    }

    
}
