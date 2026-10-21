namespace cSharp_withMrMike.String;

public interface ICustomer
{
    public string Name{set; get;}

    public long CustomerID{set; get;}
    
    public string Email{set; get;}

    public void Display();
   


}
