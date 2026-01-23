using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bus__ticket_and_service_system
{
    public class Userservice
    {
        private List<User> users = new List<User>();

        public  void AddUser()
        {
            string name;
            while (true)
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name)) break;
                Console.WriteLine("Name cannot be empty!");
            }

            string mobile;
            while (true)
            {
                Console.Write("Enter Mobile Number: ");
                mobile = Console.ReadLine();

                if (!Regex.IsMatch(mobile, @"^\d{11}$"))
                {
                    Console.WriteLine("Mobile number must be 11 digits!");
                    continue;
                }

                if (users.Any(u => u.Mobile == mobile))
                {
                    Console.WriteLine("This mobile number already exists! Enter a different number.");
                    continue;
                }

                break; // valid and unique
            }

            string email;
            while (true)
            {
                Console.Write("Enter Email: ");
                email = Console.ReadLine();

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    Console.WriteLine("Invalid email format!");
                    continue;
                }

                if (users.Any(u => u.Email == email))
                {
                    Console.WriteLine("This email already exists! Enter a different email.");
                    continue;
                }

                break; // valid and unique
            }

            users.Add(new User(name, mobile, email));
            Console.WriteLine("User created successfully!");

        }

        public void ShowUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users available.");
                return;
            }

            Console.WriteLine($"{"ID",-5} {"Name",-30} {"Mobile",-15} {"Email",-40}");
            Console.WriteLine(new string('-', 70)); 

            foreach (var user in users)
            {
                Console.WriteLine($"{user.UserId,-5} {user.Name,-30} {user.Mobile,-15} {user.Email,-40}");
            }

        }
    }
}
