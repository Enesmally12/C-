public class PaymentResult
{
    public bool IsSuccessful{get; }

    public string Reference{get; }

    public string Message{get; }

    public  PaymentResult(bool isSuccessful, string reference, string message)
    {
        IsSuccessful = isSuccessful;

        Reference = reference;

        Message = message;
    }
}

