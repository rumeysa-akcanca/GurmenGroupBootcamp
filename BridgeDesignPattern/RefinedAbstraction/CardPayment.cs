namespace BridgeDesignPattern
{
    //RefinedAbstraction
    public class CardPayment : Payment
        {
            public override void MakePayment()
            {
                _paymentSystem.ProcessPayment("Card Payment");
            }
        }

    //Kartla  ödeme
    //ödeme sınıfından kalıtım alarak  makepayment methodunu eziyor.
    // ödeme arayüzünü (_paymentSystem) kullanarak ödeme işlemine erişiyor
    
}
