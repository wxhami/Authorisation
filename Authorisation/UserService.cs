namespace Authorisation;

public class UserService
{
    public List<User> Users = new List<User>();

    public void CreateNewUser(string username, string password)
    {
        User newUser = new User(username, password);
        Users.Add(newUser);
    }

    public User GetUser(string login)
    {
        foreach (var user in Users)
        {
            if (user.Username == login)
            {
                return user;
            }
        }

        return null;
    }
}