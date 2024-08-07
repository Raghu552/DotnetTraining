using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Railway_Project
{
    public class User_Tasks
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        private static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = ICS-LT-5S26573; initial catalog = railway;" +
                "user id=sa; password=Infinite@552");
            con.Open();
            return con;
        }
        
        public void RegisterUser(User user)
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("insert into Users values (@Name, @Username, @Password)", con);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.ExecuteNonQuery();
                Console.WriteLine("User registered successfully.");
                Console.WriteLine("-------------------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine("Username Cannot be Same, Enter unique Username : " + e.Message);
                Console.Read();
            }
        }

        public User LoginUser(string username, string password)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from Users where Username = @Username and Password = @Password", con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return new User
                {
                    UserID = (int)dr["UserID"],
                    Name = dr["Name"].ToString(),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString()
                };
            }
            else
            {
                Console.WriteLine("Invalid credentials or user does not exist.");
                Console.Read();
                return null;
            }

        }
        public void ViewTrainDetails()
        {
            con = getConnection();
            cmd = new SqlCommand("select * from Trains", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"TrainNo: {dr["Tno"]} || Name: {dr["Tname"]} || From: {dr["From"]} || Destination: {dr["Dest"]} || Price: {dr["Price"]} || Class: {dr["Class_of_travel"]} || Status: {dr["Train_status"]} || SeatsAvail: {dr["Seats_available"]}");
            }

        }

        public void BookTickets(int userId, int tno, int seats)
        {
            con = getConnection();
            cmd = new SqlCommand("select Seats_available, Train_status from Trains where Tno = @Tno", con);
            cmd.Parameters.AddWithValue("@Tno", tno);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int availableSeats = (int)dr["Seats_available"];
                string trainStatus = dr["Train_status"].ToString();

                if (trainStatus == "active")
                {
                    if (seats > 3)
                    {
                        Console.WriteLine("Cannot book more than 3 seats at a time.");
                        return;
                    }
                    if (seats <= availableSeats)
                    {
                        dr.Close();

                        cmd = new SqlCommand("insert into Bookings values (@UserID, @Tno, @Number_of_seats, @BookingDate)", con);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Tno", tno);
                        cmd.Parameters.AddWithValue("@Number_of_seats", seats);
                        cmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("update Trains set Seats_available = Seats_available - @Seats where Tno = @Tno", con);
                        cmd.Parameters.AddWithValue("@Seats", seats);
                        cmd.Parameters.AddWithValue("@Tno", tno);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Tickets Booked Successfully");
                        PrintTicket(userId, tno, seats);
                    }
                    else
                    {
                        Console.WriteLine("Not enough seats available.");
                    }
                }
                else
                {
                    Console.WriteLine("Cannot book tickets for an inactive train.");
                }
            }
            else
            {
                Console.WriteLine("Train not found.");
            }

        }


        public void PrintTicket(int userId, int tno, int seats)
        {
            con = getConnection();

            cmd = new SqlCommand("select Tname, [From], Dest, Price, Class_of_travel from Trains where Tno = @Tno", con);
            cmd.Parameters.AddWithValue("@Tno", tno);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string trainName = dr["Tname"].ToString();
                string from = dr["From"].ToString();
                string dest = dr["Dest"].ToString();
                decimal price = (decimal)dr["Price"];
                string classOfTravel = dr["Class_of_travel"].ToString();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("======================== RAILWAY TICKET ========================");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Train: {trainName}     ||     From: {from}      ||       To: {dest}");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Class: {classOfTravel}     ||    Seats: {seats}     ||   Price per Seat: {price}");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Total Price: {price * seats}                Booking Date: {DateTime.Now}");
                Console.WriteLine("--------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Error retrieving train details.");
            }

        }

        public void CancelTickets(int bookingId, int seatsToCancel)
        {
            con = getConnection();

            cmd = new SqlCommand("select Tno, Number_of_seats from Bookings where BookingID = @BookingID", con);
            cmd.Parameters.AddWithValue("@BookingID", bookingId);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int tno = (int)dr["Tno"];
                int bookedSeats = (int)dr["Number_of_seats"];

                if (seatsToCancel <= bookedSeats)
                {
                    dr.Close();

                    cmd = new SqlCommand("insert into Cancellations (BookingID, Number_of_seats, CancellationDate) values (@BookingID, @Number_of_seats, @CancellationDate)", con);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.Parameters.AddWithValue("@Number_of_seats", seatsToCancel);
                    cmd.Parameters.AddWithValue("@CancellationDate", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("update Bookings set Number_of_seats = Number_of_seats - @Seats where BookingID = @BookingID", con);
                    cmd.Parameters.AddWithValue("@Seats", seatsToCancel);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("update Trains set Seats_available = Seats_available + @Seats where Tno = @Tno", con);
                    cmd.Parameters.AddWithValue("@Seats", seatsToCancel);
                    cmd.Parameters.AddWithValue("@Tno", tno);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Tickets canceled successfully. Refund will be initiated shortly.");
                }
                else
                {
                    Console.WriteLine("Cannot cancel more seats than were booked.");
                }
            }
            else
            {
                Console.WriteLine("Booking not found.");
            }

        }
    }
}
