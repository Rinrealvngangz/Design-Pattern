

using StatePattern.GumballState;

namespace StatePattern;

class Program
{
    static void Main(string[] args)
    {
       /* GumballMachine gumballMachine = new GumballMachine(5);

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.EjectQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.EjectQuarter();

        Console.WriteLine(gumballMachine);

        gumballMachine.InsertQuarter();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        Console.WriteLine(gumballMachine);*/
       
       GumballMachineState gumballMachine = new GumballMachineState(2);

       Console.WriteLine(gumballMachine);

       gumballMachine.InsertQuarter();
       gumballMachine.TurnCrank();

       Console.WriteLine(gumballMachine);

       gumballMachine.InsertQuarter();
       gumballMachine.TurnCrank();
       gumballMachine.InsertQuarter();
       gumballMachine.TurnCrank();

       gumballMachine.Refill(5);
       gumballMachine.InsertQuarter();
       gumballMachine.TurnCrank();

       Console.WriteLine(gumballMachine);
    }
}

