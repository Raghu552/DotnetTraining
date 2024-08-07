using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                    ========================================================");
            Console.WriteLine("                        WELCOME TO INFINITE RAILWAY RESERVATION PLATFORM ");
            Console.WriteLine("                    ========================================================");
            Console.WriteLine("Enter your Role (Admin or User)");
            string role = Console.ReadLine();

            if (role.ToLower() == "admin")
            {
                Console.WriteLine("Enter your admin credentials");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Enter your Username :");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                string password = Console.ReadLine();
                Console.WriteLine("-----------------------------------");
                Admin_Tasks admin_task = new Admin_Tasks();
                User user = null;
                user = admin_task.Admin_Login(username, password);
                if (user != null)
                {
                    bool exit = false;
                    while (!exit)
                    {
                        Console.WriteLine("SELECT ANY TASK TO PERFORM");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("1. Adding a new Train");
                        Console.WriteLine("2. Update price of the train");
                        Console.WriteLine("3. Update Train Status");
                        Console.WriteLine("4. View Bookings");
                        Console.WriteLine("5. View Cancellations");
                        Console.WriteLine("6. Exit");
                        Console.WriteLine("-------------------------------------");
                        string choice = Console.ReadLine();
                        try
                        {
                            switch (choice)
                            {

                                case "1":
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Enter Train Details:");
                                    Console.WriteLine("Tno || Tname || From || Dest || Price || ClassOfTrain || Status || SeatsAvail");
                                    Train train = new Train
                                    {

                                        Tno = Convert.ToInt32(Console.ReadLine()),
                                        Tname = Console.ReadLine(),
                                        From = Console.ReadLine(),
                                        Dest = Console.ReadLine(),
                                        Price = Convert.ToDecimal(Console.ReadLine()),
                                        Class_of_travel = Console.ReadLine(),
                                        Train_status = Console.ReadLine(),
                                        Seats_available = Convert.ToInt32(Console.ReadLine())

                                    };
                                    admin_task.AddTrain(train);
                                    break;
                                case "2":
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Enter Train Number :");
                                    int tno = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter New Price :");
                                    decimal new_price = Convert.ToDecimal(Console.ReadLine());
                                    admin_task.Price_Update(tno, new_price);
                                    break;
                                case "3":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("Enter Train Number :");
                                    tno = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Train Status (active or Inactive) :");
                                    string status = Console.ReadLine();
                                    admin_task.Train_Status(tno, status);
                                    break;
                                case "4":
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    admin_task.View_Bookings();
                                    break;
                                case "5":
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    admin_task.View_Cancellations();
                                    break;
                                case "6":
                                    exit = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Invalid input type");
                        }
                    }
                }
            }
            else if (role.ToLower() == "user")
            {
                User_Tasks user_task = new User_Tasks();
                Console.WriteLine("------------------------");
                Console.WriteLine("If you are new User...Enter 2 for Registration");
                Console.WriteLine("Enter 1 for Login");
                string userChoice = Console.ReadLine();

                User login = null;

                if (userChoice == "1")
                {
                    Console.WriteLine("Enter your Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter your Password:");
                    string password = Console.ReadLine();
                    login = user_task.LoginUser(username, password);
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Enter your Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Set your Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Set your Password:");
                    string password = Console.ReadLine();

                    User newUser = new User { Name = name, Username = username, Password = password };
                    user_task.RegisterUser(newUser);
                    login = user_task.LoginUser(username, password);
                }

                if (login != null)
                {
                    bool exit = false;
                    while (!exit)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("1. View Train Details");
                        Console.WriteLine("2. Book Tickets");
                        Console.WriteLine("3. Cancel Tickets");
                        Console.WriteLine("4. Exit");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Enter a number :");
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                user_task.ViewTrainDetails();
                                break;
                            case "2":
                                Console.WriteLine("Enter Train Number :");
                                int tno = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Number of Seats to Book");
                                int seats = Convert.ToInt32(Console.ReadLine());
                                user_task.BookTickets(login.UserID, tno, seats);
                                break;
                            case "3":
                                Console.WriteLine("Enter Booking ID :");
                                int bookingId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Number of Seats to Cancel");
                                int seatsToCancel = Convert.ToInt32(Console.ReadLine());
                                user_task.CancelTickets(bookingId, seatsToCancel);
                                break;                           
                            case "4":
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please provide valid input (user or admin) ...");
                Console.Read();
            }
        }
    }
}
