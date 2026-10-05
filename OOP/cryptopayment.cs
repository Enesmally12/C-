namespace cSharp_withMrMike.String;

public class CryptoPayment : Paymentprocess
{
    public override bool PaymentMethod(decimal amount)
    {
        if(amount <= 0 )
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Payment amount must be more than zero");
        }

        Console.WriteLine("====CRYPTO PAYMENT====");
        Console.WriteLine($"Amount: ₦{amount:N2}");
        Console.WriteLine("Validating wallet");
        Console.WriteLine("Contacting smart contract");
        Console.WriteLine("Verifying transaction");
        Console.WriteLine("Payment Succesful");
        return true;

    }
}