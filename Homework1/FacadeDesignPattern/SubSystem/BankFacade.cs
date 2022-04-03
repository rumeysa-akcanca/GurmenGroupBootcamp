namespace FacadeDesignPattern
{
    class BankFacade
    {
    private Bank _bank;
    private CenterBank _centerBank;
    private Credit _credit;

    public BankFacade()
    {
        _bank = new Bank();
       _centerBank = new CenterBank();
        _credit = new Credit();

    }

    public void UsetheCredit(Customer customer, decimal request)
    {
        if (!_centerBank.ControlOfBlackList(customer.IdentityNumber) && _credit.UsetheCreditStatus(customer))
        {
            _bank.UsetheCredit(customer, request);
            Console.WriteLine("Kredi Kullanabilir");
        }

    }
}


}
