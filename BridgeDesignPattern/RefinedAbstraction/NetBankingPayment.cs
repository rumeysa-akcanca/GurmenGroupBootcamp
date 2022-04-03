namespace BridgeDesignPattern
{
    //RefinedAbstraction
    public class NetBankingPayment : Payment
        {
            public override void MakePayment()
            {
                _paymentSystem.ProcessPayment("NetBanking Payment");
            }
        }
    //internet bankacılığı ödeme 
    //ödeme sınıfından kalıtım alarak  makepayment methodunu eziyor.
    //ödeme arayüzünü kullanarak ödeme işlemine erişiyor.
    
}
