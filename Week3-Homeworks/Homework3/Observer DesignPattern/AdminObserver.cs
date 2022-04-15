using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DesignPattern
{
    public class AdminObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("New modifications");
        }
    }
}
