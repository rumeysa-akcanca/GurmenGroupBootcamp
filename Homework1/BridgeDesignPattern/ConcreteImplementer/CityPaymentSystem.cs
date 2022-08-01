namespace BridgeDesignPattern
{
    //Concrete Implementer
    public class CityBankPaymentSystem : IPaymentSystem
        {
            public void ProcessPayment(string paymentsystem)
            {
                Console.WriteLine("Using CityBank gateway for " + paymentsystem);
            }
        //ödeme arayüzünden implementasyon alan concrete sınıf banka ödeme sistemi 
        //oluşturuldu
        
      

        }

    
}
