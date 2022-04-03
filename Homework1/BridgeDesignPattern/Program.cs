// See https://aka.ms/new-console-template for more information
using BridgeDesignPattern;

Payment order = new CardPayment();//kartla ödeme nesnesi oluşturuldu
order._paymentSystem = new CityBankPaymentSystem();//ödeme sistemi için citybankası ödemesi seçildi
order.MakePayment();//ödeme yap



