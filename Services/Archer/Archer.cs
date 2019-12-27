using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickDIDemo.Services.Archer
{
    /// <summary>
    /// 弓兵
    /// </summary>
    public class Archer : IArcher
    {
        public void MultiShot()
        {
            Console.WriteLine("進行多重射擊!!!!");
        }
    }
}
