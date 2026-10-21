
namespace cSharp_withMrMike.String;

public abstract class Product
{
public string ProductName {get;}

public decimal UnitPrice{get;}

public int Quantity{get;}

protected Product(string productName, decimal unitPrice, int quantity)
{
    if(string.IsNullOrWhiteSpace(productName)) throw new ArgumentNullException(nameof(productName), "Product Name cannot be empty.");

    if(unitPrice<= 0) throw new ArgumentOutOfRangeException(nameof(unitPrice), "Price must be greater than zero");

    if( quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity), "The quantity should be grater than zero.");

    ProductName = productName;

    UnitPrice = unitPrice;

    Quantity = quantity;
}

public abstract decimal total();

}