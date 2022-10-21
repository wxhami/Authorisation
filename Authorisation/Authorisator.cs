using System.Runtime.CompilerServices;

namespace Authorisation;

public class Authorisator
{
    public User CurrentUser;
    
    private UserService _userService = new UserService();
    
    public void RegisterNewUser(string login, string password)
    {
        _userService.CreateNewUser(login, password);
    }

    public void Login(string login, string password)
    {
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
        CurrentUser = null;
    }
}