namespace BridgeDesignPattern
{
    //Implementer : Bridge : Uygulama kısmi
    // Concrete ve Abstract kısmı birbirinden ayırır
    public interface IPaymentSystem //ödeme sistemi arayüz
        {
            void ProcessPayment(string paymentsystem); //ödeme işlemi sistemiyle beraber
        }
    /

    
}
