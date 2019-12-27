using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickDIDemo.Services.Infantry
{
    /// <summary>
    /// 由於步兵沒有人玩，所以進行技能強化改版
    /// </summary>
    public class PowerfulInfantry : IInfantry
    {
        public void Guard()
        {
            Console.WriteLine("我是改版後的防禦技能，超級逆天!!進行防禦，並反彈所受傷害25%!!");
        }
    }
}
