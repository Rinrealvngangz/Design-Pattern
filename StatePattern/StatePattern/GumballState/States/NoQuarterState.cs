using StatePattern.GumballState.States.Interface;

namespace StatePattern.GumballState;

public class NoQuarterState : IState
{
    private readonly GumballMachineState _gumballMachine;

    public NoQuarterState(GumballMachineState gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        _gumballMachine.SetState(_gumballMachine.HasQuarterState);
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there's no quarter");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }

    public void Refill() { }

    public override string ToString()
    {
        return "waiting for quarter";
    }
}