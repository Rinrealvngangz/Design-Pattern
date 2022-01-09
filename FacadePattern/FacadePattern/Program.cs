
using FacadePattern.Facade;
using FacadePattern.Interfaces;
using FacadePattern.Services;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard = new CreditCard();
            var paymentFacade = new PaymentFacade();
            paymentFacade.PayForAll(creditCard, 270, 325, 75);
            paymentFacade.PayForHomeAndCredit(creditCard, 270, 325);
            paymentFacade.PayForHomeAndUniversity(creditCard, 270, 75);
            paymentFacade.PayForCreditAndUniversity(creditCard, 325, 75);
            Console.ReadLine();
        }
    }
}