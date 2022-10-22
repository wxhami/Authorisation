using System.Runtime.CompilerServices;
using Authorisation;

Authorisator authorisator = new Authorisator();

bool isAlive = true;

while (isAlive)
{
    Console.WriteLine("\nChoose action: 1 - authorisation, 2 - login, 3 - logout, 4 - shut down");
    string choice = Console.ReadLine();
    Console.Clear();
    try
    {
        switch (choice)
        {
            case "1":
                Register();
                break;
            case "2":
                Login();
                break;
            case "3":
                Logout();
                break;
            case "4":
                isAlive = false;
            break;

        }
        
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
}

void Register()
{
    Console.Write("Enter your login: ");
    string login = Console.ReadLine();

    Console.Write("Enter your password: ");
    string password = Console.ReadLine();

    authorisator.RegisterNewUser(login, password);

    Console.WriteLine("success: new user added");
}

void Login()
{
    Console.Write("Enter your login: ");
    string login = Console.ReadLine();

    Console.Write("Enter your password");
    string password = Console.ReadLine();

    authorisator.Login(login, password);

    Console.WriteLine("success: user logged in");
}

void Logout()
{
    authorisator.Logout();
    Console.WriteLine("success: user logged out");
}