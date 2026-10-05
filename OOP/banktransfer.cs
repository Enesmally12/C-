namespace cSharp_withMrMike.String;

public  class BankTransfer : Paymentprocess
{
    public override bool PaymentMethod(decimal amount)
    {
        if(amount <=0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Payment amount must be greater than zero.");
        }

        Console.WriteLine("====BANK PAYMENT====");
        Console.WriteLine($"Amount: ₦{amount:N2}");
        Console.WriteLine("Validating Bank");
        Console.WriteLine("Contacting payment gateway");
        Console.WriteLine("Verifying the transaction");
        Console.WriteLine("Payment Successful");
        return true;
    }
}