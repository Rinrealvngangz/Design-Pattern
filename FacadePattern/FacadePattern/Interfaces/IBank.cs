namespace FacadePattern.Interfaces;

public interface IBank
{
    void PayForHome(ICreditCard creditCard, decimal homeTaxes);
    
    void PayForCredit(ICreditCard creditCard, decimal creditTaxes);
    
    void PayForUniversity(ICreditCard creditCard, decimal universityTaxes);
}