using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    //Concrete Implementer
    public class VillageBankPaymentSystem : IPaymentSystem
        {
            public void ProcessPayment(string paymentsystem)
            {
                Console.WriteLine("Using VillageBank gateway for " + paymentsystem);
            }
        }

    
}
