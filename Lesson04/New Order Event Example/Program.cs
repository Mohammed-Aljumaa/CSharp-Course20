using System;


public class OrderEventArgs : EventArgs
{

    public int OrderID { get;  }
    public string OrderName { get; }
     public string ClientEmail { get; }

    public OrderEventArgs(int OrderID,string OrderName,string ClientEmail)
    {

        this.OrderID = OrderID;
         this.OrderName = OrderName;
        this.ClientEmail = ClientEmail;
    }


}

public class Order
{


    public EventHandler<OrderEventArgs> OnOrderCreated;


    public void Creat(int OrderID, string OrderName, string ClientEmail)
    {

        Console.WriteLine("New Order created; now will notify everyone by raising the event.\n");

        if (OnOrderCreated != null)
        {


            OnOrderCreated(this, new OrderEventArgs(OrderID,OrderName,ClientEmail));
        }

    }


}


public class EmailService
{

    public void Subscribe(Order order)
    {

        order.OnOrderCreated += HandelNewOrder;

    }
      public void UnSubscribe(Order order)
    {

        order.OnOrderCreated -= HandelNewOrder;

    }

    public void HandelNewOrder(object Sender,OrderEventArgs e)
    {
        Console.WriteLine($"---------Email Service---------");
        Console.WriteLine($"SMS Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderName}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nSend an email");
        Console.WriteLine($"--------------------------------");

    }

}

public class SMSServices
{

    public void Subscribe(Order order)
    {

        order.OnOrderCreated += HandelNewOrder;

    }
    public void UnSubscribe(Order order)
    {

        order.OnOrderCreated -= HandelNewOrder;

    }

    public void HandelNewOrder(object Sender, OrderEventArgs e)
    {
        Console.WriteLine($"---------SMS Services---------");
        Console.WriteLine($"SMS Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderName}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nSend an SMS");
        Console.WriteLine($"--------------------------------");

    }



 
}


class Program
{
    static void Main(string[] args)
    {
        var Order = new Order();

        EmailService emailService = new EmailService();

        SMSServices sMSServices = new SMSServices();

        emailService.Subscribe(Order);

        sMSServices.Subscribe(Order);

        sMSServices.UnSubscribe(Order);

        Order.Creat(1, "KM", "klo@gmail.com");

    }

}
