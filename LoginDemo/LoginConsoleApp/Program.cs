using System;
using LoginBl;
using Persistance;

namespace LoginConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserBl bl = new UserBl();
            Console.Write("User Name: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = GetPassword();
            Console.WriteLine();
            User user = bl.Login(userName, password);
            if(user!=null){
                Console.WriteLine("Login successfully!");
                switch (user.Role)
                {
                    case 1:
                        Console.WriteLine("Role 1");
                        break;
                    default:
                        Console.WriteLine("default user");
                        break;
                }
            }else {
                Console.WriteLine("Login fail!");
            }
        }

        
        static string GetPassword()
        {
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return pass;
        }
    }
}
