namespace cSharp_withMrMike.String;

public interface IUser
{
    
    public string RegisterNewUser(User user);

    public List<User> getAllUser();

    public User getSingleUser(long id);

    public void deleteUser(); 

    public User UpdateUsers(User user);

}