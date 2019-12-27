using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickDIDemo.Services.Infantry
{
    public class Infantry : IInfantry
    {
        public void Guard()
        {
            Console.WriteLine("進行防禦!!");
        }
    }
}
