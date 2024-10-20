namespace DesignPatterns.State.Ticketing;

public class InProgressState : ITicketState
{
    public void Handle(TicketContext context)
    {
        Console.WriteLine("Ticket is already in progress.");
    }

    public void Close(TicketContext context)
    {
        Console.WriteLine("Ticket is now Closed.");
        context.SetState(new ClosedState());
    }
}
