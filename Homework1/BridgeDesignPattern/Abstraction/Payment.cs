namespace BridgeDesignPattern
{
    //Abstraction : Soyutlama
    public abstract class Payment
        {
            public IPaymentSystem _paymentSystem; 
            public abstract void MakePayment(); 
        }
    
    
}
