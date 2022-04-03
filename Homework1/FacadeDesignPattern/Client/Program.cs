// See https://aka.ms/new-console-template for more information
using FacadeDesignPattern;
BankFacade bankFacade = new BankFacade();
bankFacade.UsetheCredit(new Customer { Name = "Rumeysa", IdentityNumber = "1213456", CustomerId = 232323 }, 1000);
