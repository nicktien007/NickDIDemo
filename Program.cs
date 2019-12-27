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
    /// <summary>
    /// https://dotblogs.com.tw/aken1215/2016/06/22/214006
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //使用New的實作
            //ArmyCommandController controller = new ArmyCommandController(new Archer(), new Cavalry(), new Infantry());
            //controller.SendOrder(ArmyType.Infantry);

            //使用DI的實作，消除了new 關鍵字，更佳的解耦合方式
            ControllerHelper.ArmyCommandController.SendOrder(ArmyType.Cavalry);
            ControllerHelper.ArmyCommandController.SendOrder(ArmyType.Archer);
            ControllerHelper.ArmyCommandController.SendOrder(ArmyType.Infantry);

            Console.Read();
        }
    }

    
}
