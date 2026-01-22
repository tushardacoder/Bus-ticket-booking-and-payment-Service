// See https://aka.ms/new-console-template for more information



using Bus__ticket_and_service_system;
using System.Text.RegularExpressions;
Userservice userService = new Userservice();
while (true)
{


    Console.WriteLine("--- Bus Ticket Booking System ---- ");
    Console.WriteLine();
    Console.WriteLine("1. Create User");
    Console.WriteLine("2. Show Users");
    Console.WriteLine("3. Create Bus");
    Console.WriteLine("4. Show Buses");
    Console.WriteLine("5. Create Schedule");
    Console.WriteLine("6. Show Schedules");
    Console.WriteLine("7. Show Schedule Details");
    Console.WriteLine("8. Book Ticket");
    Console.WriteLine("9. Show Invoices of a user");
    Console.WriteLine("10. Pay Invoice");
    Console.WriteLine("11. Show Tickets of a User");
    Console.WriteLine("Exit");


    Console.WriteLine("Enter Your Option");
    var option= Console.ReadLine();


    if (option == "1")
    {


        userService.AddUser();
        Console.WriteLine();


    }

    else if (option == "2")
    {
         userService.ShowUsers();
         Console.WriteLine();
    }



    else
    {
        break;
    }






}