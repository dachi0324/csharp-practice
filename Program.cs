using System.ComponentModel.DataAnnotations.Schema;

List<INotifier> notifier = new List<INotifier>
{
  new   EmailNotifier(),
  new SmsNotifier(),
  new PushNotifier()
};

foreach (INotifier i in notifier)
{
    i.send("Hello");
}
Order d = new Order("Pizza");
d.Complete(new EmailNotifier());
d.Complete(new SmsNotifier());
d.Complete(new PushNotifier());
interface INotifier
{
    void send(string message);
}

class EmailNotifier : INotifier
{
    public void send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}

class SmsNotifier : INotifier
{
    public void send(string message)
    {
        Console.WriteLine($"Sms : {message}");
    }
}

class PushNotifier : INotifier
{
    public void send(string message)
    {
        Console.WriteLine($"Push:  {message}");
    }
}

class Order
{
    public string ItemName;

    public Order(string itemname)
    {
        ItemName = itemname;
    }

    public void Complete(INotifier notifier)
    {
       Console.WriteLine($"{ItemName} completed"); 
       notifier.send($"{ItemName} is ready" );
    }
}