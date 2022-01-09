using FacadePattern.Interfaces;
using FacadePattern.Services;

namespace FacadePattern.Facade;

public class PaymentFacade
{
    private readonly IBank _bank;
    
    public PaymentFacade()
    {
        _bank = new Bank();
    }
    
    public void PayForHomeAndCredit(ICreditCard creditCard, decimal homePayment, decimal creditPayment)
    {
        _bank.PayForHome(creditCard, homePayment);
        _bank.PayForCredit(creditCard, creditPayment);
    } 
    
    public void PayForHomeAndUniversity(ICreditCard creditCard, decimal homePayment, decimal universityPayment)
    {
        _bank.PayForHome(creditCard, homePayment);
        _bank.PayForUniversity(creditCard, universityPayment);
    }
   
    public void PayForCreditAndUniversity(ICreditCard creditCard, decimal creditPayment, decimal universityPayment)
    {
        _bank.PayForCredit(creditCard, creditPayment);
        _bank.PayForUniversity(creditCard, universityPayment);
    }
    
    public void PayForAll(ICreditCard creditCard, decimal homePayment, decimal creditPayment, decimal universityPayment)
    {
        _bank.PayForHome(creditCard, homePayment);
        _bank.PayForCredit(creditCard, creditPayment);
        _bank.PayForUniversity(creditCard, universityPayment);
    }
    
    
    
}