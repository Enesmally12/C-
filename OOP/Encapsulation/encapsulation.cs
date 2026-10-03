namespace cSharp_withMrMike.String;


public class Wallet
{
    public decimal Balance {get; private set;}

    public Wallet(decimal Samount)
    {
        if(Samount<0)
        {
            throw new ArgumentOutOfRangeException(nameof(Samount), "The starting balance can't be less tahn zero");
        }

        Balance+=Samount;
    }

    public void Deposit(decimal Damount)
    {
        if(Damount <= 0 )
        {
            throw new ArgumentOutOfRangeException(nameof(Damount), "Deposit must be greater than 0");
        }

        Balance+=Damount;
    }

    public void Withdraw(decimal Wamount)
    {
        if(Wamount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Wamount), "Withdrawal amount must be greater than 0");
        }


        if(Wamount > Balance )
        {
            throw new ArgumentOutOfRangeException(nameof(Wamount), "Insufficent funds top up balance and retry");
        }
    }
}