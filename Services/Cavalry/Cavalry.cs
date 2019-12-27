using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickDIDemo.Services.Cavalry
{
    public class Cavalry : ICavalry
    {
        public void Charge()
        {
            Console.WriteLine("進行衝鋒!!");
        }
    }
}
