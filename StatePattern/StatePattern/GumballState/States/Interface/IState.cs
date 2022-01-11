namespace StatePattern.GumballState.States.Interface;

public interface IState
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();

    void Refill();
}