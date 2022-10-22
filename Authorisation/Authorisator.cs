using System.Runtime.CompilerServices;

namespace Authorisation;

public class Authorisator
{
    public User CurrentUser;

    private UserService _userService = new UserService();

    public void RegisterNewUser(string login, string password)
    {
        if (_userService.GetUser(login) != null)
        {
            throw new Exception("user already exists");
        }
        
        _userService.CreateNewUser(login, password);
    }

    public void Login(string login, string password)
    {
        if (CurrentUser != null)
        {
            throw new Exception("already login inn");
        }

        var user = _userService.GetUser(login);
        
        if (user == null)
        {
            throw new Exception("No such user");
        }

        if (password == user.Password)
        {
            CurrentUser = user;
        }
        else
        {
            throw new Exception("Incorrect password");
        }
    }

    public void Logout()
    {
        if (CurrentUser == null)
        {
            throw new Exception("already logged out");
        }
        
        CurrentUser = null;
    }
}