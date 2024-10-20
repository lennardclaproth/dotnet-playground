namespace DesignPatterns.State.Ticketing;

public interface ITicketState
{
    void Handle(TicketContext context);
    void Close(TicketContext context);
}
