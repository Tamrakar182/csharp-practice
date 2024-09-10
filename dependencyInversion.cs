// High-level modules should not depend on low-level modules. 
// Both should depend on abstractions. Abstractions should not depend on details. 
// Details should depend on abstractions.

public interface IMessageService
// here our abstraction is this interface between the 
//  email service and sms service
{
    void SendMessage(string message);
}

public class EmailService : IMessageService
// here we implement email service depending upon the abstraction (interface)
// and the specific implementation is done within this class
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class SmsService : IMessageService
// here we implement sms service depending upon the abstraction (interface)
// and the specific implementation is done within this class
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

public class MessageSender
{
    private readonly IMessageService _messageService;

    public MessageSender(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void SendMessage(string message)
    {
        _messageService.SendMessage(message);
    }
}
