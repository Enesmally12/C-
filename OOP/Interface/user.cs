
namespace cSharp_withMrMike.String;

public class User
{
    private string FirstName {set; get;}

    private string LastName {set; get;}

    private long Id{set; get;}

    public User(string fName, string lName, long id)
    {
        FirstName = fName;

        LastName = lName;

        Id =  id;
    }

    public void display()
    {
        Console.WriteLine($"USERNAME is {Id}: {FirstName} {LastName}");
    }

    

}