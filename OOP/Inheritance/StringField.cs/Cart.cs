
namespace cSharp_withMrMike.String;

public class Cart : Product, IOrder
{
    public string Name { get; set; }
    public long CustomerID { get; set; }
    public string Email { get; set; }

     decimal Discount;

     decimal Tax;

    private Guid orderID;
    private DateTime orderDate;

    public Cart(string productName,decimal unitPrice,int quantity,string name,long customerID,string email) : base(productName, unitPrice, quantity)
    {
        Name = name;
        CustomerID = customerID;
        Email = email;
    }

    public void Display()
    {
        Console.WriteLine("Customer Details:");
        Console.WriteLine($"ID: {CustomerID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }

    public Guid OrderID()
    {
        orderID = Guid.NewGuid();
        return orderID;
    }

    public DateTime OrderTime()
    {
        orderDate = DateTime.Now;
        return orderDate;
    }

    public override decimal total()
    {
        if(Quantity*UnitPrice > 500000)
        {
            Discount = (Quantity*UnitPrice) * 10 / 100;
        }

        Console.WriteLine($"Discount is {Discount}");


        if(Quantity*UnitPrice > 1000)
        {
            Tax = (Quantity*UnitPrice) * 0.01m;
        }

        Console.WriteLine($"Tax is {Tax}");


        
        
        return Quantity * UnitPrice - Discount + Tax;
    }
}
