using impsersonationDemo.User_Objects;
using System;
using System.Collections.Generic;

namespace impsersonationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo clinicKey;

            //Initialize User List
            var permissions2 = new List<string>();
            permissions2.Add("isAdmin");
            permissions2.Add("read:A");
            permissions2.Add("read:B" );
            permissions2.Add("read:C" );
            permissions2.Add("read:D");
            var adminUser = new GenericUser(400,"Sally Admin", permissions2);

            permissions2 = new List<string>();
            permissions2.Add("read:A");
            permissions2.Add("read:B");
            permissions2.Add("read:C");           
            var user1 = new GenericUser(12,"Gerry User", permissions2);

            permissions2 = new List<string>();
            permissions2.Add("read:A");
            permissions2.Add("read:B");          
            var user2 = new GenericUser(50, "Mary Maid", permissions2);

            permissions2 = new List<string>();
            permissions2.Add("read:A");          
            var user3 = new GenericUser(70, "John Smith", permissions2);
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Welcome to the Customer Service screen {adminUser.userId} {adminUser.fullname},  You have the following permissions {String.Join(",", adminUser.permissions)}");
                Console.WriteLine();
                Console.WriteLine("Here is a list of users");
                Console.WriteLine($"Press 1 - {user1.userId} {user1.fullname}  {String.Join(",", user1.permissions)}");
                Console.WriteLine($"Press 2 - {user2.userId} {user2.fullname}  {String.Join(",", user2.permissions)}");
                Console.WriteLine($"Press 3 - {user3.userId} {user3.fullname}  {String.Join(",", user3.permissions)}");
                Console.WriteLine($"Press 4 - Go directly to Clinic Portal as your self");
                BaseUser impsonatedUser = adminUser;
                Console.WriteLine();
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        impsonatedUser = new ImpersonatedUser(user1, adminUser);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        impsonatedUser = new ImpersonatedUser(user2, adminUser);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        impsonatedUser = new ImpersonatedUser(user3, adminUser);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        impsonatedUser = adminUser;
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine($"Welcome to the User Portal Home screen");
                Console.WriteLine();
                impsonatedUser.LogStatement();
                Console.WriteLine($"User Id {impsonatedUser.userId}");
                Console.WriteLine(impsonatedUser.fullname);
                Console.WriteLine( String.Join(",", impsonatedUser.permissions));
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine($"Press 1 - finish impersonation");
                Console.WriteLine($"Press any other key - exit program");
                clinicKey = Console.ReadKey();
                
            } while (clinicKey.Key == ConsoleKey.NumPad1 || clinicKey.Key == ConsoleKey.D1);
            Console.WriteLine();
            Console.WriteLine("Good Bye");
        }
    }
}
