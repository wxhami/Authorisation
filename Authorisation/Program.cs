using System.Runtime.CompilerServices;
using Authorisation;

Authorisator authorisator = new Authorisator();

    Console.WriteLine("Choose action: 1 - authorisation, 2 - login, 3 - logout");
string choice = Console.ReadLine();
if (choice == "1")
{
    Console. WriteLine("Enter your login: ");
    string login = Console.ReadLine();
    Console.WriteLine("Enter your password: ");
    string password = Console.ReadLine();
    authorisator.RegisterNewUser(login, password);
}

if (choice == "2")
{
    Console.WriteLine("Enter your login: ");
    string login = Console.ReadLine();
    Console.WriteLine("Enter your password");
    string password = Console.ReadLine();
    authorisator.Login(login, password);
}

if (choice == "3")
{
    authorisator.Logout();
}
