using StatePattern.GumballState.States.Interface;

namespace StatePattern.GumballState.States;

public class HasQuarterState : IState
{
    private readonly GumballMachineState _gumballMachine;

    public HasQuarterState(GumballMachineState gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        _gumballMachine.SetState(_gumballMachine.NoQuarterState);
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        _gumballMachine.SetState(_gumballMachine.SoldState);
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void Refill() { }

    public override string ToString()
    {
        return "waiting for turn of crank";
    }
}