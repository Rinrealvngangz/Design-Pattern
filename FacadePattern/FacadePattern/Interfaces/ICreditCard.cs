namespace FacadePattern.Interfaces;

public interface ICreditCard
{
    decimal Balance { get; }
    
    string CardNumber { get; }
    
    void WithdrawMoney(decimal sum);
}