namespace cSharp_withMrMike.String;

public class CardPayment : Paymentprocess
{
    public override bool PaymentMethod(decimal amount)
    {
        if(amount <= 0 )
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Payment should be greater than zero");
        }

        Console.WriteLine("===Card Payment===");
        Console.WriteLine($"Amount: ₦{amount:N2}");
        Console.WriteLine("Validating card");
        Console.WriteLine("Contacting payment gateway");
        Console.WriteLine("Verifying the transaction");
        Console.WriteLine("Payment successful");
        return true;

    }
}