using System;

public class Order
{
   public int OrderId { get; set; }
   public DateTime OrderDate { get; set; }

   public Order(int orderId, DateTime orderDate)
   {
       OrderId = orderId;
       OrderDate = orderDate;
   }

   public virtual string GetOrderStatus()
   {
       return "Order placed.";
   }

   public virtual void DisplayOrderDetails()
   {
       Console.WriteLine($"Order ID: {OrderId}, Order Date: {OrderDate.ToShortDateString()}, Status: {GetOrderStatus()}");
   }
}
public class ShippedOrder : Order
{
   public string TrackingNumber { get; set; }

   public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
       : base(orderId, orderDate)
   {
       TrackingNumber = trackingNumber;
   }

   public override string GetOrderStatus()
   {
       return "Order shipped.";
   }

   public override void DisplayOrderDetails()
   {
       base.DisplayOrderDetails();
       Console.WriteLine($"Tracking Number: {TrackingNumber}");
   }
}
public class DeliveredOrder : ShippedOrder
{
   public DateTime DeliveryDate { get; set; }

   public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
       : base(orderId, orderDate, trackingNumber)
   {
       DeliveryDate = deliveryDate;
   }

   public override string GetOrderStatus()
   {
       return "Order delivered.";
   }

   public override void DisplayOrderDetails()
   {
       base.DisplayOrderDetails();
       Console.WriteLine($"Delivery Date: {DeliveryDate.ToShortDateString()}");
   }
}

class Program
{
   static void Main(string[] args)
   {
       Order order = new Order(101, DateTime.Now.AddDays(-10));
       order.DisplayOrderDetails();

       Console.WriteLine("\n");

       ShippedOrder shippedOrder = new ShippedOrder(102, DateTime.Now.AddDays(-5), "TRACK12345");
       shippedOrder.DisplayOrderDetails();

       Console.WriteLine("\n");

       DeliveredOrder deliveredOrder = new DeliveredOrder(103, DateTime.Now.AddDays(-15), "TRACK67890", DateTime.Now.AddDays(-2));
       deliveredOrder.DisplayOrderDetails();
   }
}